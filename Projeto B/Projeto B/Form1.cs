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
    public partial class Form1 : Form
    {
        int login = 0, sobre = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LNK_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            if(login==0)
            { 
                GPB_login.Visible = true;
                Point pt = new Point(626, 93);
                LNK_sobre.Location = pt;

                Point pt2 = new Point(578, 240);
                LNK_sair.Location = pt2;
                login = 1;
            }
            else
            {
                GPB_login.Visible = false;
                Point pt = new Point(578, 91);
                LNK_sobre.Location = pt;

                Point pt2 = new Point(578, 120);
                LNK_sair.Location = pt2;
                login = 0;
            }
        }

        private void LNK_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
