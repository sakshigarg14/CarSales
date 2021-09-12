using Carsales.VehicleEnquiry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsales.VehicleEnquiry.MemoryDb
{
    internal static class Context
    {
        internal static List<Enquiry> Enquiries;
        internal static List<Vehicle> Vehicles;
        internal static List<VehicleType> VehicleTypes;

        public static void Initiate()
        {
            Enquiries = new List<Enquiry>();
            Vehicles = new List<Vehicle>();
            VehicleTypes = new List<VehicleType>();

            VehicleTypes.Add(new VehicleType()
            {
                VehicleTypeId = 1,
                VehicleTypeGuid = new Guid("6e450c84-fd35-4c66-8fe3-b4f5590942d5"),
                Description = "Car",
                VehicleTypeName = "Car"
            });
        }
    }
}
