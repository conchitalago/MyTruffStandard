using MyTruffStandard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyTruffStandard.Infra.Mappers
{
    public class VendorMapper
    {
        public static Vendor Convert(SqlDataReader reader)
        {
            Vendor vendors = new Vendor
            {
                Id = reader.GetInt32(0),
                FullName = reader.GetString(1),
                Cif = reader.GetString(2)
            };
            return vendors;
        }
    }
}
