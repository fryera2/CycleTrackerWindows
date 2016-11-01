using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using LinqToExcel;
using log4net;
using LinqToExcel.Query;

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
                        bikeIndex++;
                    }

                    startIndex++;
                }
            }
            return bikes;
        }

        public void ImportRecords (string worksheetName)
        {
            var results = (from w in ExcelWorkbook.Worksheet(worksheetName)
                           select new
                           {
                               Date = w["Date"].Value,
                               Time = w["Time (mins)"].Value,
                               Distance = w["Distance (Miles)"],
                           }).ToList();

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
}
