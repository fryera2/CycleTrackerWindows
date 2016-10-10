//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CycleTracker.Database.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ride
    {
        public int RideID { get; set; }
        public Nullable<int> BikeID { get; set; }
        public Nullable<System.DateTime> RideDate { get; set; }
        public Nullable<decimal> TimeInMinutes { get; set; }
        public Nullable<decimal> TimeInHours { get; set; }
        public Nullable<decimal> DistanceInMiles { get; set; }
        public Nullable<decimal> DistanceInKm { get; set; }
        public string Calories { get; set; }
        public Nullable<decimal> AverageSpeed { get; set; }
    
        public virtual Bike Bike { get; set; }
    }
}