﻿namespace Projeto_B
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.LNK_login = new System.Windows.Forms.LinkLabel();
            this.LNK_sair = new System.Windows.Forms.LinkLabel();
            this.TXT_login = new System.Windows.Forms.TextBox();
            this.TXT_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GBOX_login = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_login = new System.Windows.Forms.Button();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.BTN_calc = new System.Windows.Forms.Button();
            this.GBOX_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LNK_login
            // 
            this.LNK_login.AutoSize = true;
            this.LNK_login.BackColor = System.Drawing.Color.Transparent;
            this.LNK_login.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNK_login.ForeColor = System.Drawing.Color.White;
            this.LNK_login.LinkColor = System.Drawing.Color.White;
            this.LNK_login.Location = new System.Drawing.Point(220, 466);
            this.LNK_login.Name = "LNK_login";
            this.LNK_login.Size = new System.Drawing.Size(106, 37);
            this.LNK_login.TabIndex = 1;
            this.LNK_login.TabStop = true;
            this.LNK_login.Text = "Entrar..";
            this.LNK_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_login_LinkClicked);
            // 
            // LNK_sair
            // 
            this.LNK_sair.AutoSize = true;
            this.LNK_sair.BackColor = System.Drawing.Color.Transparent;
            this.LNK_sair.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNK_sair.ForeColor = System.Drawing.Color.White;
            this.LNK_sair.LinkColor = System.Drawing.Color.White;
            this.LNK_sair.Location = new System.Drawing.Point(220, 516);
            this.LNK_sair.Name = "LNK_sair";
            this.LNK_sair.Size = new System.Drawing.Size(63, 37);
            this.LNK_sair.TabIndex = 3;
            this.LNK_sair.TabStop = true;
            this.LNK_sair.Text = "Sair";
            this.LNK_sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_sair_LinkClicked);
            // 
            // TXT_login
            // 
            this.TXT_login.Location = new System.Drawing.Point(75, 37);
            this.TXT_login.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_login.Multiline = true;
            this.TXT_login.Name = "TXT_login";
            this.TXT_login.Size = new System.Drawing.Size(199, 30);
            this.TXT_login.TabIndex = 0;
            // 
            // TXT_senha
            // 
            this.TXT_senha.Location = new System.Drawing.Point(75, 90);
            this.TXT_senha.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_senha.Multiline = true;
            this.TXT_senha.Name = "TXT_senha";
            this.TXT_senha.Size = new System.Drawing.Size(199, 30);
            this.TXT_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // GBOX_login
            // 
            this.GBOX_login.Controls.Add(this.button1);
            this.GBOX_login.Controls.Add(this.BTN_login);
            this.GBOX_login.Controls.Add(this.label2);
            this.GBOX_login.Controls.Add(this.label1);
            this.GBOX_login.Controls.Add(this.TXT_senha);
            this.GBOX_login.Controls.Add(this.TXT_login);
            this.GBOX_login.Location = new System.Drawing.Point(448, 318);
            this.GBOX_login.Margin = new System.Windows.Forms.Padding(4);
            this.GBOX_login.Name = "GBOX_login";
            this.GBOX_login.Padding = new System.Windows.Forms.Padding(4);
            this.GBOX_login.Size = new System.Drawing.Size(307, 170);
            this.GBOX_login.TabIndex = 4;
            this.GBOX_login.TabStop = false;
            this.GBOX_login.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(157, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BTN_login
            // 
            this.BTN_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.BTN_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BTN_login.ForeColor = System.Drawing.Color.White;
            this.BTN_login.Location = new System.Drawing.Point(13, 128);
            this.BTN_login.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(117, 36);
            this.BTN_login.TabIndex = 3;
            this.BTN_login.Text = "Logar";
            this.BTN_login.UseVisualStyleBackColor = false;
            // 
            // PB_logo
            // 
            this.PB_logo.BackColor = System.Drawing.Color.Transparent;
            this.PB_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_logo.Image = global::Projeto_B.Properties.Resources.Logo;
            this.PB_logo.Location = new System.Drawing.Point(65, 54);
            this.PB_logo.Margin = new System.Windows.Forms.Padding(4);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(533, 289);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_logo.TabIndex = 5;
            this.PB_logo.TabStop = false;
            // 
            // BTN_calc
            // 
            this.BTN_calc.Location = new System.Drawing.Point(227, 431);
            this.BTN_calc.Name = "BTN_calc";
            this.BTN_calc.Size = new System.Drawing.Size(112, 32);
            this.BTN_calc.TabIndex = 6;
            this.BTN_calc.Text = "calculadora";
            this.BTN_calc.UseVisualStyleBackColor = true;
            this.BTN_calc.Click += new System.EventHandler(this.BTN_calc_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1176, 730);
            this.Controls.Add(this.BTN_calc);
            this.Controls.Add(this.GBOX_login);
            this.Controls.Add(this.PB_logo);
            this.Controls.Add(this.LNK_sair);
            this.Controls.Add(this.LNK_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.GBOX_login.ResumeLayout(false);
            this.GBOX_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LNK_login;
        private System.Windows.Forms.LinkLabel LNK_sair;
        private System.Windows.Forms.TextBox TXT_login;
        private System.Windows.Forms.TextBox TXT_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBOX_login;
        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_calc;


    }
}
