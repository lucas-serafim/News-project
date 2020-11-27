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
    public partial class FrmNews : Form
    {
        BLL.NewsBLL newsBLL = new BLL.NewsBLL();
        DAL.NewsDAL newsDAL = new DAL.NewsDAL();

        DAL.CategoryDAL categoryDAL = new DAL.CategoryDAL();

        bool update = false;

        public FrmNews()
        {
            InitializeComponent();
        }

        private void FrmNews_Load(object sender, EventArgs e)
        {  
            cboCategory.DataSource = categoryDAL.FindAll();

            cboCategory.DisplayMember = "name_category";
            cboCategory.ValueMember = "id_category";
            dvgNews.DataSource = newsDAL.FindAll();

            if (Form1.profile == Enums.UserProfile.Cliente.ToString())
            {
                btnRegister.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            newsBLL.Title = txtTitle.Text;
            newsBLL.SubTitle = txtSubTitle.Text;
            newsBLL.Body = txtBody.Text;
            newsBLL.Author = txtAuthor.Text;
            newsBLL.Date = DateTime.Today;
            newsBLL.IdCategory = Convert.ToInt32(cboCategory.SelectedValue);

            if (txtTitle.Text == string.Empty || txtSubTitle.Text == string.Empty || txtBody.Text == string.Empty || cboCategory.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (update)
                {
                    newsDAL.Update(newsBLL);
                    MessageBox.Show("Dados atualizados com sucesso!");
                    clear();

                    update = false;
                }
                else
                {
                    newsDAL.Register(newsBLL);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    clear();
                }
            }

            dvgNews.DataSource = newsDAL.FindAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dvgNews.RowCount > 0)
            {
                newsBLL.IdNews = Convert.ToInt32(dvgNews[0, dvgNews.CurrentRow.Index].Value);
                newsBLL = newsDAL.FindNews(newsBLL);

                txtTitle.Text = newsBLL.Title;
                txtSubTitle.Text = newsBLL.SubTitle;
                txtBody.Text = newsBLL.Body;
                txtAuthor.Text = newsBLL.Author;

                update = true;

                tabNews.SelectedTab = tabRegister;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgNews.RowCount > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    newsBLL.IdNews = Convert.ToInt16(dvgNews[0, dvgNews.CurrentRow.Index].Value);
                    newsDAL.Delete(newsBLL);

                    dvgNews.DataSource = newsDAL.FindAll();

                    MessageBox.Show("Exclusão realizada com sucesso");
                }
            }
        }

        private void btnOpenNews_Click(object sender, EventArgs e)
        {
            if (dvgNews.RowCount > 0)
            {
                int id = Convert.ToInt32(dvgNews[0, dvgNews.CurrentRow.Index].Value);

                NewsAndComment newsAndComment = new NewsAndComment(id);
                newsAndComment.ShowDialog();
            }
        }

        public void clear()
        {
            txtTitle.Clear();
            txtSubTitle.Clear();
            txtBody.Clear();
            txtAuthor.Clear();
        }
    }
}
