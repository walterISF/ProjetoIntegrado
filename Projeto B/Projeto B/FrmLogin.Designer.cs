﻿namespace Projeto_B
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BTN_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_senha = new System.Windows.Forms.TextBox();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_login
            // 
            this.BTN_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BTN_login.Location = new System.Drawing.Point(16, 146);
            this.BTN_login.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(127, 34);
            this.BTN_login.TabIndex = 0;
            this.BTN_login.Text = "Entrar";
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // TXT_usuario
            // 
            this.TXT_usuario.Location = new System.Drawing.Point(129, 28);
            this.TXT_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_usuario.Multiline = true;
            this.TXT_usuario.Name = "TXT_usuario";
            this.TXT_usuario.Size = new System.Drawing.Size(187, 34);
            this.TXT_usuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // TXT_senha
            // 
            this.TXT_senha.Location = new System.Drawing.Point(129, 85);
            this.TXT_senha.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_senha.Multiline = true;
            this.TXT_senha.Name = "TXT_senha";
            this.TXT_senha.Size = new System.Drawing.Size(187, 34);
            this.TXT_senha.TabIndex = 5;
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BTN_cancelar.Location = new System.Drawing.Point(177, 146);
            this.BTN_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(127, 34);
            this.BTN_cancelar.TabIndex = 0;
            this.BTN_cancelar.Text = "Cancelar";
            this.BTN_cancelar.UseVisualStyleBackColor = true;
            this.BTN_cancelar.Click += new System.EventHandler(this.BTN_cancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 196);
            this.Controls.Add(this.TXT_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.BTN_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_senha;
        private System.Windows.Forms.Button BTN_cancelar;
    }
}