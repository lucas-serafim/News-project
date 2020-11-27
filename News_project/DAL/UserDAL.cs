using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace News_project.DAL
{
    class UserDAL
    {
        Connection connection = new Connection();

        public void Register(BLL.UserBLL userBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO USER
                                (NAME, PASSWORD, EMAIL, USERPROFILE)
                                VALUES
                                (@NAME, @PASSWORD, @EMAIL, @USERPROFILE)";

            cmd.Parameters.AddWithValue("@NAME", userBLL.Name);
            cmd.Parameters.AddWithValue("@PASSWORD", userBLL.Password);
            cmd.Parameters.AddWithValue("@EMAIL", userBLL.Email);
            cmd.Parameters.AddWithValue("@USERPROFILE", userBLL.UserProfile);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Update(BLL.UserBLL userBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE USER SET
                                NAME = @NAME,
                                PASSWORD = @PASSWORD,
                                EMAIL = @EMAIL,
                                USERPROFILE = @USERPROFILE
                                WHERE ID = @ID";

            cmd.Parameters.AddWithValue("@NAME", userBLL.Name);
            cmd.Parameters.AddWithValue("@PASSWORD", userBLL.Password);
            cmd.Parameters.AddWithValue("@EMAIL", userBLL.Email);
            cmd.Parameters.AddWithValue("@USERPROFILE", userBLL.UserProfile);
            cmd.Parameters.AddWithValue("@ID", userBLL.IdUser);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Delete(BLL.UserBLL userBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM USER WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", userBLL.IdUser);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public DataTable FindAll()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(@"SELECT * FROM USER", connection.Connect());

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public BLL.UserBLL FindUser(BLL.UserBLL userBLL)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM USER WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", userBLL.IdUser);
            cmd.Connection = connection.Connect();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                userBLL.IdUser = Convert.ToInt32(dataReader["ID"]);
                userBLL.Name = dataReader["NAME"].ToString();
                userBLL.Email = dataReader["EMAIL"].ToString();
                userBLL.Password = dataReader["PASSWORD"].ToString();
                userBLL.UserProfile = dataReader["USERPROFILE"].ToString();
            }

            dataReader.Close();
            connection.Disconnect();
            return userBLL;
        }

        public BLL.UserBLL Login(BLL.UserBLL userBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM USER WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD";
            cmd.Parameters.AddWithValue("@EMAIL", userBLL.Email);
            cmd.Parameters.AddWithValue("@PASSWORD", userBLL.Password);

            cmd.Connection = connection.Connect();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                userBLL.IdUser = Convert.ToInt32(dataReader["ID"]);
                userBLL.Name = dataReader["NAME"].ToString();
                userBLL.Email = dataReader["EMAIL"].ToString();
                userBLL.Password = dataReader["PASSWORD"].ToString();
                userBLL.UserProfile = dataReader["USERPROFILE"].ToString();
            }
            else
            {
                userBLL.IdUser = 0;
            }

            dataReader.Close();
            connection.Disconnect();
            return userBLL;
        }
    }
}
