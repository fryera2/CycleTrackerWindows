using CycleTracker.Database;
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
        private ExcelImportCoordinator _spreadsheetCoordinator = null;
        private DatabaseCoordinator _databaseCoordinator = null;
        private string _fileName;

        private ExcelImportCoordinator SpreadsheetCoordinator
        {
            get
            {
                if (_spreadsheetCoordinator == null)
                {
                    _spreadsheetCoordinator = new ExcelImportCoordinator(_fileName);
                }
                return _spreadsheetCoordinator;
            }
        }

        private DatabaseCoordinator DatabaseCoordinator
        {
            get
            {
                if (_databaseCoordinator == null)
                {
                    _databaseCoordinator = new DatabaseCoordinator();
                }
                return _databaseCoordinator;
            }
        }

        public ImportCoordinator (string fileName)
        {
            DatabaseCoordinator.ClearDatabase();
            _fileName = fileName;
        }

        public void GetListOfBikes ()
        {
            Dictionary<string, int> bikes = SpreadsheetCoordinator.GetBikes();
            DatabaseCoordinator.CreateListOfBikes(bikes);
        }

        public void ImportRecords (string worksheetName)
        {
            
            SpreadsheetCoordinator.ImportRecords(worksheetName);
        }

    }
}
