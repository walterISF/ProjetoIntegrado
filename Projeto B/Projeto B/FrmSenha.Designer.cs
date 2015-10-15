namespace Projeto_B
{
    partial class FrmSenha
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
            this.BTN_salvar = new System.Windows.Forms.Button();
            this.TXT_senha = new System.Windows.Forms.TextBox();
            this.TXT_nsenha = new System.Windows.Forms.TextBox();
            this.TXT_rnsenha = new System.Windows.Forms.TextBox();
            this.LBL_n1 = new System.Windows.Forms.Label();
            this.LBL_n2 = new System.Windows.Forms.Label();
            this.LBL_n4 = new System.Windows.Forms.Label();
            this.LBL_n3 = new System.Windows.Forms.Label();
            this.LBL_n5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_salvar
            // 
            this.BTN_salvar.Location = new System.Drawing.Point(37, 226);
            this.BTN_salvar.Name = "BTN_salvar";
            this.BTN_salvar.Size = new System.Drawing.Size(75, 23);
            this.BTN_salvar.TabIndex = 0;
            this.BTN_salvar.Text = "Salvar";
            this.BTN_salvar.UseVisualStyleBackColor = true;
            this.BTN_salvar.Click += new System.EventHandler(this.BTN_salvar_Click);
            // 
            // TXT_senha
            // 
            this.TXT_senha.Location = new System.Drawing.Point(12, 68);
            this.TXT_senha.Name = "TXT_senha";
            this.TXT_senha.Size = new System.Drawing.Size(100, 20);
            this.TXT_senha.TabIndex = 2;
            // 
            // TXT_nsenha
            // 
            this.TXT_nsenha.Location = new System.Drawing.Point(12, 115);
            this.TXT_nsenha.Name = "TXT_nsenha";
            this.TXT_nsenha.Size = new System.Drawing.Size(100, 20);
            this.TXT_nsenha.TabIndex = 3;
            this.TXT_nsenha.TextChanged += new System.EventHandler(this.TXT_nsenha_TextChanged);
            // 
            // TXT_rnsenha
            // 
            this.TXT_rnsenha.Location = new System.Drawing.Point(146, 115);
            this.TXT_rnsenha.Name = "TXT_rnsenha";
            this.TXT_rnsenha.Size = new System.Drawing.Size(100, 20);
            this.TXT_rnsenha.TabIndex = 4;
            // 
            // LBL_n1
            // 
            this.LBL_n1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_n1.Location = new System.Drawing.Point(12, 178);
            this.LBL_n1.Name = "LBL_n1";
            this.LBL_n1.Size = new System.Drawing.Size(46, 16);
            this.LBL_n1.TabIndex = 5;
            // 
            // LBL_n2
            // 
            this.LBL_n2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_n2.Location = new System.Drawing.Point(59, 178);
            this.LBL_n2.Name = "LBL_n2";
            this.LBL_n2.Size = new System.Drawing.Size(46, 16);
            this.LBL_n2.TabIndex = 12;
            // 
            // LBL_n4
            // 
            this.LBL_n4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_n4.Location = new System.Drawing.Point(153, 178);
            this.LBL_n4.Name = "LBL_n4";
            this.LBL_n4.Size = new System.Drawing.Size(46, 16);
            this.LBL_n4.TabIndex = 14;
            // 
            // LBL_n3
            // 
            this.LBL_n3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_n3.Location = new System.Drawing.Point(106, 178);
            this.LBL_n3.Name = "LBL_n3";
            this.LBL_n3.Size = new System.Drawing.Size(46, 16);
            this.LBL_n3.TabIndex = 13;
            // 
            // LBL_n5
            // 
            this.LBL_n5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_n5.Location = new System.Drawing.Point(200, 178);
            this.LBL_n5.Name = "LBL_n5";
            this.LBL_n5.Size = new System.Drawing.Size(46, 16);
            this.LBL_n5.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Senha Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nova Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Força da Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Repetir Nova Senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Login :";
            // 
            // BTN_cancelar
            // 
            this.BTN_cancelar.Location = new System.Drawing.Point(146, 226);
            this.BTN_cancelar.Name = "BTN_cancelar";
            this.BTN_cancelar.Size = new System.Drawing.Size(75, 23);
            this.BTN_cancelar.TabIndex = 21;
            this.BTN_cancelar.Text = "Cancelar";
            this.BTN_cancelar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "label10";
            // 
            // FrmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 261);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BTN_cancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_n5);
            this.Controls.Add(this.LBL_n4);
            this.Controls.Add(this.LBL_n3);
            this.Controls.Add(this.LBL_n2);
            this.Controls.Add(this.LBL_n1);
            this.Controls.Add(this.TXT_rnsenha);
            this.Controls.Add(this.TXT_nsenha);
            this.Controls.Add(this.TXT_senha);
            this.Controls.Add(this.BTN_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSenha";
            this.Load += new System.EventHandler(this.FrmSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_salvar;
        private System.Windows.Forms.TextBox TXT_senha;
        private System.Windows.Forms.TextBox TXT_nsenha;
        private System.Windows.Forms.TextBox TXT_rnsenha;
        private System.Windows.Forms.Label LBL_n1;
        private System.Windows.Forms.Label LBL_n2;
        private System.Windows.Forms.Label LBL_n4;
        private System.Windows.Forms.Label LBL_n3;
        private System.Windows.Forms.Label LBL_n5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTN_cancelar;
        private System.Windows.Forms.Label label10;
    }
}