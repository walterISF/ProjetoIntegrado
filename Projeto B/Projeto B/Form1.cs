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
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void LNK_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                        
            
        }

        private void LNK_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Encerrar a aplicação ?", "Encerrando...",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void BTN_calc_Click(object sender, EventArgs e)
        {
            Form datecalc = new Projeto_B.FrmCalc();
            datecalc.ShowDialog();
        }

        private void LNK_sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void LBL_login_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void LBL_sobre_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void LBL_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
