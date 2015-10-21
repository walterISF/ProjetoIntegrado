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
            //Variaveis para teste
            

            //Variaveis reais
            int usr;

            usr = usuario.findLogin(TXT_usuario.Text);            
            if(usr == -1)
            {
                float ESPESSURA = 2.0f;
                Color COR = Color.Red;
                TXT_usuario.BorderStyle = BorderStyle.None;
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(new Pen(COR, ESPESSURA), TXT_usuario.Location.X, TXT_usuario.Location.Y, TXT_usuario.Width, TXT_usuario.Height);
                LBL_usuario.Text = "Usuario Invalido";
            }
            else
            {
               if (TXT_senha.Text == usuario.findPassword(usr))
               {
                   FrmPrincipal principal = new FrmPrincipal();
                   usrLogado.setLogin(TXT_usuario.Text);
                   usrLogado.setPassword(TXT_senha.Text);
                   principal.Show();
               }
               else
               {
                   float ESPESSURA = 2.0f;
                   Color COR = Color.Red;
                   TXT_senha.BorderStyle = BorderStyle.None;
                   Graphics g = this.CreateGraphics();
                   g.DrawRectangle(new Pen(COR, ESPESSURA), TXT_senha.Location.X, TXT_senha.Location.Y, TXT_senha.Width, TXT_senha.Height);
                   LBL_senha.Text = "Senha Invalida";
               }
            }
        }
    }
}
