using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleTracker.Database.Database;
using System.Globalization;
using System.Data.Entity;

namespace CycleTracker.Database
{
    public class DatabaseCoordinator
    {
        private CycleTracker.Database.Database.CycleDBEntities _entities = null;
        private CycleTracker.Database.Database.CycleDBEntities Entities
        {
            get
            {
                if (_entities == null)
                {
#if DEBUG
                    _entities = new CycleDBEntities();
                    string connection = _entities.Database.Connection.ConnectionString.Replace ("CycleDB", "CycleDB_new");
                    _entities.Database.Connection.ConnectionString = connection;
#else
                    _entities = new CycleDBEntities();
#endif

                }
                return _entities;
            }
        }

        private List<string> _bikes = null;
        private List<string> Bikes
        {
            get
            {
                if (_bikes == null)
                {
                    _bikes = Entities.Bikes.Select(b => b.BikeName).ToList();
                }
                return _bikes;
            }
        }

        private List<int> _rideYears = null;
        public List<int> RideYears
        {
            get
            {
                if (_rideYears == null)
                {
                    _rideYears = Entities.Rides.Select(r => r.RideDate.Value.Year).Distinct().OrderBy (y => y).ToList();
                }
                return _rideYears;
            }
        }

        private List<int> _ridePreviousYears = null;
        public List<int> RidePreviousYears
        {
            get
            {
                if (_ridePreviousYears == null)
                {
                    _ridePreviousYears = Entities.Rides.Select(r => r.RideDate.Value.Year).Distinct().OrderBy(y => y).ToList();
                }
                return _ridePreviousYears;
            }
        }

        private List<string> _rideMonths = null;
        public List<string> RideMonths
        {
            get
            {
                if (_rideMonths == null)
                {
                    _rideMonths = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
                }
                return _rideMonths;
            }
        }

        private List<Bike> _bikeList = null;
        public List<Bike> BikeList
        {
            get
            {
                if (_bikeList == null)
                {
                    _bikeList = Entities.Bikes.OrderBy(b => b.BikeName).ToList();
                }
                return _bikeList;
            }
        }

        public void ClearDatabase()
        {
            foreach (Bike currentBike in Entities.Bikes)
            {
                Entities.Bikes.Remove(currentBike);
            }
            Entities.SaveChanges();
        }

        public void WriteActivities (List<ActivityRecord> activities)
        {
            int rideId = 1;
            foreach (ActivityRecord currentActivity in activities)
            {
                Ride newRide = new Ride
                {
                    RideID = rideId,
                    BikeID = currentActivity.BikeId,
                    RideDate = currentActivity.ActivityDate,
                    DistanceInMiles = currentActivity.DistanceInMiles,
                    TimeInMinutes = currentActivity.TimeInMinutes,
                    Ascent = currentActivity.Ascent
                };
                Entities.Rides.Add(newRide);
                rideId++;
            }
            Entities.SaveChanges();
        }

        public List<FilteredRide> GetFilteredRidesForYears (int year, int previousYear, int selectedBike)
        {
            List<FilteredRide> rides = (from r in Entities.Rides
                                        let rideDate = r.RideDate.Value
                                        where (rideDate.Year == year || rideDate.Year == previousYear) &&
                                        (selectedBike != 10000) ? r.BikeID == selectedBike : true
                                        select new FilteredRide
                                        {
                                            RideID = r.RideID,
                                            RideDate = r.RideDate,
                                            DistanceInMiles = r.DistanceInMiles,
                                            RideTime = r.TimeInHours,
                                            RideTimeInMinutes = r.TimeInMinutes,
                                            AverageSpeed = r.AverageSpeed,
                                            Ascent = r.Ascent,
                                            Bike = r.Bike.BikeName,
                                            BikeId = r.Bike.BikeID
                                        }
                                    ).ToList();

            return rides;
        }

        public int CreateNewEntry (DateTime rideDate, decimal? rideDistance, decimal? rideTime, int rideAscent, int bikeId)
        {
            Ride newRide = new Ride
            {
                RideDate = rideDate,
                DistanceInMiles = rideDistance,
                TimeInMinutes = rideTime,
                Ascent = rideAscent,
                Bike = BikeList.Where(b => b.BikeID == bikeId).FirstOrDefault(),
                BikeID = bikeId
            };

            Entities.Rides.Add(newRide);
            Entities.SaveChanges();

            return newRide.RideID;
        }

        public void EditExistingDetails(int rideId, DateTime rideDate, decimal? rideDistance, decimal? rideTime, int rideAscent, int bikeId)
        {
            Ride existingRide = Entities.Rides.Where(r => r.RideID == rideId).SingleOrDefault();

            if (existingRide == null) { return; }

            existingRide.RideDate = rideDate;
            existingRide.DistanceInMiles = rideDistance;
            existingRide.TimeInMinutes = rideTime;
            existingRide.Ascent = rideAscent;
            existingRide.BikeID = bikeId;

            Entities.SaveChanges();
        }
    }

    public class FilteredRide : IComparable
    {
        public int RideID { get; set; }

        public DateTime? RideDate { get; set; }
        public decimal? RideTime { get; set; }
        public decimal? RideTimeInMinutes { get; set; }
        public decimal? DistanceInMiles { get; set; }
        public decimal? AverageSpeed { get; set; }
        public int? Ascent { get; set; }
        public string Bike { get; set; }

        public int BikeId { get; set; }
        public string Comments { get; set; }

        public int CompareTo(object obj)
        {
            DateTime compareDate = Convert.ToDateTime(((FilteredRide)obj).RideDate);

            if (this.RideDate < compareDate)
            {
                return -1;
            }
            else if (this.RideDate > compareDate)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

}
