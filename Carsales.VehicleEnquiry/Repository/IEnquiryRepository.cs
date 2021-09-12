using Carsales.VehicleEnquiry.Entity;
using System.Collections.Generic;

namespace Carsales.VehicleEnquiry.Repository
{
    public interface IEnquiryRepository
    {
        IList<Enquiry> GetAllEnquiry();
        bool UpdateEnquiry(int id, Enquiry objEnquiry);
        Enquiry GetEnquiry(int id);
        bool SaveEnquiry(Enquiry objEnquiry);
        bool DeleteEnquiry(int id);
    }
}