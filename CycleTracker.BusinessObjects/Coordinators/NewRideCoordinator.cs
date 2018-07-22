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
        private List<FilteredBike> _bikeListMinusAll = null;

        public List<FilteredBike> BikeList
        {
            get
            {
                return DatabaseCoordinator.BikeList
                    .Select(b => new FilteredBike { BikeID = b.BikeID, BikeName = b.BikeName }).ToList();
            }
        }

        public List<FilteredBike> BikeListMinusAll
        {
            get
            {
                if (_bikeListMinusAll == null)
                {
                    return DatabaseCoordinator.BikeList.Where (b => b.BikeID != 0)
                        .Select(b => new FilteredBike { BikeID = b.BikeID, BikeName = b.BikeName }).ToList();
                }
                return _bikeListMinusAll;
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

        public int RideId { get; set; }

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

        public bool EditRideInDatabase ()
        {
            Validate();
            DatabaseCoordinator.EditExistingDetails(RideId, (DateTime)RideDate, RideDistance, RideTime, RideAscent, BikeUsed);
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
