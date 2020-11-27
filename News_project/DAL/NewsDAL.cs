using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace News_project.DAL
{
    class NewsDAL
    {
        Connection connection = new Connection();

        public void Register(BLL.NewsBLL newsBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO NEWS
                                (ID_CATEGORY, TITLE, SUBTITLE, BODY, AUTHOR, DATE)
                                VALUES
                                (@ID_CATEGORY, @TITLE, @SUBTITLE, @BODY, @AUTHOR, @DATE)";

            cmd.Parameters.AddWithValue("@ID_CATEGORY", newsBLL.IdCategory);
            cmd.Parameters.AddWithValue("@TITLE", newsBLL.Title);
            cmd.Parameters.AddWithValue("@SUBTITLE", newsBLL.SubTitle);
            cmd.Parameters.AddWithValue("@BODY", newsBLL.Body);
            cmd.Parameters.AddWithValue("@AUTHOR", newsBLL.Author);
            cmd.Parameters.AddWithValue("@DATE", newsBLL.Date);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Update(BLL.NewsBLL newsBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE NEWS SET
                                ID_CATEGORY = @ID_CATEGORY,
                                TITLE = @TITLE,
                                SUBTITLE = @SUBTITLE,
                                BODY = @BODY,
                                AUTHOR = @AUTHOR,
                                DATE = @DATE
                                WHERE ID_NEWS = @ID_NEWS";

            cmd.Parameters.AddWithValue("@ID_CATEGORY", newsBLL.IdCategory);
            cmd.Parameters.AddWithValue("@TITLE", newsBLL.Title);
            cmd.Parameters.AddWithValue("@SUBTITLE", newsBLL.SubTitle);
            cmd.Parameters.AddWithValue("@BODY", newsBLL.Body);
            cmd.Parameters.AddWithValue("@AUTHOR", newsBLL.Author);
            cmd.Parameters.AddWithValue("@DATE", newsBLL.Date);
            cmd.Parameters.AddWithValue("@ID_NEWS", newsBLL.IdNews);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Delete(BLL.NewsBLL newsBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM NEWS WHERE ID_NEWS = @ID_NEWS";
            cmd.Parameters.AddWithValue(@"ID", newsBLL.IdNews);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public DataTable FindAll()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT id_news, title, subtitle, body, author, date, name_category FROM NEWS JOIN CATEGORY ON CATEGORY.id_category = NEWS.id_category", connection.Connect());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public BLL.NewsBLL FindNews(BLL.NewsBLL newsBLL)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT id_news, news.id_category, title, subtitle, body, author, date, name_category FROM NEWS JOIN CATEGORY ON CATEGORY.id_category = NEWS.id_category where ID_NEWS = @ID_NEWS";
            cmd.Parameters.AddWithValue("@ID_NEWS", newsBLL.IdNews);
            cmd.Connection = connection.Connect();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {

                newsBLL.IdNews = Convert.ToInt32(dataReader["ID_NEWS"]);
                newsBLL.IdCategory = Convert.ToInt32(dataReader["ID_CATEGORY"]);
                newsBLL.Title = dataReader["TITLE"].ToString();
                newsBLL.SubTitle = dataReader["SUBTITLE"].ToString();
                newsBLL.Body = dataReader["BODY"].ToString();
                newsBLL.Author = dataReader["AUTHOR"].ToString();
                newsBLL.Category = dataReader["NAME_CATEGORY"].ToString();
                newsBLL.Date = (DateTime)dataReader["DATE"];
            }

            dataReader.Close();
            connection.Disconnect();
            return newsBLL;
        }
    }
}
