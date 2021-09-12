using Carsales.VehicleEnquiry.DTOs;
using Carsales.VehicleEnquiry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsales.VehicleEnquiry.Repository
{
    interface IVehicleTypeRepository
    {
        IList<VehicleType> GetAllEnquiry();
    }
}
