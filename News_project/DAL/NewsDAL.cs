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
                                (IDCATEGORY, TITLE, SUBTITLE, BODY, DATE)
                                VALUES
                                (@IDCATEGORY, @TITLE, @SUBTITLE, @BODY, @DATE)";

            cmd.Parameters.AddWithValue("@IDCATEGORY", newsBLL.IdCategory);
            cmd.Parameters.AddWithValue("@TITLE", newsBLL.Title);
            cmd.Parameters.AddWithValue("@SUBTITLE", newsBLL.SubTitle);
            cmd.Parameters.AddWithValue("@DATE", newsBLL.Date);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Update(BLL.NewsBLL newsBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE USER SET
                                IDCATEGORY = @IDCATEGORY,
                                TITLE = @TITLE,
                                SUBTITLE = @SUBTITLE,
                                BODY = @BODY,
                                DATE = @DATE
                                WHERE IDNEWS = @IDNEWS";

            cmd.Parameters.AddWithValue("@IDCATEGORY", newsBLL.IdCategory);
            cmd.Parameters.AddWithValue("@TITLE", newsBLL.Title);
            cmd.Parameters.AddWithValue("@SUBTITLE", newsBLL.SubTitle);
            cmd.Parameters.AddWithValue("@DATE", newsBLL.Date);
            cmd.Parameters.AddWithValue("@IDNEWS", newsBLL.IdNews);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Delete(BLL.NewsBLL newsBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM NEWS WHERE IDNEWS = @IDNEWS";

            cmd.Parameters.AddWithValue(@"IDNEWS", newsBLL.IdNews);
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public DataTable FindAll(BLL.NewsBLL newsBLL)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM NEWS", connection.Connect());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }
    }
}
