using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataAccessLayer
{
    public class CustomerDataAccessLayer
    {
        public int InsertCustomerDAL(Customer customerObj)
        {
            string conn= ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            return 0;
        
        }

    }
}
