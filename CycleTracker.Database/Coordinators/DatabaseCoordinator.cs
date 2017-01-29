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

        private IOrderedQueryable<Bike> _bikeList = null;
        public IOrderedQueryable<Bike> BikeList
        {
            get
            {
                if (_bikeList == null)
                {
                    _bikeList = Entities.Bikes.OrderBy(b => b.BikeName);
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

        public void CreateListOfBikes (Dictionary<string, int> bikes)
        {
            foreach (KeyValuePair<string, int> currentBike in bikes)
            {
                if (!Bikes.Contains (currentBike.Key))
                {
                    Bike newBike = new Bike
                    {
                        BikeID = currentBike.Value,
                        BikeName = currentBike.Key
                    };
                    Entities.Bikes.Add(newBike);
                }
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

        public List<FilteredRide> GetFilteredRidesForYears (int year, int previousYear)
        {
            List<FilteredRide> rides = (from r in Entities.Rides
                                        let rideDate = r.RideDate.Value
                                        where rideDate.Year == year || rideDate.Year == previousYear
                                        select new FilteredRide
                                        {
                                            RideDate = r.RideDate,
                                            DistanceInMiles = r.DistanceInMiles,
                                            RideTime = r.TimeInHours,
                                            AverageSpeed = r.AverageSpeed,
                                            Ascent = r.Ascent,
                                            Bike = r.Bike.BikeName
                                        }
                                    ).ToList();

            return rides;
        }

        public void CreateNewEntry (DateTime rideDate, decimal? rideDistance, decimal? rideTime, int rideAscent, int bikeId)
        {
            Ride newRide = new Ride
            {
                RideDate = rideDate,
                DistanceInMiles = rideDistance,
                TimeInMinutes = rideTime,
                Ascent = rideAscent,
                Bike = BikeList.Where (b => b.BikeID == bikeId).FirstOrDefault()
            };

            Entities.Rides.Add(newRide);
            Entities.SaveChanges();
        }
    }

    public class FilteredRide
    {
        public DateTime? RideDate { get; set; }
        public decimal? RideTime { get; set; }
        public decimal? DistanceInMiles { get; set; }
        public decimal? AverageSpeed { get; set; }
        public int? Ascent { get; set; }
        public string Bike { get; set; }
        public string Comments { get; set; }
    }

}
