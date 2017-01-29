using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.BusinessObjects
{
    public class NewRideCoordinator : BaseCoordinator
    {

        private DateTime _rideDate = DateTime.Now;

        public List<BikeObject> BikeList
        {
            get
            {
                return DatabaseCoordinator.BikeList
                    .Select(b => new BikeObject { BikeId = b.BikeID, BikeName = b.BikeName }).ToList();
            }
        }

        public DateTime RideDate
        {
            get
            {
                return _rideDate;
            }
            set
            {
                _rideDate = value;
            }
        }
        public decimal RideDistance { get; set; }

        public decimal RideTime { get; set; }

        public int RideAscent { get; set; }

        public int BikeUsed { get; set; }

        #region Overridden methods

        protected override void Validate()
        {
            base.Validate();
        }

        #endregion

        #region Methods

        public bool AddRideToDatabase()
        {
            Validate();

            DatabaseCoordinator.CreateNewEntry((DateTime)RideDate, RideDistance, RideTime, RideAscent, BikeUsed);
            ClearValues();

            return true;
        }

        private void ClearValues()
        {
            RideDistance = 0;
            RideTime = 0;
            RideAscent = 0;
        }

        #endregion
    }
}
