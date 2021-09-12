using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsales.VehicleEnquiry.Entity
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public Guid VehicleGuid { get; set; }
        public string VehicleModelNumber { get; set; }
        public string VehicleName { get; set; }
        public string Year { get; set; }
        public float Price { get; set; }
        public VehicleType VehicleTypeId { get; set; }
    }
}