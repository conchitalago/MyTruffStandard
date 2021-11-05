using MyTruffStandard.Domain.Models;
using MyTruffStandard.Domain.Services;
using MyTruffStandard.ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.ServiceLibrary.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public List<Client> GetAllClients()
        {
            return _clientRepository.GetAllClients();
        }
        public List<Client> GetClientById(int id)
        {
            return _clientRepository.GetClientById(id);
        }
        public bool AddNewClient(Client clientNew)
        {
            try
            {
                return _clientRepository.AddClient(clientNew);
            }
            catch (Exception)
            {
                //Serilog
                return false;
            }

        }
    }
}
