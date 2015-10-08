namespace Projeto_B
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.BTN_calc = new System.Windows.Forms.Button();
            this.LBL_login = new System.Windows.Forms.Label();
            this.LBL_sair = new System.Windows.Forms.Label();
            this.LBL_sobre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_logo
            // 
            this.PB_logo.BackColor = System.Drawing.Color.Transparent;
            this.PB_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_logo.Image = global::Projeto_B.Properties.Resources.Logo;
            this.PB_logo.Location = new System.Drawing.Point(65, 54);
            this.PB_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(533, 289);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_logo.TabIndex = 5;
            this.PB_logo.TabStop = false;
            // 
            // BTN_calc
            // 
            this.BTN_calc.BackColor = System.Drawing.Color.Transparent;
            this.BTN_calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_calc.FlatAppearance.BorderSize = 0;
            this.BTN_calc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_calc.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic);
            this.BTN_calc.ForeColor = System.Drawing.Color.White;
            this.BTN_calc.Location = new System.Drawing.Point(217, 402);
            this.BTN_calc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_calc.Name = "BTN_calc";
            this.BTN_calc.Size = new System.Drawing.Size(236, 59);
            this.BTN_calc.TabIndex = 6;
            this.BTN_calc.Text = "Calculadora";
            this.BTN_calc.UseVisualStyleBackColor = false;
            this.BTN_calc.Click += new System.EventHandler(this.BTN_calc_Click);
            // 
            // LBL_login
            // 
            this.LBL_login.AutoSize = true;
            this.LBL_login.BackColor = System.Drawing.Color.Transparent;
            this.LBL_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_login.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_login.ForeColor = System.Drawing.Color.White;
            this.LBL_login.Location = new System.Drawing.Point(220, 480);
            this.LBL_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_login.Name = "LBL_login";
            this.LBL_login.Size = new System.Drawing.Size(142, 49);
            this.LBL_login.TabIndex = 7;
            this.LBL_login.Text = "Entrar..";
            this.LBL_login.Click += new System.EventHandler(this.LBL_login_Click);
            // 
            // LBL_sair
            // 
            this.LBL_sair.AutoSize = true;
            this.LBL_sair.BackColor = System.Drawing.Color.Transparent;
            this.LBL_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_sair.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_sair.ForeColor = System.Drawing.Color.White;
            this.LBL_sair.Location = new System.Drawing.Point(220, 543);
            this.LBL_sair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_sair.Name = "LBL_sair";
            this.LBL_sair.Size = new System.Drawing.Size(84, 49);
            this.LBL_sair.TabIndex = 8;
            this.LBL_sair.Text = "Sair";
            this.LBL_sair.Click += new System.EventHandler(this.LBL_sair_Click);
            // 
            // LBL_sobre
            // 
            this.LBL_sobre.AutoSize = true;
            this.LBL_sobre.BackColor = System.Drawing.Color.Transparent;
            this.LBL_sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_sobre.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_sobre.ForeColor = System.Drawing.Color.White;
            this.LBL_sobre.Location = new System.Drawing.Point(59, 683);
            this.LBL_sobre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_sobre.Name = "LBL_sobre";
            this.LBL_sobre.Size = new System.Drawing.Size(210, 37);
            this.LBL_sobre.TabIndex = 9;
            this.LBL_sobre.Text = "Sobre o Sistema";
            this.LBL_sobre.Click += new System.EventHandler(this.LBL_sobre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(708, 689);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "copyright 2015 Todos os direitos reservados.";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1176, 730);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_sobre);
            this.Controls.Add(this.LBL_sair);
            this.Controls.Add(this.LBL_login);
            this.Controls.Add(this.BTN_calc);
            this.Controls.Add(this.PB_logo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.Button BTN_calc;
        private System.Windows.Forms.Label LBL_login;
        private System.Windows.Forms.Label LBL_sair;
        private System.Windows.Forms.Label LBL_sobre;
        private System.Windows.Forms.Label label3;


    }
}

