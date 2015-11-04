﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_B
{
    public partial class FrmNovoUsuario : Form
    {
        public struct usuario
        {
            public int codigo;
            public int status;//1-normal 2-bloqueado 3-senha inicial
            public int perfil;//1-administrados 2-operador 3-auxiliar
            public string nome;
            public string nascimento;
            public string pswAtual;
            public string pswAnterior;
            public string pswDataAlteracao;
        }

        usuarios user = new usuarios();
        usuario newUser;
        
        public FrmNovoUsuario()
        {
            InitializeComponent();
        }

        private void FrmNovoUsuario_Load(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Today;
            string aux = user.lerUltimoUser();
            string[] usuario = aux.Split(';');
            int codUser = int.Parse(usuario[0])+1;
            LBL_codUsuario.Text = codUser.ToString();
            newUser.codigo = int.Parse(LBL_codUsuario.Text);
            newUser.pswAtual = "inicio123";
            newUser.pswAnterior = "";
            newUser.pswDataAlteracao = dataAtual.ToString();
            newUser.status = 3;
        }

        private void FrmNovoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cancela a inclusão de novo usuario ?", "Cancelar...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            newUser.nome = TXT_nome.Text;
            newUser.nascimento = TXT_nascimento.Text;
            if (CBOX_perfil.SelectedIndex == 0)
                newUser.perfil = 1;
            if (CBOX_perfil.SelectedIndex == 1)
                newUser.perfil = 2;
            if (CBOX_perfil.SelectedIndex == 2)
                newUser.perfil = 3;
            string userInfo = newUser.codigo.ToString() + ";" + newUser.status.ToString() + ";" + newUser.perfil.ToString() + ";" + newUser.nome + ";" + newUser.nascimento + ";" + newUser.pswAtual + ";" + newUser.pswAnterior + ";" + newUser.pswDataAlteracao;
            user.criarUsuario(userInfo);
        }
    }
}
