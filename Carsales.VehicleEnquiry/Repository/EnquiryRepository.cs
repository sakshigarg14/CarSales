using Carsales.VehicleEnquiry.Entity;
using System;
using System.Collections.Generic;

namespace Carsales.VehicleEnquiry.Repository
{
    public class EnquiryRepository : IEnquiryRepository
    {
        public IList<Enquiry> GetAllEnquiry()
        {
            return MemoryDb.Context.Enquiries;
        }

        public bool UpdateEnquiry(int id, Enquiry objEnquiry)
        {
            int enquiryIndex = MemoryDb.Context.Enquiries.FindIndex(en => en.EnquiryId == id);
            if (enquiryIndex > -1)
            {
                MemoryDb.Context.Enquiries[enquiryIndex] = objEnquiry;
                return true;
            }
            return false;
        }

        public Enquiry GetEnquiry(int id)
        {
            return MemoryDb.Context.Enquiries.Find(en => en.EnquiryId == id);
        }

        public bool SaveEnquiry(Enquiry objEnquiry)
        {
            if (MemoryDb.Context.Enquiries.Count > 0)
                objEnquiry.EnquiryId = MemoryDb.Context.Enquiries[MemoryDb.Context.Enquiries.Count - 1].EnquiryId + 1;
            else
                objEnquiry.EnquiryId = 1;

            objEnquiry.EnquiryGuid = Guid.NewGuid();
            MemoryDb.Context.Enquiries.Add(objEnquiry);
            return true;
        }

        public bool DeleteEnquiry(int id)
        {
            int enquiryIndex = MemoryDb.Context.Enquiries.FindIndex(en => en.EnquiryId == id);
            if (enquiryIndex > -1)
            {
                MemoryDb.Context.Enquiries.RemoveAt(enquiryIndex);
                return true;
            }
            return false;
        }
    }
}