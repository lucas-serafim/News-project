﻿using System;
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
            cmd.CommandText = @"INSERT INTO CATEGORY (NAME) VALUES (@NAME)";

            cmd.Parameters.AddWithValue("@NAME", categoryBLL.Name);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Update(BLL.CategoryBLL categoryBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE CATEGORY SET NAME = @NAME WHERE ID = @ID";

            cmd.Parameters.AddWithValue("@NAME", categoryBLL.Name);
            cmd.Parameters.AddWithValue("@ID", categoryBLL.IdCategory);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Delete(BLL.CategoryBLL categoryBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM CATEGORY WHERE ID = @ID";

            cmd.Parameters.AddWithValue("@ID", categoryBLL.IdCategory);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
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
            cmd.CommandText = "SELECT * FROM CATEGORY WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", categoryBLL.IdCategory);
            cmd.Connection = connection.Connect();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                categoryBLL.IdCategory = Convert.ToInt32(dataReader["ID"]);
                categoryBLL.Name = dataReader["NAME"].ToString();
            }

            dataReader.Close();
            connection.Disconnect();

            return categoryBLL;
        }
    }
}
