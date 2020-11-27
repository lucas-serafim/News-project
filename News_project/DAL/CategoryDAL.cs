using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace News_project.DAL
{
    class CategoryDAL
    {
        Connection connection = new Connection();

        public void Register(BLL.CategoryBLL categoryBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO CATEGORY (NAME_CATEGORY) VALUES (@NAME_CATEGORY)";

            cmd.Parameters.AddWithValue("@NAME_CATEGORY", categoryBLL.Name);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Update(BLL.CategoryBLL categoryBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE CATEGORY SET NAME_CATEGORY = @NAME_CATEGORY WHERE ID_CATEGORY = @ID_CATEGORY";

            cmd.Parameters.AddWithValue("@NAME_CATEGORY", categoryBLL.Name);
            cmd.Parameters.AddWithValue("@ID_CATEGORY", categoryBLL.IdCategory);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public bool Delete(BLL.CategoryBLL categoryBLL)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = @"DELETE FROM CATEGORY WHERE ID_CATEGORY = @ID_CATEGORY";

                cmd.Parameters.AddWithValue("@ID_CATEGORY", categoryBLL.IdCategory);

                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();

                connection.Disconnect();

                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }

            //MySql.Data.MySqlClient.MySqlException
        }

        public DataTable FindAll()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM CATEGORY", connection.Connect());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public BLL.CategoryBLL FindCategory(BLL.CategoryBLL categoryBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM CATEGORY WHERE ID_CATEGORY = @ID_CATEGORY";
            cmd.Parameters.AddWithValue("@ID_CATEGORY", categoryBLL.IdCategory);
            cmd.Connection = connection.Connect();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                categoryBLL.IdCategory = Convert.ToInt32(dataReader["ID_CATEGORY"]);
                categoryBLL.Name = dataReader["NAME_CATEGORY"].ToString();
            }

            dataReader.Close();
            connection.Disconnect();

            return categoryBLL;
        }
    }
}
