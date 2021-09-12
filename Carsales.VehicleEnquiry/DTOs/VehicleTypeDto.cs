using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsales.VehicleEnquiry.DTOs
{
    public class VehicleTypeDto
    {
         public int VehicleTypeId { get; set; }
         public Guid VehicleTypeGuid { get; set; }
         public string VehicleTypeName { get; set; }
         public string Description { get; set; }
    }
}