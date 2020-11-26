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
    public partial class FrmComment : Form
    {
        BLL.CommentBLL commentBLL = new BLL.CommentBLL();
        DAL.CommentDAL commentDAL = new DAL.CommentDAL();

        bool update = false;

        public FrmComment(int id)
        {
            InitializeComponent();
            commentBLL.IdNews = id;

            dvgComment.DataSource = commentDAL.FindAll(commentBLL);
        }

        private void btnNewComment_Click_1(object sender, EventArgs e)
        {
            commentBLL.Body = txtBody.Text;
            commentBLL.Date = DateTime.Today;

            if (txtBody.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (update)
                {
                    commentDAL.Update(commentBLL);
                    MessageBox.Show("Dados atualizados com sucesso!");
                    clear();

                    update = false;
                }
                else
                {
                    commentDAL.Register(commentBLL);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    clear();
                }
            }

            dvgComment.DataSource = commentDAL.FindAll(commentBLL);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dvgComment.RowCount > 0)
            {
                commentBLL.IdComment = Convert.ToInt32(dvgComment[0, dvgComment.CurrentRow.Index].Value);
                commentBLL = commentDAL.FindCategory(commentBLL);

                txtBody.Text = commentBLL.Body;

                update = true;

                tabComment.SelectedTab = tabNewComment;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgComment.RowCount > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    commentBLL.IdComment = Convert.ToInt16(dvgComment[0, dvgComment.CurrentRow.Index].Value);
                    commentDAL.Delete(commentBLL);

                    dvgComment.DataSource = commentDAL.FindAll(commentBLL);

                    MessageBox.Show("Exclusão realizada com sucesso");
                }
            }
        }

        private void clear()
        {
            txtBody.Clear();
        }
    }
}
