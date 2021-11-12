using Microsoft.AspNetCore.Mvc;
using MyTruffStandard.Domain.Models;
using MyTruffStandard.ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTruffStandard.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendorController : Controller
    {
        private readonly IVendorService _vendorService;

        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }
        [HttpGet]
        public List<Vendor> GetAllVendor()
        {
            return _vendorService.GetAllVendors();
        }
        [HttpGet("{id}")]
        public List<Vendor>GetVendorById(int id)
        {
            return _vendorService.GetVendorById(id);
        }
        [HttpPost]
        public bool InsertNewVendor(Vendor newVendor)
        {

                return _vendorService.InsertNewVendor(newVendor);

        }
    }
}
