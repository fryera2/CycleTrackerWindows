using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using LinqToExcel;
using log4net;
using LinqToExcel.Query;
using CycleTracker.Database;

namespace CycleTracker.Excel
{
    public class ExcelImportCoordinator : IDisposable
    {

        private string workbookName = string.Empty;
        private ExcelQueryFactory _excelWorkbook;
        private ExcelQueryFactory ExcelWorkbook
        {
            get
            {
                if (_excelWorkbook == null)
                {
                    _excelWorkbook = new ExcelQueryFactory(workbookName);
                }
                return _excelWorkbook;
            }
            
        }
      

        private List<string> _worksheetList = null;
        private List<string> WorksheetList
        {
            get
            {
                if (_worksheetList == null)
                {
                    _worksheetList = ExcelWorkbook.GetWorksheetNames().Where(w => w.Contains("Cycling")).ToList();
                }
                return _worksheetList;
            }
        }

        private List<WorksheetBikeMapping> _bikeMappings = null;
        private List<WorksheetBikeMapping> BikeMappings
        {
            get
            {
                if (_bikeMappings == null)
                {
                    _bikeMappings = new List<WorksheetBikeMapping>();
                }
                return _bikeMappings;
            }
        }

        public ExcelImportCoordinator (string workbook)
        {
            workbookName = workbook;
        }

        public Dictionary<string, int> GetBikes()
        {
            Dictionary<string, int> bikes = new Dictionary<string, int>();
            int bikeIndex = 1;

            foreach (string worksheetName in WorksheetList)
            {
                int startIndex = 7;
                List<string> columns = ExcelWorkbook.GetColumnNames(worksheetName).ToList();
                while (true)
                {
                    string currentValue = columns[startIndex];
                    if (currentValue == string.Format ("F{0}", (startIndex + 1)))
                    {
                        break;
                    }
                    if (!bikes.Any (b => b.Key == currentValue))
                    {
                        bikes.Add(currentValue, bikeIndex);
                        BikeMappings.Add(new WorksheetBikeMapping
                        {
                            WorksheetName = worksheetName,
                            BikeId = bikeIndex,
                            ColumnId = startIndex
                        });
                        bikeIndex++;
                    }
                    else
                    {
                        int bikeId = bikes.Where(b => b.Key == currentValue).Select(b => b.Value).Single();
                        BikeMappings.Add(new WorksheetBikeMapping
                        {
                            WorksheetName = worksheetName,
                            BikeId = bikeId,
                            ColumnId = startIndex
                        });
                        
                    }

                    startIndex++;
                }
            }
            return bikes;
        }

        public List<ActivityRecord> ImportRecords ()
        {
            List<ActivityRecord> activities = new List<ActivityRecord>();
            foreach (string worksheetName in WorksheetList)
            {
                Dictionary<int, int> worksheetMappings = BikeMappings.Where(m => m.WorksheetName == worksheetName)
                                                                     .ToDictionary(key => key.ColumnId, value => value.BikeId);

                List<ActivityRecord> results = (from w in ExcelWorkbook.Worksheet(worksheetName)
                                                where w["Date"] != null
                                                select new ActivityRecord
                                                {
                                                    ActivityDate = Convert.ToDateTime(w["Date"].Value),
                                                    TimeInMinutes = Convert.ToDecimal(w["Time (mins)"].Value),
                                                    DistanceInMiles = Convert.ToDecimal(w["Distance (Miles)"]),
                                                    BikeId = GetBikeId(worksheetMappings, w),
                                                    Ascent = (w["Ascent"].Value == null) ? 0 : Convert.ToInt32(w["Ascent"].Value)
                                                }).ToList();

                activities.AddRange(results);
            }

            return activities;

        }

        private int GetBikeId (Dictionary<int, int> mappings, Row currentRow)
        {
            foreach (int rowId in mappings.Select (m => m.Key))
            {
                if (currentRow[rowId].Value.ToString() == "X")
                {
                    return mappings[rowId];
                }
            }

            return mappings[mappings.Select (m => m.Key).First()];
        }

        private void GetBikeList(ListRow currentRow)
        {
            List<string> bikes = new List<string>();
            int startIndex = 8;

            while (currentRow.Range[0, startIndex] != string.Empty)
            {

            }

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    ExcelWorkbook.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    public class WorksheetBikeMapping
    {
        public string WorksheetName { get; set; }
        public int ColumnId { get; set; }
        public int BikeId { get; set; }
    }
}
