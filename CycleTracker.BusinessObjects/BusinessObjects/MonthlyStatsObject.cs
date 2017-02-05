using CycleTracker.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.BusinessObjects
{
    public class CombinedStatsObject
    {
        private List<FilteredRide> _rides;
        private List<FilteredRide> _previousRides;

        public CombinedStatsObject (List<FilteredRide> rides, List<FilteredRide> previousRides)
        {
            _rides = rides;
            _previousRides = previousRides;
        }

        #region Current Rides

        public int TotalRides
        {
            get
            {
                return _rides.Count;
            }
        }
        public decimal TotalTime
        {
            get
            {
                return Convert.ToDecimal (_rides.Sum(s => s.RideTime));
            }
        }
        public decimal TotalDistance
        {
            get
            {
                return  Convert.ToDecimal (_rides.Sum(s => s.DistanceInMiles));
            }
        }
        public decimal AverageSpeed
        {
            get
            {
                return (TotalDistance != 0 && TotalTime != 0) ? Math.Round (TotalDistance / TotalTime, 2) : 0;
            }
        }

        public decimal TotalAscentFt
        {
            get
            {
                return Convert.ToDecimal (_rides.Sum(r => r.Ascent));
            }
        }

        public decimal TotalAscentMetres
        {
            get
            {
                return (TotalAscentFt != 0) ? Convert.ToDecimal(Math.Round (TotalAscentFt / (decimal)3.3)) : 0;
            }
        }

        public decimal LongestRideMiles
        {
            get
            {
                return Convert.ToDecimal (_rides.Max(r => r.DistanceInMiles));
            }
        }

        public decimal LongestRideTime
        {
            get
            {
                return Convert.ToDecimal (_rides.Max(r => r.RideTime));
            }
        }

        #endregion


        public int TotalPreviousRides
        {
            get
            {
                return _previousRides.Count;
            }
        }
        public decimal TotalPreviousTime
        {
            get
            {
                return Convert.ToDecimal(_previousRides.Sum(s => s.RideTime));
            }
        }
        public decimal TotalPreviousDistance
        {
            get
            {
                return Convert.ToDecimal(_previousRides.Sum(s => s.DistanceInMiles));
            }
        }
        public decimal AveragePreviousSpeed
        {
            get
            {
                return (TotalPreviousDistance != 0 && TotalPreviousTime != 0) ? Math.Round(TotalPreviousDistance / TotalPreviousTime, 2) : 0;
            }
        }

        public decimal TotalPreviousAscentFt
        {
            get
            {
                return Convert.ToDecimal(_previousRides.Sum(r => r.Ascent));
            }
        }

        public decimal TotalPreviousAscentMetres
        {
            get
            {
                return (TotalPreviousAscentFt != 0) ? Convert.ToDecimal(Math.Round(TotalPreviousAscentFt / (decimal)3.3)) : 0;
            }
        }

        public decimal LongestPreviousRideInMiles
        {
            get
            {
                return Convert.ToDecimal(_previousRides.Max(r => r.DistanceInMiles));
            }
        }

        public decimal LongestPreviousRideTime
        {
            get
            {
                return Convert.ToDecimal(_previousRides.Max(r => r.RideTime));
            }
        }

        public int TotalRideDifference
        {
            get
            {
                return TotalRides - TotalPreviousRides;
            }
        }

        public decimal TotalTimeDifference
        {
            get
            {
                return TotalTime - TotalPreviousTime;
            }
        }

        public decimal TotalDistanceDifference
        {
            get
            {
                return TotalDistance - TotalPreviousDistance;
            }
        }

        public decimal TotalSpeedDifference
        {
            get
            {
                return AverageSpeed - AveragePreviousSpeed;
            }
        }

        public decimal TotalAscentDifferenceFt
        {
            get
            {
                return TotalAscentFt - TotalPreviousAscentFt;
            }
        }

        public decimal TotalAscentDifferenceMetres
        {
            get
            {
                return TotalAscentMetres - TotalPreviousAscentMetres;
            }
        }

        public decimal LongestRideDifference
        {
            get
            {
                return LongestRideMiles - LongestPreviousRideInMiles;
            }
        }
        
        public decimal LongestTimeDifference
        {
            get
            {
                return LongestRideTime - LongestPreviousRideTime;
            }
        }

    }
}
