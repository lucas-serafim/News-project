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
                                (IDNEWS, BODY, DATE)
                                VALUES
                                (@IDNEWS, @BODY, @DATE)";

            cmd.Parameters.AddWithValue("@IDNEWS", commentBLL.IdNews);
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
                                BODY = @BODY
                                WHERE ID = @ID";

            cmd.Parameters.AddWithValue("@IDNEWS", commentBLL.IdNews);
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

        public DataTable FindAll(BLL.CommentBLL commentBLL)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM COMMENT WHERE IDNEWS = @IDNEWS", connection.Connect());

            dataAdapter.SelectCommand.Parameters.AddWithValue("@IDNEWS", commentBLL.IdNews);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Disconnect();

            return dataTable;
        }

        public BLL.CommentBLL FindCategory(BLL.CommentBLL commentBLL)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM COMMENT WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", commentBLL.IdComment);
            cmd.Connection = connection.Connect();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                commentBLL.IdComment = Convert.ToInt32(dataReader["ID"]);
                commentBLL.Body = dataReader["BODY"].ToString();
            }

            dataReader.Close();
            connection.Disconnect();

            return commentBLL;
        }
    }
}
