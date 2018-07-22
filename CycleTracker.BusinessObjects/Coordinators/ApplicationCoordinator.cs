using CycleTracker.Database;
using CycleTracker.Database.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.BusinessObjects
{
    public class ApplicationCoordinator : BaseCoordinator
    {

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

        private List<FilteredMonth> _rideMonths = null;
        public List<FilteredMonth> RideMonths
        {
            get
            {
                if (_rideMonths == null)
                {
                    _rideMonths = new List<FilteredMonth>();
                    int monthId = 1;
                    foreach (string monthName in DateTimeFormatInfo.CurrentInfo.MonthNames)
                    {
                        _rideMonths.Add(new FilteredMonth
                        {
                            MonthId = monthId,
                            MonthName = monthName
                        });
                        monthId++;
                    }
                }
                return _rideMonths;
            }
        }

        private FilteredMonth _selectedMonth;
        public FilteredMonth SelectedMonth
        {
            get
            {
                if (_selectedMonth == null)
                {
                    _selectedMonth = new FilteredMonth(DateTime.Now);
                }
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

                if (value == _selectedCurrentYear) { return; }

                _selectedCurrentYear = value;
                _filteredRides = null;
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
                if (value == _selectedPreviousYear) { return; }

                _selectedPreviousYear = value;
                _filteredRides = null;
            }
        }

        public FilteredBike SelectedBike { get; set; }

        private List<FilteredBike> _bikes = null;
        public List<FilteredBike> Bikes
        {
            get
            {
                if (_bikes == null)
                {
                    _bikes =  DatabaseCoordinator.BikeList.Select(b => new FilteredBike
                    {
                        BikeID = b.BikeID,
                        BikeName = b.BikeName
                    }).OrderBy(b => b.BikeName).ToList();
                }
                return _bikes;
            }
        }

        private List<FilteredRide> _filteredRides = null;
        protected List<FilteredRide> FilteredRides 
        {
            get
            {
                if (_filteredRides == null)
                {
                    _filteredRides = DatabaseCoordinator.GetFilteredRidesForYears(SelectedCurrentYear, SelectedPreviousYear, SelectedBike.BikeID);

                }
                return _filteredRides;
            }
            set
            {
                _filteredRides = value;
            }
        }

        public void Initialise()
        {
           var dummy = DatabaseCoordinator.BikeList;
        }

        public void ResetRideData ()
        {
            _filteredRides = null;
        }

        public List<FilteredRide> GetFilteredRides ()
        {
            return FilteredRides.Where(r => (r.RideDate).Year == SelectedCurrentYear && 
                                (r.RideDate).Month == SelectedMonth.MonthId).OrderByDescending(f => f)
                                .ToList();
        }

        public List<FilteredRide> GetPreviousFilteredRides()
        {
            return FilteredRides.Where(r => (r.RideDate).Year == SelectedPreviousYear && ((DateTime)r.RideDate).Month == SelectedMonth.MonthId).ToList();
        }

        public List<FilteredRide> GetFilteredRidesForYear()
        {
            return FilteredRides.Where(r => (r.RideDate).Year == SelectedCurrentYear).ToList();
        }

        public List<FilteredRide> GetPreviousFilteredRidesForYear()
        {
            return FilteredRides.Where(r => (r.RideDate).Year == SelectedPreviousYear).ToList();
        }

        public List<FilteredRide> GetFilteredRidesToDate()
        {
            DateTime newDate = new DateTime(SelectedCurrentYear, DateTime.Now.Month, DateTime.Now.Day);
            return FilteredRides.Where(r => (r.RideDate.CompareTo(newDate) <= 0) &&
                                            (r.RideDate.Year == SelectedCurrentYear)).ToList();
        }

        public List<FilteredRide> GetPreviousRidesToDate()
        {
            DateTime newDate = new DateTime(SelectedPreviousYear, DateTime.Now.Month, DateTime.Now.Day);
            return FilteredRides.Where(r => (r.RideDate).CompareTo(newDate) <= 0 &&
                                            (r.RideDate).Year == SelectedPreviousYear).ToList();
        }

        public List<FilteredRide> GetFilteredRidesMonthToDate()
        {
            DateTime startDate = new DateTime(SelectedCurrentYear, DateTime.Now.Month, 1);
            DateTime endDate = new DateTime(SelectedCurrentYear, DateTime.Now.Month, DateTime.Now.Day);

            return FilteredRides.Where(r => (r.RideDate).CompareTo(startDate) >= 0 &&
                                            (r.RideDate).CompareTo(endDate) <= 0).ToList();
        }

        public List<FilteredRide> GetPreviousFilteredRidesMonthToDate()
        {
            DateTime startDate = new DateTime(SelectedPreviousYear, DateTime.Now.Month, 1);
            DateTime endDate = new DateTime(SelectedPreviousYear, DateTime.Now.Month, DateTime.Now.Day);

            return FilteredRides.Where(r => (r.RideDate).CompareTo(startDate) >= 0 &&
                                            (r.RideDate).CompareTo(endDate) <= 0).ToList();
        }
    }
}
