using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleTracker.Database.Database;
using System.Globalization;

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
                    _entities = new CycleDBEntities();
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

        public List<FilteredRide> GetFilteredRides (int month, int year)
        {
            List<FilteredRide> rides = (from r in Entities.Rides
                                        let rideDate = r.RideDate.Value
                                        where rideDate.Month == month && rideDate.Year == year
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
    }

    public class FilteredRide
    {
        public DateTime? RideDate { get; set; }
        public decimal? RideTime { get; set; }
        public decimal? DistanceInMiles { get; set; }
        public decimal? AverageSpeed { get; set; }
        public int? Ascent { get; set; }
        public string Bike { get; set; }
    }
}
