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
            GBOX_login.PointToScreen()
            GBOX_login.Show();
            
        }

        private void LNK_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
