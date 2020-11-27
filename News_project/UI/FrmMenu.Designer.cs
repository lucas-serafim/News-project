namespace News_project.UI
{
    partial class FrmMenu
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountUser = new System.Windows.Forms.Label();
            this.lblCountNews = new System.Windows.Forms.Label();
            this.lblCountCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(12, 133);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(130, 30);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Usuario";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnNews
            // 
            this.btnNews.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNews.Location = new System.Drawing.Point(148, 133);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(130, 30);
            this.btnNews.TabIndex = 1;
            this.btnNews.Text = "Noticias";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(284, 133);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(130, 30);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Categoria";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total de usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total de noticias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total de categorias";
            // 
            // lblCountUser
            // 
            this.lblCountUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountUser.Location = new System.Drawing.Point(12, 61);
            this.lblCountUser.Name = "lblCountUser";
            this.lblCountUser.Size = new System.Drawing.Size(116, 23);
            this.lblCountUser.TabIndex = 6;
            this.lblCountUser.Text = "0";
            this.lblCountUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountNews
            // 
            this.lblCountNews.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountNews.Location = new System.Drawing.Point(150, 61);
            this.lblCountNews.Name = "lblCountNews";
            this.lblCountNews.Size = new System.Drawing.Size(109, 23);
            this.lblCountNews.TabIndex = 7;
            this.lblCountNews.Text = "0";
            this.lblCountNews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountCategory
            // 
            this.lblCountCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCategory.Location = new System.Drawing.Point(284, 61);
            this.lblCountCategory.Name = "lblCountCategory";
            this.lblCountCategory.Size = new System.Drawing.Size(126, 23);
            this.lblCountCategory.TabIndex = 8;
            this.lblCountCategory.Text = "0";
            this.lblCountCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 177);
            this.Controls.Add(this.lblCountCategory);
            this.Controls.Add(this.lblCountNews);
            this.Controls.Add(this.lblCountUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountUser;
        private System.Windows.Forms.Label lblCountNews;
        private System.Windows.Forms.Label lblCountCategory;
    }
}