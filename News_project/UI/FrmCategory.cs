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
    public partial class FrmCategory : Form
    {
        BLL.CategoryBLL categoryBLL = new BLL.CategoryBLL();
        DAL.CategoryDAL categoryDAL = new DAL.CategoryDAL();

        bool update = false;

        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            dvgCategory.DataSource = categoryDAL.FindAll();

            if (Form1.profile == Enums.UserProfile.Cliente.ToString())
            {
                btnRegister.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            categoryBLL.Name = txtName.Text;

            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (update)
                {
                    categoryDAL.Update(categoryBLL);
                    MessageBox.Show("Dados atualizados com sucesso!");
                    clear();

                    update = false;
                }
                else
                {
                    categoryDAL.Register(categoryBLL);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    clear();
                }
            }

            dvgCategory.DataSource = categoryDAL.FindAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgCategory.RowCount > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoryBLL.IdCategory = Convert.ToInt16(dvgCategory[0, dvgCategory.CurrentRow.Index].Value);
                    categoryDAL.Delete(categoryBLL);

                    dvgCategory.DataSource = categoryDAL.FindAll();

                    MessageBox.Show("Exclusão realizada com sucesso");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dvgCategory.RowCount > 0)
            {
                categoryBLL.IdCategory = Convert.ToInt32(dvgCategory[0, dvgCategory.CurrentRow.Index].Value);
                categoryBLL = categoryDAL.FindCategory(categoryBLL);

                txtName.Text = categoryBLL.Name;

                update = true;

                tabCategory.SelectedTab = tabRegister;
            }
        }

        private void clear()
        {
            txtName.Clear();
        }
    }
}
