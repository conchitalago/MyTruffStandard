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
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public List<Client> GetAllClients()
        {
            return _clientService.GetAllClients();
        }
        [HttpGet("{id}")]
        public List<Client> GetClientById(int id)
        {
            return _clientService.GetClientById(id);
        }
        [HttpPost]
        public bool InsertNewClient(Client newClient)
        {
            try
            {
                return _clientService.AddNewClient(newClient);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
