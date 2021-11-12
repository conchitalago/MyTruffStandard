using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.Infra.SqlComponents
{
    public class Queries
    {
        public static class ClientsQueries
        {
            public const string GetAllClients = "SELECT * FROM Clients";
            public const string GetClientById = "SELECT * FROM Clients WHERE IdClient = @Id";
            public const string InsertNewClient = "INSERT INTO Clients (IdClient,Company,Cif) VALUES ({0},'{1}','{2}') ";
        }
        public static class VendorsQueries
        {
            public const string GetAllVendors = "SELECT * FROM Vendors";
            public const string GetVendorById = "SELECT * FROM Vendors WHERE Id=@Id";
            public const string InsertNewVendor = "INSERT INTO Vendors (Id,FulName,Cif) VALUES ({0},'{1}','{2}') ";
        }
    }
}
