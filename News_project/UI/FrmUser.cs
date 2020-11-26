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
    public partial class FrmUser : Form
    {
        BLL.UserBLL userBLL = new BLL.UserBLL();
        DAL.UserDAL userDAL = new DAL.UserDAL();

        bool update = false;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            dvgUsers.DataSource = userDAL.FindAll();

            cboProfile.Items.Add(Enums.UserProfile.Cliente);
            cboProfile.Items.Add(Enums.UserProfile.Jornalista);
            cboProfile.Items.Add(Enums.UserProfile.Administrador);
        }

        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            userBLL.Name = txtName.Text;
            userBLL.Email = txtEmail.Text;
            userBLL.Password = txtPassword.Text;
            userBLL.UserProfile = cboProfile.Text;
            
            if (txtName.Text == string.Empty || txtEmail.Text == string.Empty || txtPassword.Text == string.Empty || cboProfile.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (update)
                {
                    userDAL.Update(userBLL);
                    MessageBox.Show("Dados atualizados com sucesso!");
                    clear();

                    update = false;
                }
                else
                {
                    userDAL.Register(userBLL);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    clear();
                }
            }
            
            dvgUsers.DataSource = userDAL.FindAll();
        }

        private void clear()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dvgUsers.RowCount > 0)
            {
                userBLL.IdUser = Convert.ToInt32(dvgUsers[0, dvgUsers.CurrentRow.Index].Value);
                userBLL = userDAL.FindUser(userBLL);

                txtName.Text = userBLL.Name;
                txtEmail.Text = userBLL.Email;
                txtPassword.Text = userBLL.Password;
                cboProfile.Text = "";
                cboProfile.SelectedText = userBLL.UserProfile;
                
                update = true;

                tabUser.SelectedTab = tabRegister;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgUsers.RowCount > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userBLL.IdUser = Convert.ToInt16(dvgUsers[0, dvgUsers.CurrentRow.Index].Value);
                    userDAL.Delete(userBLL);

                    dvgUsers.DataSource = userDAL.FindAll();

                    MessageBox.Show("Exclusão realizada com sucesso");
                }
            }
        }
    }
}
