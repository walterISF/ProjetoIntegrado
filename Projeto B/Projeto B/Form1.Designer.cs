namespace Projeto_B
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LNK_login = new System.Windows.Forms.LinkLabel();
            this.LNK_sobre = new System.Windows.Forms.LinkLabel();
            this.LNK_sair = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 569);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LNK_login
            // 
            this.LNK_login.AutoSize = true;
            this.LNK_login.Location = new System.Drawing.Point(578, 67);
            this.LNK_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNK_login.Name = "LNK_login";
            this.LNK_login.Size = new System.Drawing.Size(55, 13);
            this.LNK_login.TabIndex = 1;
            this.LNK_login.TabStop = true;
            this.LNK_login.Text = "linkLabel1";
            // 
            // LNK_sobre
            // 
            this.LNK_sobre.AutoSize = true;
            this.LNK_sobre.Location = new System.Drawing.Point(578, 93);
            this.LNK_sobre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNK_sobre.Name = "LNK_sobre";
            this.LNK_sobre.Size = new System.Drawing.Size(55, 13);
            this.LNK_sobre.TabIndex = 2;
            this.LNK_sobre.TabStop = true;
            this.LNK_sobre.Text = "linkLabel2";
            // 
            // LNK_sair
            // 
            this.LNK_sair.AutoSize = true;
            this.LNK_sair.Location = new System.Drawing.Point(578, 120);
            this.LNK_sair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNK_sair.Name = "LNK_sair";
            this.LNK_sair.Size = new System.Drawing.Size(55, 13);
            this.LNK_sair.TabIndex = 3;
            this.LNK_sair.TabStop = true;
            this.LNK_sair.Text = "linkLabel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 602);
            this.Controls.Add(this.LNK_sair);
            this.Controls.Add(this.LNK_sobre);
            this.Controls.Add(this.LNK_login);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(904, 657);
            this.MinimumSize = new System.Drawing.Size(904, 597);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LNK_login;
        private System.Windows.Forms.LinkLabel LNK_sobre;
        private System.Windows.Forms.LinkLabel LNK_sair;


    }
}

