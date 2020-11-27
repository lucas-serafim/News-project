using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News_project.UI
{
    public partial class NewsAndComment : Form
    {
        BLL.NewsBLL newsBLL = new BLL.NewsBLL();
        DAL.NewsDAL newsDAL = new DAL.NewsDAL();

        public NewsAndComment(int id)
        {
            InitializeComponent();

            newsBLL.IdNews = id;
            newsBLL = newsDAL.FindNews(newsBLL);

            lblTitle.Text = newsBLL.Title;
            lblSubTitle.Text = newsBLL.SubTitle;
            lblAuthor.Text = newsBLL.Author;
            lblDate.Text = newsBLL.Date.ToString();
            lblCategory.Text = newsBLL.Category;
            txtBody.Text = newsBLL.Body;
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            FrmComment frmComment = new FrmComment(newsBLL.IdNews);
            frmComment.ShowDialog();
        }

        private void NewsAndComment_Load(object sender, EventArgs e)
        {

        }
    }
}
