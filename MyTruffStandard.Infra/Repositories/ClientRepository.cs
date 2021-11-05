using MyTruffStandard.Domain.Models;
using MyTruffStandard.Domain.Services;
using MyTruffStandard.Infra.Mappers;
using MyTruffStandard.Infra.SqlComponents;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyTruffStandard.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public List<Client> GetAllClients()
        {
            List<Client> _clients = new List<Client>();
            using (SqlConnection connection = new SqlConnection(ConectionString.MyTruffConection))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Queries.ClientsQueries.GetAllClients, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Client client = ClientMapper.Convert(reader);
                        _clients.Add(client);
                    }
                }
            }
            return _clients;
        }
        public List<Client> GetClientById(int id)
        {
            List<Client> _client = new List<Client>();
            using (SqlConnection connection = new SqlConnection(ConectionString.MyTruffConection))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Queries.ClientsQueries.GetClientById, connection))
                {

                    command.Parameters.AddWithValue("@Id", id);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Client client = ClientMapper.Convert(reader);
                        _client.Add(client);
                    }
                }
            }
            return _client;
        }
        public bool AddClient(Client client)
        {
            using (SqlConnection connection = new SqlConnection(ConectionString.MyTruffConection))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                using (SqlCommand command = new SqlCommand(sb.AppendFormat(Queries.ClientsQueries.InsertNewClient, client.Id, client.Company, client.Cif).ToString(), connection))
                {
                    command.Parameters.AddWithValue("@Id", client.Id);
                    command.Parameters.AddWithValue("@Company", client.Company);
                    command.Parameters.AddWithValue("@Cif", client.Cif);
                    var reader = command.ExecuteNonQuery();
                    if (reader > 0)
                        return true;
                    return false;
                }
            }
        }
    }
}
