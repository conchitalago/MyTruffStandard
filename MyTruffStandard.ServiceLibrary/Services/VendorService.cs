using MyTruffStandard.Domain.Models;
using MyTruffStandard.Domain.Services;
using MyTruffStandard.ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.ServiceLibrary.Services
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;

        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }
        public List<Vendor> GetAllVendors()
        {
            return _vendorRepository.GetAllVendors();
        }
        public List<Vendor> GetVendorById(int id)
        {
            return _vendorRepository.GetClientById(id);
        }
        public bool InsertNewVendor(Vendor vendorNew)
        {

                return _vendorRepository.AddVendor(vendorNew);


        }
    }
}
