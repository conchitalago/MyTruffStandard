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
    public class VendorRepository : IVendorRepository
    {
        public List<Vendor> GetAllVendors()
        {
            List<Vendor> _vendors = new List<Vendor>();
            using (SqlConnection connection = new SqlConnection(ConectionString.MyTruffConection))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Queries.VendorsQueries.GetAllVendors, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Vendor vendor = VendorMapper.Convert(reader);
                        _vendors.Add(vendor);
                    }
                }
            }
            return _vendors;
        }
        public List<Vendor> GetClientById(int id)
        {
            List<Vendor> _vendor = new List<Vendor>();
            using (SqlConnection connection = new SqlConnection(ConectionString.MyTruffConection))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Queries.VendorsQueries.GetVendorById, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Vendor vendor = VendorMapper.Convert(reader);
                        _vendor.Add(vendor);
                    }
                }
            }
            return _vendor;
        }
        public bool AddVendor(Vendor vendor)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConectionString.MyTruffConection))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                using (SqlCommand command = new SqlCommand(sb.AppendFormat(Queries.VendorsQueries.InsertNewVendor, vendor.Id, vendor.FullName, vendor.Cif).ToString(), connection))
                {
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
