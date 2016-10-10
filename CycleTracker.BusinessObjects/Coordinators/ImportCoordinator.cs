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

        private ExcelCoordinator SpreadsheetCoordinator
        {
            get
            {
                if (_spreadsheetCoordinator == null)
                {
                    _spreadsheetCoordinator = new ExcelCoordinator();
                }
                return _spreadsheetCoordinator;
            }
        }
    }
}
