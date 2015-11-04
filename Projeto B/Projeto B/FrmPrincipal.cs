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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSenha formSenha = new FrmSenha();
            formSenha.ShowDialog();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoUsuario formNovoUsuario = new FrmNovoUsuario();
            formNovoUsuario.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalc calculadora = new FrmCalc();
            calculadora.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string usuario = "auxiliar";

            if (usuario == "operador" || usuario == "auxiliar") 
            {
                extraToolStripMenuItem.Visible = false;

            }

        }
    }
}
