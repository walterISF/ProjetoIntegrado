﻿namespace Projeto_B
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Compra = new System.Windows.Forms.Button();
            this.BTN_addProduto = new System.Windows.Forms.Button();
            this.BTN_addCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(76, 30);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 26);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.funcionalidadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(626, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.bloquearUsuárioToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // bloquearUsuárioToolStripMenuItem
            // 
            this.bloquearUsuárioToolStripMenuItem.Name = "bloquearUsuárioToolStripMenuItem";
            this.bloquearUsuárioToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.bloquearUsuárioToolStripMenuItem.Text = "Bloquear Usuário";
            this.bloquearUsuárioToolStripMenuItem.Click += new System.EventHandler(this.bloquearUsuárioToolStripMenuItem_Click);
            // 
            // funcionalidadesToolStripMenuItem
            // 
            this.funcionalidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            this.funcionalidadesToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.funcionalidadesToolStripMenuItem.Text = "Funcionalidades";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // BTN_Compra
            // 
            this.BTN_Compra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Compra.BackgroundImage")));
            this.BTN_Compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Compra.FlatAppearance.BorderSize = 0;
            this.BTN_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Compra.Location = new System.Drawing.Point(5, 18);
            this.BTN_Compra.Name = "BTN_Compra";
            this.BTN_Compra.Size = new System.Drawing.Size(46, 38);
            this.BTN_Compra.TabIndex = 6;
            this.BTN_Compra.UseVisualStyleBackColor = true;
            // 
            // BTN_addProduto
            // 
            this.BTN_addProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_addProduto.BackgroundImage")));
            this.BTN_addProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_addProduto.FlatAppearance.BorderSize = 0;
            this.BTN_addProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_addProduto.Location = new System.Drawing.Point(71, 18);
            this.BTN_addProduto.Name = "BTN_addProduto";
            this.BTN_addProduto.Size = new System.Drawing.Size(46, 38);
            this.BTN_addProduto.TabIndex = 7;
            this.BTN_addProduto.UseVisualStyleBackColor = true;
            this.BTN_addProduto.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_addCliente
            // 
            this.BTN_addCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_addCliente.BackgroundImage")));
            this.BTN_addCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_addCliente.FlatAppearance.BorderSize = 0;
            this.BTN_addCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_addCliente.Location = new System.Drawing.Point(137, 18);
            this.BTN_addCliente.Name = "BTN_addCliente";
            this.BTN_addCliente.Size = new System.Drawing.Size(46, 38);
            this.BTN_addCliente.TabIndex = 8;
            this.BTN_addCliente.UseVisualStyleBackColor = true;
            this.BTN_addCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Compras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_addProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTN_Compra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BTN_addCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 87);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(208, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 87);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(68, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 38);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Excluir";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(2, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 38);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alterar";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(134, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 38);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Incluir";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(404, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(75, 86);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sair";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(6, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 48);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Compra;
        private System.Windows.Forms.Button BTN_addProduto;
        private System.Windows.Forms.Button BTN_addCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem bloquearUsuárioToolStripMenuItem;
    }
}