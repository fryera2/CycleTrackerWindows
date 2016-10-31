using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using LinqToExcel;
using log4net;

namespace CycleTracker.Excel
{
    public class ExcelImportCoordinator : IDisposable
    {
        private ExcelQueryFactory _excelWorkbook;
        private Application _application = null;



        public ExcelImportCoordinator (string workbook)
        {
            _excelWorkbook = new ExcelQueryFactory(workbook);
        }

        public List<string> GetWorkSheetList()
        {
            return _excelWorkbook.GetWorksheetNames().Where (w => w.Contains ("Cycling")).ToList();
        }

        public void ImportRecords (string worksheetName)
        {
            var results = (from w in _excelWorkbook.Worksheet(worksheetName)
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
                    _excelWorkbook.Dispose();
                    _excelWorkbook = null;
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
