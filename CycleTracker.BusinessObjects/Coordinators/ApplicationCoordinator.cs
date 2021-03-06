﻿using CycleTracker.Database;
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
        private int _selectedBike;

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
                _selectedPreviousYear = value;
                _filteredRides = null;
            }
        }

        public int SelectedBike
        {
            get
            {
                return _selectedBike;
            }
            set
            {
                _selectedBike = value;
            }
        }

        private List<Bike> _bikes = null;
        public List<Bike> Bikes
        {
            get
            {
                if (_bikes == null)
                {
                    _bikes =  DatabaseCoordinator.BikeList;
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
                    _filteredRides = DatabaseCoordinator.GetFilteredRidesForYears(SelectedCurrentYear, SelectedPreviousYear, SelectedBike);

                }
                return _filteredRides;
            }
            set
            {
                _filteredRides = value;
            }
        }

        public void ResetRideData ()
        {
            _filteredRides = null;
        }

        public List<FilteredRide> GetFilteredRides ()
        {
            return FilteredRides.Where(r => ((DateTime)r.RideDate).Year == SelectedCurrentYear && 
                                ((DateTime)r.RideDate).Month == SelectedMonth).OrderByDescending(f => f)
                                .ToList();
        }

        public List<FilteredRide> GetPreviousFilteredRides()
        {
            return FilteredRides.Where(r => ((DateTime)r.RideDate).Year == SelectedPreviousYear && ((DateTime)r.RideDate).Month == SelectedMonth).ToList();
        }

        public List<FilteredRide> GetFilteredRidesForYear()
        {
            return FilteredRides.Where(r => ((DateTime)r.RideDate).Year == SelectedCurrentYear).ToList();
        }

        public List<FilteredRide> GetPreviousFilteredRidesForYear()
        {
            return FilteredRides.Where(r => ((DateTime)r.RideDate).Year == SelectedPreviousYear).ToList();
        }

        public List<FilteredRide> GetFilteredRidesToDate()
        {
            DateTime newDate = new DateTime(SelectedCurrentYear, DateTime.Now.Month, DateTime.Now.Day);
            return FilteredRides.Where(r => ((DateTime)r.RideDate).CompareTo(newDate) <= 0 &&
                                            ((DateTime)r.RideDate).Year == SelectedCurrentYear).ToList();
        }

        public List<FilteredRide> GetPreviousRidesToDate()
        {
            DateTime newDate = new DateTime(SelectedPreviousYear, DateTime.Now.Month, DateTime.Now.Day);
            return FilteredRides.Where(r => ((DateTime)r.RideDate).CompareTo(newDate) <= 0 &&
                                            ((DateTime)r.RideDate).Year == SelectedPreviousYear).ToList();
        }

        public List<FilteredRide> GetFilteredRidesMonthToDate()
        {
            DateTime startDate = new DateTime(SelectedCurrentYear, DateTime.Now.Month, 1);
            DateTime endDate = new DateTime(SelectedCurrentYear, DateTime.Now.Month, DateTime.Now.Day);

            return FilteredRides.Where(r => ((DateTime)r.RideDate).CompareTo(startDate) >= 0 &&
                                            ((DateTime)r.RideDate).CompareTo(endDate) <= 0).ToList();
        }

        public List<FilteredRide> GetPreviousFilteredRidesMonthToDate()
        {
            DateTime startDate = new DateTime(SelectedPreviousYear, DateTime.Now.Month, 1);
            DateTime endDate = new DateTime(SelectedPreviousYear, DateTime.Now.Month, DateTime.Now.Day);

            return FilteredRides.Where(r => ((DateTime)r.RideDate).CompareTo(startDate) >= 0 &&
                                            ((DateTime)r.RideDate).CompareTo(endDate) <= 0).ToList();
        }
    }
}
