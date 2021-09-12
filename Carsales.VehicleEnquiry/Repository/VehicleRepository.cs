using Carsales.VehicleEnquiry.DTOs;
using Carsales.VehicleEnquiry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsales.VehicleEnquiry.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        public IList<Vehicle> GetAllVehicles()
        {
             return MemoryDb.Context.Vehicles;
        }

        public bool UpdateVehicle(int id, Vehicle objVehicle)
        {
            int vehicleIndex = MemoryDb.Context.Vehicles.FindIndex(en => en.VehicleId == id);
            if (vehicleIndex > -1)
            {
                MemoryDb.Context.Vehicles[vehicleIndex] = objVehicle;
                return true;
            }
            return false;
        }

        public Vehicle GetVehicle(int id)
        {
            return MemoryDb.Context.Vehicles.Find(en => en.VehicleId == id);
        }

        public bool SaveVehicle(Vehicle objVehicle)
        {
            if (MemoryDb.Context.Vehicles.Count > 0)
                objVehicle.VehicleId = MemoryDb.Context.Vehicles[MemoryDb.Context.Vehicles.Count - 1].VehicleId + 1;
            else
                objVehicle.VehicleId = 1;

            objVehicle.VehicleGuid = Guid.NewGuid();
            MemoryDb.Context.Vehicles.Add(objVehicle);
            return true;
        }

        public bool DeleteVehicle(int id)
        {
            int vehicleIndex = MemoryDb.Context.Vehicles.FindIndex(en => en.VehicleId == id);
            if (vehicleIndex > -1)
            {
                MemoryDb.Context.Vehicles.RemoveAt(vehicleIndex);
                return true;
            }
            return false;
        }
    }
}