using System;
using System.Collections.Generic;
using System.Text;

namespace MyTruffStandard.Infra.SqlComponents
{
    public class ConectionString
    {
        public static string MyTruffConection = @"Data Source=(localdb)\MyTruff;Initial Catalog=MyTruffDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
