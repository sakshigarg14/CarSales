using Carsales.VehicleEnquiry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsales.VehicleEnquiry.Repository
{
    public class VehicleTypeRepository : IVehicleTypeRepository
    {
        public IList<VehicleType> GetAllEnquiry()
        {
            return MemoryDb.Context.VehicleTypes;
        }
    }
}
