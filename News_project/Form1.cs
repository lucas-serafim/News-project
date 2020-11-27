using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News_project
{
    public partial class Form1 : Form
    {
        BLL.UserBLL userBLL = new BLL.UserBLL();
        DAL.UserDAL userDAL = new DAL.UserDAL();

        public static string profile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                userBLL.Email = txtEmail.Text;
                userBLL.Password = txtPassword.Text;

                userBLL = userDAL.Login(userBLL);
                if (userBLL.IdUser > 0)
                {
                    profile = userBLL.UserProfile;

                    UI.FrmMenu frmMenu = new UI.FrmMenu();
                    Hide();
                    frmMenu.ShowDialog();

                    Close();
                }
                else
                {
                    MessageBox.Show("Email ou senha invalidos. Tente novamente");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
