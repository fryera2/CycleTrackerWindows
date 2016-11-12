using CycleTracker.Database;
using CycleTracker.Database.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.BusinessObjects
{
    public class ApplicationCoordinator : BaseCoordinator
    {

        private int _selectedMonth;
        private int _selectedYear;

        public List<int> RideYears
        {
            get
            {
                return DatabaseCoordinator.RideYears;
            }
        }

        public List<string> RideMonths
        {
            get
            {
                return DatabaseCoordinator.RideMonths;
            }
        }

        public int SelectedMonth
        {
            get
            {
                return _selectedMonth;
            }
            set
            {
                _selectedMonth = value;
            }
        }

        public int SelectedYear
        {
            get
            {
                return _selectedYear;
            }
            set
            {
                _selectedYear = value;
            }
        }

        public List<FilteredRide> GetFilteredRides ()
        {
            return DatabaseCoordinator.GetFilteredRides(SelectedMonth, SelectedYear);
        }

        public List<FilteredRide> GetPreviousFilteredRides()
        {
            return DatabaseCoordinator.GetFilteredRides(SelectedMonth, SelectedYear - 1);
        }
    }
}
