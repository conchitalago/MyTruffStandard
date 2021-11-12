using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTruffStandard.Domain.Models;
using MyTruffStandard.ServiceLibrary.Interfaces;
using Serilog;
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
        private readonly ILogger<ClientController> _logger;
        public ClientController(IClientService clientService, ILogger<ClientController> logger)
        {
            _clientService = clientService;
            _logger = logger;
        }
        [HttpGet]
        public List<Client> GetAllClients()
        {
            _logger.LogInformation("Someone have acceded a table Clients at " + DateTime.Now);
            return _clientService.GetAllClients();

        }
        [HttpGet("{id}")]
        public List<Client> GetClientById(int id)
        {
            try
            {
                _logger.LogInformation(@$"Someone have acceded at client {id} at " + DateTime.Now);
                return _clientService.GetClientById(id);
            }
            catch (Exception)
            {

                _logger.LogError(@$"Someone haven't acceded at clien {id} at {DateTime.Now}");
                return null;
            }

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

                Log.Error(@$"ERROR:{newClient} not added to database at {DateTime.Now}");
                return false;
            }
        }
    }
}
