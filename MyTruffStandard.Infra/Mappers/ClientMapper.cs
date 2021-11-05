using MyTruffStandard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyTruffStandard.Infra.Mappers
{
    public class ClientMapper
    {
        public static Client Convert(SqlDataReader reader)
        {
            Client clients = new Client
            {
                Id = reader.GetInt32(0),
                Company = reader.GetString(1),
                Cif = reader.GetString(2)
            };
            return clients;
        }
    }
}
