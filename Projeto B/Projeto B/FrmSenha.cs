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
        public FrmSenha()
        {
            InitializeComponent();
        }

        private void FrmSenha_Load(object sender, EventArgs e)
        {

        }

        private void TXT_nsenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            if(TXT_nsenha.TextLength < 6)
            {
                MessageBox.Show("Nova senha contém menos que 6 caracteres", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(TXT_nsenha.TextLength > 10)
            {
                MessageBox.Show("Nova senha contém mais que 10 caracteres", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
