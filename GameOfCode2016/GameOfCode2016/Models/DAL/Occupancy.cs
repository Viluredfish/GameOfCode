//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameOfCode2016.Models.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Occupancy
    {
        public int OccupancyId { get; set; }
        public int ParkingId { get; set; }
        public System.DateTime Date { get; set; }
        public double Rate { get; set; }
        public int FreeSlots { get; set; }
    }
}