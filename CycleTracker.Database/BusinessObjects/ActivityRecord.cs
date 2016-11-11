using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.Database
{
    public class ActivityRecord
    {
        public DateTime ActivityDate { get; set; }
        public decimal TimeInMinutes { get; set; }
        public decimal DistanceInMiles { get; set; }
        public int BikeId { get; set; }
        public int Ascent { get; set; }
    }
}
