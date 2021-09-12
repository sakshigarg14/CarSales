using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsales.VehicleEnquiry.DTOs
{
    public class VehicleDto
    {
        public int VehicleId { get; set; }
        public Guid VehicleGuid { get; set; }
        public string VehicleModelNumber { get; set; }
        public string VehicleName { get; set; }
        public string Year { get; set; }
        public float Price { get; set; }
        public VehicleTypeDto VehicleTypeId { get; set; }
    }
}