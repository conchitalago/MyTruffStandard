using MyTruffStandard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.Domain.Services
{
    public interface IVendorRepository
    {
        bool AddVendor(Vendor vendor);
        List<Vendor> GetAllVendors();
        List<Vendor> GetClientById(int id);
    }

}
