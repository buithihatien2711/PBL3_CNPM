using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    class Connect
    {
        string constr; 
        public Connect()
        {
            constr = @"Data Source=LAPTOP-J27Q18HQ\HATIEN;Initial Catalog=PBL3;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(constr);
        }
    }
}