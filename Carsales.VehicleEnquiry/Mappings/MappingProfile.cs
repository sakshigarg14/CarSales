using AutoMapper;
using Carsales.VehicleEnquiry.DTOs;
using Carsales.VehicleEnquiry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsales.VehicleEnquiry.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Enquiry, EnquiryDto>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
            CreateMap<VehicleType, VehicleTypeDto>().ReverseMap();
        }
    }
}
