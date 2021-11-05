using MyTruffStandard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.ServiceLibrary.Interfaces
{
    public interface IVendorService
    {
        List<Vendor> GetAllVendors();
        List<Vendor> GetVendorById(int id);
        bool InsertNewVendor(Vendor vendorNew);
    }

}
