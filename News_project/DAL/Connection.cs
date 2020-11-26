using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace News_project.DAL
{
    class Connection
    {
        MySqlConnection con = new MySqlConnection("server=localhost;User id=root;Password='';Database=News_project");
        
        public MySqlConnection Connect()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            return con;
        }

        public void Disconnect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
