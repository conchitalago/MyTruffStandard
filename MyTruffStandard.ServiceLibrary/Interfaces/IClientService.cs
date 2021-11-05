using MyTruffStandard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.ServiceLibrary.Interfaces
{
    public interface IClientService
    {
        bool AddNewClient(Client clientNew);
        List<Client> GetAllClients();
        List<Client> GetClientById(int id);
    }

}
