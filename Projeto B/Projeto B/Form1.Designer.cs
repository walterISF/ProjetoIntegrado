namespace Projeto_B
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
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.BTN_calc = new System.Windows.Forms.Button();
            this.LBL_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
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
            this.BTN_calc.Location = new System.Drawing.Point(163, 327);
            this.BTN_calc.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_calc.Name = "BTN_calc";
            this.BTN_calc.Size = new System.Drawing.Size(177, 48);
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
            this.LBL_login.Location = new System.Drawing.Point(165, 390);
            this.LBL_login.Name = "LBL_login";
            this.LBL_login.Size = new System.Drawing.Size(111, 39);
            this.LBL_login.TabIndex = 7;
            this.LBL_login.Text = "Entrar..";
            this.LBL_login.Click += new System.EventHandler(this.LBL_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sair";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sobre o Sistema";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(563, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "copyright Todos os direitos reservados.";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_login);
            this.Controls.Add(this.BTN_calc);
            this.Controls.Add(this.PB_logo);
            this.ForeColor = System.Drawing.Color.Black;
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

        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.Button BTN_calc;
        private System.Windows.Forms.Label LBL_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}

