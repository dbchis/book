using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
 public class DatabseConnection
    {
        protected string connString = "Data Source=.;Initial Catalog=LibraryManagementSystem ;Integrated Security=True";
        protected SqlConnection conn;
        public void OpenConnection()
        {
            if (conn==null)
            {
                conn = new SqlConnection(connString);
            }
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
