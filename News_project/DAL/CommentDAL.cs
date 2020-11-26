using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace News_project.DAL
{
    class CommentDAL
    {
        Connection connection = new Connection();

        public void Register(BLL.CommentBLL commentBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO COMMENT
                                (IDNEWS, IDUSER, BODY, DATE)
                                VALUES
                                (@IDNEWS, @IDUSER, @BODY, @DATE)";

            cmd.Parameters.AddWithValue("@IDNEWS", commentBLL.IdNews);
            cmd.Parameters.AddWithValue("@IDUSER", commentBLL.IdUser);
            cmd.Parameters.AddWithValue("@BODY", commentBLL.Body);
            cmd.Parameters.AddWithValue("@DATE", commentBLL.Date);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Update(BLL.CommentBLL commentBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"UPDATE COMMENT SET
                                IDNEWS = @IDNEWS,
                                IDUSER = @IDUSER,
                                BODY = BODY
                                WHERE ID = @ID";

            cmd.Parameters.AddWithValue("@IDNEWS", commentBLL.IdNews);
            cmd.Parameters.AddWithValue("@IDUSER", commentBLL.IdUser);
            cmd.Parameters.AddWithValue("@BODY", commentBLL.Body);
            cmd.Parameters.AddWithValue("@DATE", commentBLL.Date);
            cmd.Parameters.AddWithValue("@ID", commentBLL.IdComment);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public void Delete(BLL.CommentBLL commentBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM COMMENT WHERE ID = @ID";

            cmd.Parameters.AddWithValue("@ID", commentBLL.IdComment);

            cmd.Connection = connection.Connect();
            cmd.ExecuteNonQuery();

            connection.Disconnect();
        }

        public DataTable FindAll()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM COMMENT", connection.Connect());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }
    }
}
