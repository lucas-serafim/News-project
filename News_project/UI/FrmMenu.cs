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
    public partial class FrmMenu : Form
    {
        DAL.UserDAL userDAL = new DAL.UserDAL();
        DAL.NewsDAL newsDAL = new DAL.NewsDAL();
        DAL.CategoryDAL categoryDAL = new DAL.CategoryDAL();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (Form1.profile != Enums.UserProfile.Administrador.ToString())
            {
                btnUser.Enabled = false;
            }

            status();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            Hide();
            frmUser.ShowDialog();

            Show();
            status();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            FrmNews frmNews = new FrmNews();
            Hide();
            frmNews.ShowDialog();

            Show();
            status();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            Hide();
            frmCategory.ShowDialog();

            Show();
            status();
        }

        private void status()
        {
            DataTable dataTable = userDAL.FindAll();
            lblCountUser.Text = dataTable.Rows.Count.ToString();

            dataTable = newsDAL.FindAll();
            lblCountNews.Text = dataTable.Rows.Count.ToString();

            dataTable = categoryDAL.FindAll();
            lblCountCategory.Text = dataTable.Rows.Count.ToString();
        }
    }
}
