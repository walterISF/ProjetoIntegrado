namespace Projeto_B
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
            this.funcionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_produtos = new System.Windows.Forms.Button();
            this.BTN_compras = new System.Windows.Forms.Button();
            this.BTN_clientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_excluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_incluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_sair = new System.Windows.Forms.Button();
            this.TXT_item1 = new System.Windows.Forms.TextBox();
            this.LBL_item1 = new System.Windows.Forms.Label();
            this.LBL_item2 = new System.Windows.Forms.Label();
            this.TXT_item2 = new System.Windows.Forms.TextBox();
            this.LBL_item3 = new System.Windows.Forms.Label();
            this.TXT_item3 = new System.Windows.Forms.TextBox();
            this.LBL_item4 = new System.Windows.Forms.Label();
            this.TXT_item4 = new System.Windows.Forms.TextBox();
            this.LBL_item6 = new System.Windows.Forms.Label();
            this.TXT_item6 = new System.Windows.Forms.TextBox();
            this.LBL_itens = new System.Windows.Forms.ListBox();
            this.LBL_item5 = new System.Windows.Forms.Label();
            this.TXT_item5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_alterar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(626, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // funcionalidadesToolStripMenuItem
            // 
            this.funcionalidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            this.funcionalidadesToolStripMenuItem.Size = new System.Drawing.Size(105, 21);
            this.funcionalidadesToolStripMenuItem.Text = "Funcionalidades";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // BTN_produtos
            // 
            this.BTN_produtos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_produtos.BackgroundImage")));
            this.BTN_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_produtos.FlatAppearance.BorderSize = 0;
            this.BTN_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_produtos.Location = new System.Drawing.Point(5, 18);
            this.BTN_produtos.Name = "BTN_produtos";
            this.BTN_produtos.Size = new System.Drawing.Size(60, 54);
            this.BTN_produtos.TabIndex = 6;
            this.BTN_produtos.UseVisualStyleBackColor = true;
            // 
            // BTN_compras
            // 
            this.BTN_compras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_compras.BackgroundImage")));
            this.BTN_compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_compras.FlatAppearance.BorderSize = 0;
            this.BTN_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_compras.Location = new System.Drawing.Point(71, 18);
            this.BTN_compras.Name = "BTN_compras";
            this.BTN_compras.Size = new System.Drawing.Size(60, 54);
            this.BTN_compras.TabIndex = 7;
            this.BTN_compras.UseVisualStyleBackColor = true;
            // 
            // BTN_clientes
            // 
            this.BTN_clientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_clientes.BackgroundImage")));
            this.BTN_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_clientes.FlatAppearance.BorderSize = 0;
            this.BTN_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_clientes.Location = new System.Drawing.Point(137, 18);
            this.BTN_clientes.Name = "BTN_clientes";
            this.BTN_clientes.Size = new System.Drawing.Size(60, 54);
            this.BTN_clientes.TabIndex = 8;
            this.BTN_clientes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Compras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_compras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTN_produtos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BTN_clientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BTN_alterar);
            this.groupBox2.Controls.Add(this.BTN_excluir);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BTN_incluir);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(215, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 93);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // BTN_excluir
            // 
            this.BTN_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_excluir.BackgroundImage")));
            this.BTN_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_excluir.FlatAppearance.BorderSize = 0;
            this.BTN_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_excluir.Location = new System.Drawing.Point(71, 18);
            this.BTN_excluir.Name = "BTN_excluir";
            this.BTN_excluir.Size = new System.Drawing.Size(60, 54);
            this.BTN_excluir.TabIndex = 7;
            this.BTN_excluir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Excluir";
            // 
            // BTN_incluir
            // 
            this.BTN_incluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_incluir.BackgroundImage")));
            this.BTN_incluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_incluir.FlatAppearance.BorderSize = 0;
            this.BTN_incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_incluir.Location = new System.Drawing.Point(5, 18);
            this.BTN_incluir.Name = "BTN_incluir";
            this.BTN_incluir.Size = new System.Drawing.Size(60, 54);
            this.BTN_incluir.TabIndex = 6;
            this.BTN_incluir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Incluir";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.BTN_sair);
            this.groupBox3.Location = new System.Drawing.Point(512, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(75, 92);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sair";
            // 
            // BTN_sair
            // 
            this.BTN_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_sair.BackgroundImage")));
            this.BTN_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_sair.FlatAppearance.BorderSize = 0;
            this.BTN_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_sair.Location = new System.Drawing.Point(6, 18);
            this.BTN_sair.Name = "BTN_sair";
            this.BTN_sair.Size = new System.Drawing.Size(60, 54);
            this.BTN_sair.TabIndex = 12;
            this.BTN_sair.UseVisualStyleBackColor = true;
            this.BTN_sair.Click += new System.EventHandler(this.BTN_sair_Click);
            // 
            // TXT_item1
            // 
            this.TXT_item1.Location = new System.Drawing.Point(83, 185);
            this.TXT_item1.Name = "TXT_item1";
            this.TXT_item1.Size = new System.Drawing.Size(183, 24);
            this.TXT_item1.TabIndex = 15;
            // 
            // LBL_item1
            // 
            this.LBL_item1.AutoSize = true;
            this.LBL_item1.Location = new System.Drawing.Point(31, 188);
            this.LBL_item1.Name = "LBL_item1";
            this.LBL_item1.Size = new System.Drawing.Size(42, 17);
            this.LBL_item1.TabIndex = 16;
            this.LBL_item1.Text = "label8";
            // 
            // LBL_item2
            // 
            this.LBL_item2.AutoSize = true;
            this.LBL_item2.Location = new System.Drawing.Point(300, 188);
            this.LBL_item2.Name = "LBL_item2";
            this.LBL_item2.Size = new System.Drawing.Size(42, 17);
            this.LBL_item2.TabIndex = 18;
            this.LBL_item2.Text = "label9";
            // 
            // TXT_item2
            // 
            this.TXT_item2.Location = new System.Drawing.Point(352, 185);
            this.TXT_item2.Name = "TXT_item2";
            this.TXT_item2.Size = new System.Drawing.Size(183, 24);
            this.TXT_item2.TabIndex = 17;
            // 
            // LBL_item3
            // 
            this.LBL_item3.AutoSize = true;
            this.LBL_item3.Location = new System.Drawing.Point(31, 231);
            this.LBL_item3.Name = "LBL_item3";
            this.LBL_item3.Size = new System.Drawing.Size(49, 17);
            this.LBL_item3.TabIndex = 20;
            this.LBL_item3.Text = "label10";
            // 
            // TXT_item3
            // 
            this.TXT_item3.Location = new System.Drawing.Point(83, 228);
            this.TXT_item3.Name = "TXT_item3";
            this.TXT_item3.Size = new System.Drawing.Size(183, 24);
            this.TXT_item3.TabIndex = 19;
            // 
            // LBL_item4
            // 
            this.LBL_item4.AutoSize = true;
            this.LBL_item4.Location = new System.Drawing.Point(300, 234);
            this.LBL_item4.Name = "LBL_item4";
            this.LBL_item4.Size = new System.Drawing.Size(49, 17);
            this.LBL_item4.TabIndex = 22;
            this.LBL_item4.Text = "label11";
            // 
            // TXT_item4
            // 
            this.TXT_item4.Location = new System.Drawing.Point(352, 231);
            this.TXT_item4.Name = "TXT_item4";
            this.TXT_item4.Size = new System.Drawing.Size(183, 24);
            this.TXT_item4.TabIndex = 21;
            // 
            // LBL_item6
            // 
            this.LBL_item6.AutoSize = true;
            this.LBL_item6.Location = new System.Drawing.Point(300, 286);
            this.LBL_item6.Name = "LBL_item6";
            this.LBL_item6.Size = new System.Drawing.Size(49, 17);
            this.LBL_item6.TabIndex = 24;
            this.LBL_item6.Text = "label12";
            // 
            // TXT_item6
            // 
            this.TXT_item6.Location = new System.Drawing.Point(352, 283);
            this.TXT_item6.Name = "TXT_item6";
            this.TXT_item6.Size = new System.Drawing.Size(183, 24);
            this.TXT_item6.TabIndex = 23;
            // 
            // LBL_itens
            // 
            this.LBL_itens.FormattingEnabled = true;
            this.LBL_itens.ItemHeight = 17;
            this.LBL_itens.Location = new System.Drawing.Point(17, 368);
            this.LBL_itens.MultiColumn = true;
            this.LBL_itens.Name = "LBL_itens";
            this.LBL_itens.ScrollAlwaysVisible = true;
            this.LBL_itens.Size = new System.Drawing.Size(597, 208);
            this.LBL_itens.TabIndex = 25;
            // 
            // LBL_item5
            // 
            this.LBL_item5.AutoSize = true;
            this.LBL_item5.Location = new System.Drawing.Point(31, 286);
            this.LBL_item5.Name = "LBL_item5";
            this.LBL_item5.Size = new System.Drawing.Size(49, 17);
            this.LBL_item5.TabIndex = 27;
            this.LBL_item5.Text = "label13";
            // 
            // TXT_item5
            // 
            this.TXT_item5.Location = new System.Drawing.Point(83, 283);
            this.TXT_item5.Name = "TXT_item5";
            this.TXT_item5.Size = new System.Drawing.Size(183, 24);
            this.TXT_item5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alterar";
            // 
            // BTN_alterar
            // 
            this.BTN_alterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_alterar.BackgroundImage")));
            this.BTN_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_alterar.FlatAppearance.BorderSize = 0;
            this.BTN_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_alterar.Location = new System.Drawing.Point(137, 18);
            this.BTN_alterar.Name = "BTN_alterar";
            this.BTN_alterar.Size = new System.Drawing.Size(60, 54);
            this.BTN_alterar.TabIndex = 12;
            this.BTN_alterar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(210, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Alterar";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(203, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 54);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 595);
            this.Controls.Add(this.LBL_item5);
            this.Controls.Add(this.TXT_item5);
            this.Controls.Add(this.LBL_itens);
            this.Controls.Add(this.LBL_item6);
            this.Controls.Add(this.TXT_item6);
            this.Controls.Add(this.LBL_item4);
            this.Controls.Add(this.TXT_item4);
            this.Controls.Add(this.LBL_item3);
            this.Controls.Add(this.TXT_item3);
            this.Controls.Add(this.LBL_item2);
            this.Controls.Add(this.TXT_item2);
            this.Controls.Add(this.LBL_item1);
            this.Controls.Add(this.TXT_item1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "c";
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
        private System.Windows.Forms.Button BTN_produtos;
        private System.Windows.Forms.Button BTN_compras;
        private System.Windows.Forms.Button BTN_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_excluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_incluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_sair;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_alterar;
        private System.Windows.Forms.TextBox TXT_item1;
        private System.Windows.Forms.Label LBL_item1;
        private System.Windows.Forms.Label LBL_item2;
        private System.Windows.Forms.TextBox TXT_item2;
        private System.Windows.Forms.Label LBL_item3;
        private System.Windows.Forms.TextBox TXT_item3;
        private System.Windows.Forms.Label LBL_item4;
        private System.Windows.Forms.TextBox TXT_item4;
        private System.Windows.Forms.Label LBL_item6;
        private System.Windows.Forms.TextBox TXT_item6;
        private System.Windows.Forms.ListBox LBL_itens;
        private System.Windows.Forms.Label LBL_item5;
        private System.Windows.Forms.TextBox TXT_item5;
    }
}