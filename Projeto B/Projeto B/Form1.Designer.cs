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
            this.GPB_login = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.LBL_sobre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPB_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.LNK_login.Size = new System.Drawing.Size(33, 13);
            this.LNK_login.TabIndex = 1;
            this.LNK_login.TabStop = true;
            this.LNK_login.Text = "Login";
            this.LNK_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_login_LinkClicked);
            // 
            // LNK_sobre
            // 
            this.LNK_sobre.AutoSize = true;
            this.LNK_sobre.Location = new System.Drawing.Point(578, 91);
            this.LNK_sobre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNK_sobre.Name = "LNK_sobre";
            this.LNK_sobre.Size = new System.Drawing.Size(35, 13);
            this.LNK_sobre.TabIndex = 2;
            this.LNK_sobre.TabStop = true;
            this.LNK_sobre.Text = "Sobre";
            this.LNK_sobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_sobre_LinkClicked);
            // 
            // LNK_sair
            // 
            this.LNK_sair.AutoSize = true;
            this.LNK_sair.Location = new System.Drawing.Point(578, 120);
            this.LNK_sair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNK_sair.Name = "LNK_sair";
            this.LNK_sair.Size = new System.Drawing.Size(25, 13);
            this.LNK_sair.TabIndex = 3;
            this.LNK_sair.TabStop = true;
            this.LNK_sair.Text = "Sair";
            // 
            // GPB_login
            // 
            this.GPB_login.BackColor = System.Drawing.Color.Gainsboro;
            this.GPB_login.Controls.Add(this.label2);
            this.GPB_login.Controls.Add(this.label1);
            this.GPB_login.Controls.Add(this.txtSenha);
            this.GPB_login.Controls.Add(this.txtLogin);
            this.GPB_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GPB_login.Location = new System.Drawing.Point(574, 91);
            this.GPB_login.Name = "GPB_login";
            this.GPB_login.Size = new System.Drawing.Size(229, 100);
            this.GPB_login.TabIndex = 4;
            this.GPB_login.TabStop = false;
            this.GPB_login.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(75, 60);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(133, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(75, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(133, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // LBL_sobre
            // 
            this.LBL_sobre.BackColor = System.Drawing.Color.Gainsboro;
            this.LBL_sobre.Location = new System.Drawing.Point(578, 110);
            this.LBL_sobre.Name = "LBL_sobre";
            this.LBL_sobre.Size = new System.Drawing.Size(290, 225);
            this.LBL_sobre.TabIndex = 5;
            this.LBL_sobre.Visible = false;
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
            this.Controls.Add(this.LBL_sobre);
            this.Controls.Add(this.GPB_login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(904, 657);
            this.MinimumSize = new System.Drawing.Size(904, 597);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GPB_login.ResumeLayout(false);
            this.GPB_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LNK_login;
        private System.Windows.Forms.LinkLabel LNK_sobre;
        private System.Windows.Forms.LinkLabel LNK_sair;
        private System.Windows.Forms.GroupBox GPB_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label LBL_sobre;


    }
}

