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

        public ImportCoordinator (string fileName)
        {
            DatabaseCoordinator.ClearDatabase();
            _fileName = fileName;
        }

        public void ImportRecords ()
        {
            
            List<ActivityRecord> activities = SpreadsheetCoordinator.ImportRecords();
            DatabaseCoordinator.WriteActivities(activities);
        }

    }
}
