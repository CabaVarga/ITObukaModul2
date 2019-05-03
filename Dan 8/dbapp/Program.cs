using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // connect to dbms
            string conn = @"Data Source=VARGA-DATOR\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string conn_step = @"
Data Source=VARGA-DATOR\SQLEXPRESS;
Integrated Security=True;
Connect Timeout=30;
Encrypt=False;
TrustServerCertificate=False;
ApplicationIntent=ReadWrite;
MultiSubnetFailover=False";
        }
    }
}
