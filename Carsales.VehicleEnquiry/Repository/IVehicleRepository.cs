using Carsales.VehicleEnquiry.Entity;
using System.Collections.Generic;

namespace Carsales.VehicleEnquiry.Repository
{
    public interface IVehicleRepository
    {
        IList<Vehicle> GetAllVehicles();
        bool UpdateVehicle(int id, Vehicle objVehicle);
        Vehicle GetVehicle(int id);
        bool SaveVehicle(Vehicle objVehicle);
        bool DeleteVehicle(int id);
    }
}