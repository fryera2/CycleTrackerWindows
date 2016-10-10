using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace CycleTracker.Excel
{
    public class ExcelCoordinator : IDisposable
    {
        private Workbook _excelWorkbook;
        private Application _application = null;
        private List<Worksheet> _worksheets = null;

        private Application ExcelApplication
        {
            get
            {
                if (_application == null)
                {
                    _application = new Application();
                }
                return _application;
            }
        }

        private List<Worksheet> Worksheets
        {
            get
            {
                if (_worksheets == null)
                {
                    _worksheets = _excelWorkbook.Worksheets.Cast<Worksheet>().ToList();
                }
                return _worksheets;
            }
        }

        public ExcelCoordinator (string workbook)
        {
            _excelWorkbook = ExcelApplication.Workbooks.Open(workbook);
        }

        public List<string> GetWorkSheetList()
        {
            return Worksheets.Select(w => w.Name).ToList();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _excelWorkbook.Close();
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
