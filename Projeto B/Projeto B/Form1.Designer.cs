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
            this.TXT_senha = new System.Windows.Forms.TextBox();
            this.TXT_login = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPB_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(800, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 699);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LNK_login
            // 
            this.LNK_login.AutoSize = true;
            this.LNK_login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNK_login.LinkColor = System.Drawing.Color.Black;
            this.LNK_login.Location = new System.Drawing.Point(829, 82);
            this.LNK_login.Name = "LNK_login";
            this.LNK_login.Size = new System.Drawing.Size(66, 29);
            this.LNK_login.TabIndex = 1;
            this.LNK_login.TabStop = true;
            this.LNK_login.Text = "Login";
            this.LNK_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_login_LinkClicked);
            // 
            // LNK_sobre
            // 
            this.LNK_sobre.AutoSize = true;
            this.LNK_sobre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNK_sobre.LinkColor = System.Drawing.Color.Black;
            this.LNK_sobre.Location = new System.Drawing.Point(829, 135);
            this.LNK_sobre.Name = "LNK_sobre";
            this.LNK_sobre.Size = new System.Drawing.Size(70, 29);
            this.LNK_sobre.TabIndex = 2;
            this.LNK_sobre.TabStop = true;
            this.LNK_sobre.Text = "Sobre";
            this.LNK_sobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_sobre_LinkClicked);
            // 
            // LNK_sair
            // 
            this.LNK_sair.AutoSize = true;
            this.LNK_sair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNK_sair.LinkColor = System.Drawing.Color.Black;
            this.LNK_sair.Location = new System.Drawing.Point(829, 188);
            this.LNK_sair.Name = "LNK_sair";
            this.LNK_sair.Size = new System.Drawing.Size(50, 29);
            this.LNK_sair.TabIndex = 3;
            this.LNK_sair.TabStop = true;
            this.LNK_sair.Text = "Sair";
            // 
            // GPB_login
            // 
            this.GPB_login.Controls.Add(this.label2);
            this.GPB_login.Controls.Add(this.label1);
            this.GPB_login.Controls.Add(this.TXT_senha);
            this.GPB_login.Controls.Add(this.TXT_login);
            this.GPB_login.Location = new System.Drawing.Point(872, 590);
            this.GPB_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPB_login.Name = "GPB_login";
            this.GPB_login.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPB_login.Size = new System.Drawing.Size(307, 148);
            this.GPB_login.TabIndex = 4;
            this.GPB_login.TabStop = false;
            this.GPB_login.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // TXT_senha
            // 
            this.TXT_senha.Location = new System.Drawing.Point(75, 90);
            this.TXT_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_senha.Multiline = true;
            this.TXT_senha.Name = "TXT_senha";
            this.TXT_senha.Size = new System.Drawing.Size(199, 30);
            this.TXT_senha.TabIndex = 0;
            // 
            // TXT_login
            // 
            this.TXT_login.Location = new System.Drawing.Point(75, 37);
            this.TXT_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_login.Multiline = true;
            this.TXT_login.Name = "TXT_login";
            this.TXT_login.Size = new System.Drawing.Size(199, 30);
            this.TXT_login.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 730);
            this.Controls.Add(this.LNK_sair);
            this.Controls.Add(this.LNK_sobre);
            this.Controls.Add(this.LNK_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GPB_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox TXT_senha;
        private System.Windows.Forms.TextBox TXT_login;


    }
}

