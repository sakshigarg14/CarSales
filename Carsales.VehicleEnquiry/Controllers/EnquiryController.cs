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
    [Route("enquiry")]
    public class EnquiryController : ControllerBase
    {
        private readonly IEnquiryRepository _enquiryRepository;
        private readonly IMapper _mapper;

        public EnquiryController(IEnquiryRepository enquiryRepository, IMapper mapper)
        {
            _enquiryRepository = enquiryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IList<EnquiryDto> GetAllEnquiry()
        {
            return _mapper.Map<List<EnquiryDto>>(_enquiryRepository.GetAllEnquiry());
        }

        [HttpGet]
        [Route("{enquiryId}")]
        public EnquiryDto Get(int enquiryId)
        {
            return _mapper.Map<EnquiryDto>(_enquiryRepository.GetEnquiry(enquiryId));
        }

        [HttpPost]
        public bool Post(EnquiryDto objEnquiry)
        {
            Enquiry objEnquiryEntity = _mapper.Map<Enquiry>(objEnquiry);
            var status = _enquiryRepository.SaveEnquiry(objEnquiryEntity);
            return status;
        }

        [HttpPut]
        [Route("{id}")]
        public bool Put(int id, EnquiryDto objEnquiry)
        {
            Enquiry objEnquiryEntity = _mapper.Map<Enquiry>(objEnquiry);
            var status = _enquiryRepository.UpdateEnquiry(id, objEnquiryEntity);
            return status;
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            var status = _enquiryRepository.DeleteEnquiry(id);
            return status;
        }
    }
}
