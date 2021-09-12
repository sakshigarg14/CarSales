using AutoMapper;
using Carsales.VehicleEnquiry.DTOs;
using Carsales.VehicleEnquiry.Entity;
using Carsales.VehicleEnquiry.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Carsales.VehicleEnquiry.Controllers
{
    [ApiController]
    [Route("vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;
        public VehicleController(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository ??
               throw new ArgumentNullException(nameof(vehicleRepository));
            _mapper = mapper;
        }

        [HttpGet]
        public IList<VehicleDto> GetAllVehicles()
        {
            return _mapper.Map<List<VehicleDto>>(_vehicleRepository.GetAllVehicles());
        }

        [HttpGet]
        [Route("{vehicleId}")]
        public VehicleDto Get(int vehicleId)
        {
            return _mapper.Map<VehicleDto>(_vehicleRepository.GetVehicle(vehicleId));
        }

        [HttpPost]
        public bool Post(VehicleDto objVehicle)
        {
            Vehicle objVehicleEntity = _mapper.Map<Vehicle>(objVehicle);
            var status = _vehicleRepository.SaveVehicle(objVehicleEntity);
            return status;
        }

        [HttpPut]
        [Route("{id}")]
        public bool Put(int id, VehicleDto objVehicle)
        {
            Vehicle objVehicleEntity = _mapper.Map<Vehicle>(objVehicle);
            var status = _vehicleRepository.UpdateVehicle(id, objVehicleEntity);
            return status;
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            var status = _vehicleRepository.DeleteVehicle(id);
            return status;
        }
    }
}
