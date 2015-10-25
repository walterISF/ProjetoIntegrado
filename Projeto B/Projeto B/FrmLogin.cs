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
            int usr;
            string aux;
            LBL_usuario.Text = "";
            LBL_senha.Text = "";
            usr = usuario.findLogin(TXT_usuario.Text);            
            if(usr == -1)
            {
                LBL_usuario.Text = "Usuario Invalido";
            }
            else
            {
               if (TXT_senha.Text == usuario.findPassword(usr))
               {
                   FrmPrincipal principal = new FrmPrincipal();
                   usrLogado.setLogin(TXT_usuario.Text);
                   usrLogado.setPassword(TXT_senha.Text);
                   aux = usuario.findName(usr);
                   usrLogado.setName(aux);
                   aux = usuario.findBirth(usr);
                   usrLogado.setBirth(aux);

                   principal.Show();
               }
               else
               {
                   LBL_senha.Text = "Senha Invalida";
               }
            }
        }
    }
}
