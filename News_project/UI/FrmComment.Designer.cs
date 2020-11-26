namespace News_project.UI
{
    partial class FrmComment
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
            this.tabComment = new System.Windows.Forms.TabControl();
            this.tabNewComment = new System.Windows.Forms.TabPage();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNewComment = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dvgComment = new System.Windows.Forms.DataGridView();
            this.tabComment.SuspendLayout();
            this.tabNewComment.SuspendLayout();
            this.tabFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabComment
            // 
            this.tabComment.Controls.Add(this.tabNewComment);
            this.tabComment.Controls.Add(this.tabFind);
            this.tabComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabComment.Location = new System.Drawing.Point(0, 0);
            this.tabComment.Name = "tabComment";
            this.tabComment.SelectedIndex = 0;
            this.tabComment.Size = new System.Drawing.Size(484, 361);
            this.tabComment.TabIndex = 0;
            // 
            // tabNewComment
            // 
            this.tabNewComment.Controls.Add(this.btnClear);
            this.tabNewComment.Controls.Add(this.btnNewComment);
            this.tabNewComment.Controls.Add(this.txtBody);
            this.tabNewComment.Location = new System.Drawing.Point(4, 22);
            this.tabNewComment.Name = "tabNewComment";
            this.tabNewComment.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewComment.Size = new System.Drawing.Size(476, 335);
            this.tabNewComment.TabIndex = 0;
            this.tabNewComment.Text = "Novo comentario";
            this.tabNewComment.UseVisualStyleBackColor = true;
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.btnDelete);
            this.tabFind.Controls.Add(this.btnUpdate);
            this.tabFind.Controls.Add(this.dvgComment);
            this.tabFind.Location = new System.Drawing.Point(4, 22);
            this.tabFind.Name = "tabFind";
            this.tabFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabFind.Size = new System.Drawing.Size(476, 335);
            this.tabFind.TabIndex = 1;
            this.tabFind.Text = "Consultar";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(234, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 30);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnNewComment
            // 
            this.btnNewComment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewComment.Location = new System.Drawing.Point(98, 297);
            this.btnNewComment.Name = "btnNewComment";
            this.btnNewComment.Size = new System.Drawing.Size(130, 30);
            this.btnNewComment.TabIndex = 16;
            this.btnNewComment.Text = "Salvar";
            this.btnNewComment.UseVisualStyleBackColor = true;
            this.btnNewComment.Click += new System.EventHandler(this.btnNewComment_Click_1);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(8, 6);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(460, 285);
            this.txtBody.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(236, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(100, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dvgComment
            // 
            this.dvgComment.AllowUserToAddRows = false;
            this.dvgComment.AllowUserToDeleteRows = false;
            this.dvgComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvgComment.Location = new System.Drawing.Point(3, 3);
            this.dvgComment.Name = "dvgComment";
            this.dvgComment.ReadOnly = true;
            this.dvgComment.Size = new System.Drawing.Size(470, 288);
            this.dvgComment.TabIndex = 7;
            // 
            // FrmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tabComment);
            this.Name = "FrmComment";
            this.Text = "Comentario";
            this.tabComment.ResumeLayout(false);
            this.tabNewComment.ResumeLayout(false);
            this.tabNewComment.PerformLayout();
            this.tabFind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabComment;
        private System.Windows.Forms.TabPage tabNewComment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNewComment;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dvgComment;
    }
}