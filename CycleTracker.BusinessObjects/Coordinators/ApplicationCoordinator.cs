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
        private int _selectedCurrentYear;
        private int _selectedPreviousYear;

        public List<int> RideYears
        {
            get
            {
                return DatabaseCoordinator.RideYears;
            }
        }

        public List<int> RidePreviousYears
        {
            get
            {
                return DatabaseCoordinator.RidePreviousYears;
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

        public int SelectedCurrentYear
        {
            get
            {
                return _selectedCurrentYear;
            }
            set
            {
                _selectedCurrentYear = value;
            }
        }

        public int SelectedPreviousYear
        {
            get
            {
                return _selectedPreviousYear;
            }
            set
            {
                _selectedPreviousYear = value;
            }
        }

        public List<FilteredRide> GetFilteredRides ()
        {
            return DatabaseCoordinator.GetFilteredRides(SelectedMonth, SelectedCurrentYear);
        }

        public List<FilteredRide> GetPreviousFilteredRides()
        {
            return DatabaseCoordinator.GetFilteredRides(SelectedMonth, SelectedPreviousYear);
        }
    }
}
