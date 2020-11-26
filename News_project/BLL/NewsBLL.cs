using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_project.BLL
{
    class NewsBLL
    {
        private int idNews;
        private int idCategory;
        private string title;
        private string subTitle;
        private string body;
        private string author;
        private DateTime date;
        private List<CommentBLL> commentBLLs;

        public int IdNews { get => idNews; set => idNews = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string Title { get => title; set => title = value; }
        public string SubTitle { get => subTitle; set => subTitle = value; }
        public string Body { get => body; set => body = value; }
        public string Author { get => author; set => author = value; }
        public DateTime Date { get => date; set => date = value; }
        internal List<CommentBLL> CommentBLLs { get => commentBLLs; set => commentBLLs = value; }
    }
}
