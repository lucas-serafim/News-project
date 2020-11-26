namespace News_project.UI
{
    partial class FrmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboProfile = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dvgUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabUser.SuspendLayout();
            this.tabFind.SuspendLayout();
            this.tabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.tabRegister);
            this.tabUser.Controls.Add(this.tabFind);
            this.tabUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUser.Location = new System.Drawing.Point(0, 0);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(484, 311);
            this.tabUser.TabIndex = 6;
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.btnDelete);
            this.tabFind.Controls.Add(this.btnUpdate);
            this.tabFind.Controls.Add(this.dvgUsers);
            this.tabFind.Location = new System.Drawing.Point(4, 22);
            this.tabFind.Name = "tabFind";
            this.tabFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabFind.Size = new System.Drawing.Size(476, 285);
            this.tabFind.TabIndex = 1;
            this.tabFind.Text = "Consultar";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btnClear);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.cboProfile);
            this.tabRegister.Controls.Add(this.txtPassword);
            this.tabRegister.Controls.Add(this.txtEmail);
            this.tabRegister.Controls.Add(this.txtName);
            this.tabRegister.Controls.Add(this.label4);
            this.tabRegister.Controls.Add(this.label3);
            this.tabRegister.Controls.Add(this.label2);
            this.tabRegister.Controls.Add(this.label1);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(476, 285);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Registrar";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Perfil";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(104, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(104, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(104, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cboProfile
            // 
            this.cboProfile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfile.FormattingEnabled = true;
            this.cboProfile.ItemHeight = 16;
            this.cboProfile.Location = new System.Drawing.Point(104, 155);
            this.cboProfile.Name = "cboProfile";
            this.cboProfile.Size = new System.Drawing.Size(121, 24);
            this.cboProfile.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(95, 247);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Salvar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(231, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dvgUsers
            // 
            this.dvgUsers.AllowUserToAddRows = false;
            this.dvgUsers.AllowUserToDeleteRows = false;
            this.dvgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvgUsers.Location = new System.Drawing.Point(3, 3);
            this.dvgUsers.Name = "dvgUsers";
            this.dvgUsers.ReadOnly = true;
            this.dvgUsers.Size = new System.Drawing.Size(470, 238);
            this.dvgUsers.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(95, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(231, 247);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.tabUser);
            this.Name = "FrmUser";
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.tabUser.ResumeLayout(false);
            this.tabFind.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cboProfile;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dvgUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}