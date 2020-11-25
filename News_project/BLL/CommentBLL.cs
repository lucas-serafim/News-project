using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_project.BLL
{
    class CommentBLL
    {
        private int idComment;
        private int idNews;
        private int idUser;
        private string body;

        public int IdComment { get => idComment; set => idComment = value; }
        public int IdNews { get => idNews; set => idNews = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string Body { get => body; set => body = value; }
    }
}
