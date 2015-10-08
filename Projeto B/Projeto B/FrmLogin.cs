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
            string[] usuario_teste = new string[3];
                usuario_teste[0] = "Padrao111";
                usuario_teste[1] = "Padrao222";
                usuario_teste[2] = "Padrao333";
            string[] senha_teste = new string[3];
                senha_teste[0] = "Pdr111";
                senha_teste[1] = "Pdr222";
                senha_teste[2] = "Pdr333";

            //Variaveis reais
            int i, aux_indice = -1;

            for (i = 0; i<3; i++)
                if (TXT_usuario.Text == usuario_teste[i])
                    aux_indice = i;             
            if(aux_indice == -1)
                //Mudar borda da TXT_usuario e colocar uma label embaixo da TXT_usuario com a menssagem invalida
                else
                    if (TXT_senha.Text == senha_teste[aux_indice])
                    {
                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();
                    }
                    else
                    //Mudar borda da TXT_senha e colocar uma label embaixo da TXT_senho com a menssagem invalida
        }
    }
}
