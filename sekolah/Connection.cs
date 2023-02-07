using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sekolah
{
    public class Connection
    {
        public SqlConnection con;

        public Connection()
        {
            string connString = @"Data Source=DESKTOP-5VS88JF;Initial Catalog=sekolah;Integrated Security=True";
            con = new SqlConnection(connString);
        }

        public SqlConnection getConnection() { return con; }

        public void openCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
