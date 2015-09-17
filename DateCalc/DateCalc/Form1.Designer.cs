namespace DateCalc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBOX_resultados = new System.Windows.Forms.GroupBox();
            this.LBL_resultados = new System.Windows.Forms.Label();
            this.GBOX_nascimento = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.LBL_dataA = new System.Windows.Forms.Label();
            this.LBL_dataB = new System.Windows.Forms.Label();
            this.GBOX_incrementos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_dataA = new System.Windows.Forms.MaskedTextBox();
            this.TXT_dataB = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBOX_resultados.SuspendLayout();
            this.GBOX_nascimento.SuspendLayout();
            this.GBOX_incrementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DateCalc.Properties.Resources.Divisor;
            this.pictureBox1.Location = new System.Drawing.Point(270, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 420);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GBOX_resultados
            // 
            this.GBOX_resultados.BackColor = System.Drawing.SystemColors.Control;
            this.GBOX_resultados.Controls.Add(this.LBL_resultados);
            this.GBOX_resultados.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_resultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GBOX_resultados.Location = new System.Drawing.Point(289, 253);
            this.GBOX_resultados.Name = "GBOX_resultados";
            this.GBOX_resultados.Size = new System.Drawing.Size(425, 164);
            this.GBOX_resultados.TabIndex = 8;
            this.GBOX_resultados.TabStop = false;
            this.GBOX_resultados.Text = "Resultados";
            // 
            // LBL_resultados
            // 
            this.LBL_resultados.Location = new System.Drawing.Point(13, 30);
            this.LBL_resultados.Name = "LBL_resultados";
            this.LBL_resultados.Size = new System.Drawing.Size(399, 118);
            this.LBL_resultados.TabIndex = 0;
            // 
            // GBOX_nascimento
            // 
            this.GBOX_nascimento.Controls.Add(this.label1);
            this.GBOX_nascimento.Enabled = false;
            this.GBOX_nascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GBOX_nascimento.Location = new System.Drawing.Point(289, 78);
            this.GBOX_nascimento.Name = "GBOX_nascimento";
            this.GBOX_nascimento.Size = new System.Drawing.Size(425, 159);
            this.GBOX_nascimento.TabIndex = 16;
            this.GBOX_nascimento.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 124);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.Location = new System.Drawing.Point(12, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cálculo de idade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.Location = new System.Drawing.Point(12, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Diferença entre datas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.Location = new System.Drawing.Point(12, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Decremento de datas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.Location = new System.Drawing.Point(12, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(245, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "Incremento de datas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button5.Location = new System.Drawing.Point(12, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(245, 32);
            this.button5.TabIndex = 22;
            this.button5.Text = "Outros calendários";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button6.Location = new System.Drawing.Point(12, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(245, 32);
            this.button6.TabIndex = 21;
            this.button6.Text = "Informações sobre datas";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LBL_dataA
            // 
            this.LBL_dataA.AutoSize = true;
            this.LBL_dataA.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dataA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_dataA.Location = new System.Drawing.Point(13, 15);
            this.LBL_dataA.Name = "LBL_dataA";
            this.LBL_dataA.Size = new System.Drawing.Size(0, 23);
            this.LBL_dataA.TabIndex = 23;
            // 
            // LBL_dataB
            // 
            this.LBL_dataB.AutoSize = true;
            this.LBL_dataB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dataB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBL_dataB.Location = new System.Drawing.Point(13, 106);
            this.LBL_dataB.Name = "LBL_dataB";
            this.LBL_dataB.Size = new System.Drawing.Size(0, 23);
            this.LBL_dataB.TabIndex = 25;
            // 
            // GBOX_incrementos
            // 
            this.GBOX_incrementos.Controls.Add(this.maskedTextBox2);
            this.GBOX_incrementos.Controls.Add(this.maskedTextBox3);
            this.GBOX_incrementos.Controls.Add(this.maskedTextBox1);
            this.GBOX_incrementos.Controls.Add(this.label4);
            this.GBOX_incrementos.Controls.Add(this.label3);
            this.GBOX_incrementos.Controls.Add(this.label2);
            this.GBOX_incrementos.Location = new System.Drawing.Point(16, 96);
            this.GBOX_incrementos.Name = "GBOX_incrementos";
            this.GBOX_incrementos.Size = new System.Drawing.Size(241, 65);
            this.GBOX_incrementos.TabIndex = 30;
            this.GBOX_incrementos.TabStop = false;
            this.GBOX_incrementos.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(178, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Meses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(88, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Semanas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dias";
            // 
            // TXT_dataA
            // 
            this.TXT_dataA.BackColor = System.Drawing.Color.Gainsboro;
            this.TXT_dataA.Enabled = false;
            this.TXT_dataA.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_dataA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXT_dataA.Location = new System.Drawing.Point(16, 41);
            this.TXT_dataA.Mask = "00/00/0000";
            this.TXT_dataA.Name = "TXT_dataA";
            this.TXT_dataA.Size = new System.Drawing.Size(241, 29);
            this.TXT_dataA.TabIndex = 31;
            // 
            // TXT_dataB
            // 
            this.TXT_dataB.BackColor = System.Drawing.Color.Gainsboro;
            this.TXT_dataB.Enabled = false;
            this.TXT_dataB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_dataB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXT_dataB.Location = new System.Drawing.Point(13, 131);
            this.TXT_dataB.Mask = "00/00/0000";
            this.TXT_dataB.Name = "TXT_dataB";
            this.TXT_dataB.Size = new System.Drawing.Size(241, 29);
            this.TXT_dataB.TabIndex = 32;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(9, 31);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(48, 26);
            this.maskedTextBox1.TabIndex = 33;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(181, 31);
            this.maskedTextBox2.Mask = "00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(48, 26);
            this.maskedTextBox2.TabIndex = 34;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(91, 31);
            this.maskedTextBox3.Mask = "00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(48, 26);
            this.maskedTextBox3.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.TXT_dataB);
            this.Controls.Add(this.TXT_dataA);
            this.Controls.Add(this.LBL_dataB);
            this.Controls.Add(this.LBL_dataA);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GBOX_nascimento);
            this.Controls.Add(this.GBOX_resultados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBOX_incrementos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBOX_resultados.ResumeLayout(false);
            this.GBOX_nascimento.ResumeLayout(false);
            this.GBOX_incrementos.ResumeLayout(false);
            this.GBOX_incrementos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GBOX_resultados;
        private System.Windows.Forms.Label LBL_resultados;
        private System.Windows.Forms.GroupBox GBOX_nascimento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label LBL_dataA;
        private System.Windows.Forms.Label LBL_dataB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBOX_incrementos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TXT_dataA;
        private System.Windows.Forms.MaskedTextBox TXT_dataB;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

