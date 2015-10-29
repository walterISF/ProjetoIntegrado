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
        public FrmNovoUsuario()
        {
            InitializeComponent();
        }

        private void FrmNovoUsuario_Load(object sender, EventArgs e)
        {

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
    }
}
