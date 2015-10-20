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
    public partial class FrmSenha : Form
    {        
        //Variaveis para teste

            int ind = -1;
            string[] usuario_teste = new string[3]{
            "Padrao111",
            "Padrao222",
            "Padrao333"};
            string[] senha_teste = new string[3]{
            "Pdr111",
            "Pdr222",
            "Pdr333"};

        public FrmSenha()
        {
            InitializeComponent();
        }

        private void FrmSenha_Load(object sender, EventArgs e)
        {

        }

        private void TXT_nsenha_TextChanged(object sender, EventArgs e)
        {
            LBL_mensagem.Text = "";
        }

        private void TXT_usuario_Leave(object sender, EventArgs e)
        {
            //Variaveis reais
            int i;

            for (i = 0; i < 3; i++)
            {
                if(TXT_usuario.Text == usuario_teste[i])
                {
                    ind = i;
                }                
            }
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            if(ind!=-1)
            {
                if(TXT_senha.Text == senha_teste[ind])
                {
                    if(TXT_nsenha.Text == TXT_rnsenha.Text)
                    {
                       senha_teste[ind] = TXT_nsenha.Text;
                       MessageBox.Show("Senha alterada com sucesso!","Senha alterada",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TXT_nsenha_Leave(object sender, EventArgs e)
        {
            if(TXT_nsenha.Text == TXT_senha.Text || TXT_nsenha.Text == TXT_usuario.Text)
            {
                TXT_nsenha.Text = "";
                MessageBox.Show("Digite uma senha diferente da atual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                if (TXT_nsenha.TextLength < 6)
                {
                    MessageBox.Show("Nova senha contém menos que 6 caracteres", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TXT_nsenha.TextLength > 10)
                {
                    MessageBox.Show("Nova senha contém mais que 10 caracteres", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string tirar = TXT_nsenha.Text;
                int i, j, qtdLetas=0, qtdNumeros=0, qtdDigitos = tirar.Length;
                char[] senha = new char[qtdDigitos];
                senha = tirar.ToCharArray();

                for (i = 0; i < qtdDigitos; i++)
                {

                    if (!char.IsLetterOrDigit(senha[i]))
                    {
                        TXT_nsenha.Text = "";
                        LBL_mensagem.Text = "É permitido somente numeros e letras!";
                        TXT_nsenha.Focus();
                        break;
                    }
                    else
                    {
                        //for (j = 0; j < qtdDigitos -2; j++)
                        //{
                         //   if (char.Equals(senha[i], senha[i + 1]) && char.Equals(senha[i + 1], senha[i + 2]))
                           // {
                             //   TXT_nsenha.Text = "";
                               // LBL_mensagem.Text = "Não é permitido 3 digitos iguais!";
                                //TXT_nsenha.Focus();
                                //break;
                            //}
                            //else
                            //{


                                if (char.IsLetter(senha[i]))
                                {
                                    qtdLetas++;
                                }
                                else if (char.IsNumber(senha[i]))
                                {
                                    qtdNumeros++;
                                }
                            //}
                       // }

                        if (qtdNumeros < 2 || qtdLetas < 2)
                        {
                            TXT_nsenha.Text = "";
                            LBL_mensagem.Text = "A senha deve conter no mínimo 2 letras e 2 numeros";
                            TXT_nsenha.Focus();
                        }
                    }
                }            
            }
        }

        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
