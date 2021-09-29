//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImportAVLData
{
    using System;
    using System.Collections.Generic;
    
    public partial class SnowplowSanderA
    {
        public int ID { get; set; }
        public Nullable<int> SysId { get; set; }
        public string SysWithDate { get; set; }
        public Nullable<System.DateTime> CollectedTime { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lon { get; set; }
        public Nullable<double> X_Coord { get; set; }
        public Nullable<double> Y_Coord { get; set; }
        public Nullable<double> Speed { get; set; }
        public Nullable<int> State { get; set; }
        public string VehicleType { get; set; }
        public string StateDesc { get; set; }
        public System.Data.Entity.Spatial.DbGeometry Shape { get; set; }
        public System.Data.Entity.Spatial.DbGeography ShapeGeography { get; set; }
        public Nullable<int> SeqOrder { get; set; }
        public System.Data.Entity.Spatial.DbGeometry ShapeLine { get; set; }
        public string StreetView { get; set; }
        public Nullable<int> SecDiff { get; set; }
    }
}
