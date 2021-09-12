using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carsales.VehicleEnquiry.DTOs
{
    public class EnquiryDto
    {
        public int EnquiryId { get; set; }
        public Guid EnquiryGuid { get; set; }
        public string Status { get; set; }
        public int VehicleId { get; set; }
        public string Comment { get; set; }

        public string ContactName { get; set; }
        public DateTime ContactDate { get; set; }
        public string ContactAddress { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        public VehicleDto Vehicle { get; set; }

    }
}