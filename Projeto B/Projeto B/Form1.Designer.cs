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
            this.PB_logo = new System.Windows.Forms.PictureBox();
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
            this.LNK_login.Location = new System.Drawing.Point(165, 379);
            this.LNK_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNK_login.Name = "LNK_login";
            this.LNK_login.Size = new System.Drawing.Size(83, 29);
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
            this.LNK_sair.Location = new System.Drawing.Point(165, 419);
            this.LNK_sair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNK_sair.Name = "LNK_sair";
            this.LNK_sair.Size = new System.Drawing.Size(50, 29);
            this.LNK_sair.TabIndex = 3;
            this.LNK_sair.TabStop = true;
            this.LNK_sair.Text = "Sair";
            this.LNK_sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNK_sair_LinkClicked);
            // 
            // PB_logo
            // 
            this.PB_logo.BackColor = System.Drawing.Color.Transparent;
            this.PB_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_logo.Image = global::Projeto_B.Properties.Resources.Logo;
            this.PB_logo.Location = new System.Drawing.Point(49, 44);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(400, 235);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_logo.TabIndex = 5;
            this.PB_logo.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.PB_logo);
            this.Controls.Add(this.LNK_sair);
            this.Controls.Add(this.LNK_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LNK_login;
        private System.Windows.Forms.LinkLabel LNK_sair;
        private System.Windows.Forms.PictureBox PB_logo;


    }
}

