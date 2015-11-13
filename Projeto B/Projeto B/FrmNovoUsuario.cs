using System;
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
            int codUser = 900004;//int.Parse(usuario[0])+1;
            LBL_codUsuario.Text = codUser.ToString();
            newUser.Codigo = int.Parse(LBL_codUsuario.Text);
            newUser.PswAtual = "inicio123";
            newUser.PswAnterior = "";
            newUser.PswDataAlteracao = dataAtual.ToString();
            newUser.Status = 3;
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
            newUser.Nome = TXT_nome.Text;
            newUser.Nascimento = TXT_nascimento.Text;
            if (CBOX_perfil.SelectedIndex == 0)
                newUser.Perfil = 1;
            if (CBOX_perfil.SelectedIndex == 1)
                newUser.Perfil = 2;
            if (CBOX_perfil.SelectedIndex == 2)
                newUser.Perfil = 3;
            //string userInfo = newUser.codigo.ToString() + ";" + newUser.status.ToString() + ";" + newUser.perfil.ToString() + ";" + newUser.nome + ";" + newUser.nascimento + ";" + newUser.pswAtual + ";" + newUser.pswAnterior + ";" + newUser.pswDataAlteracao;
            user.criarUsuario(newUser);
            

            MessageBox.Show("Novo Usuario criado com sucesso!\nSenha inicial: inicio123", "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            string aux = user.lerTudo();
            MessageBox.Show(aux);
           /* string aux = user.lerUltimoUser();
            string[] usuario = aux.Split(';');
            int codUser = int.Parse(usuario[0]) + 1;
            LBL_codUsuario.Text = codUser.ToString();
            TXT_nome.Text = "";
            TXT_nascimento.Text = "";
            CBOX_perfil.SelectedIndex = 3;*/
            
        }
    }
}
