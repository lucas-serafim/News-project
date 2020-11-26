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
        private string body;
        private DateTime date;

        public int IdComment { get => idComment; set => idComment = value; }
        public int IdNews { get => idNews; set => idNews = value; }
        public string Body { get => body; set => body = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
