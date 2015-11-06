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
    public partial class FrmLogin : Form
    {
        usuarioLogado usrLogado = new usuarioLogado();
        usuarios usuario = new usuarios();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            usuarios userLogin = new usuarios();
            LBL_usuario.Text = "";
            LBL_senha.Text = "";          
            if(userLogin.lerUsuario(int.Parse(TXT_usuario.Text)) == null)
            {
                LBL_usuario.Text = "Usuario Invalido";
            }
            else
            {
                string aux = userLogin.lerUsuario(int.Parse(TXT_usuario.Text));
                string[] userInfo = new string[8];
                userInfo = aux.Split(';');
                if (TXT_senha.Text == userInfo[5])
                {
                    FrmPrincipal principal = new FrmPrincipal();
                    FrmSenha alterarSenha = new FrmSenha();
                    
                    usrLogado.setLogin(int.Parse(userInfo[0]));
                    usrLogado.setStatus(int.Parse(userInfo[1]));
                    usrLogado.setPerfil(int.Parse(userInfo[2]));
                    usrLogado.setName(userInfo[3]);                    
                    usrLogado.setBirth(userInfo[4]);
                    usrLogado.setPswAtual(userInfo[5]);
                    usrLogado.setPswAnterior(userInfo[6]);
                    usrLogado.setPswData(userInfo[7]);

                    if (int.Parse(userInfo[1]) == 3)
                        alterarSenha.ShowDialog();
                    else
                        principal.Show();

                    this.Close();
                }
                else
                {
                    LBL_senha.Text = "Senha Invalida";
                }
            }
        }
    }
}
