using MyTruffStandard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.Domain.Services
{
    public interface IClientRepository
    {
        bool AddClient(Client client);
        List<Client> GetAllClients();
        List<Client> GetClientById(int id);
    }

}
