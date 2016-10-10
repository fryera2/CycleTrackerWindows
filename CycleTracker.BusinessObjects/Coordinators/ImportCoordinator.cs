using CycleTracker.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.BusinessObjects
{
    public class ImportCoordinator : BaseCoordinator
    {
        private ExcelCoordinator _spreadsheetCoordinator = null;
        private string _fileName;

        private ExcelCoordinator SpreadsheetCoordinator
        {
            get
            {
                if (_spreadsheetCoordinator == null)
                {
                    _spreadsheetCoordinator = new ExcelCoordinator(_fileName);
                }
                return _spreadsheetCoordinator;
            }
        }

        public ImportCoordinator (string fileName)
        {
            _fileName = fileName;
        }

        public void ImportRecords ()
        {
        }

        public List<string> GetWorkSheetList()
        {
            return SpreadsheetCoordinator.GetWorkSheetList();
        }
    }
}
