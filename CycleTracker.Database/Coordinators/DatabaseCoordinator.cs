using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleTracker.Database.Database;

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
    }
}
