﻿using System;
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
            if(GBOX_login.Visible==true)
            {
                GBOX_login.Visible = false;
            }
            else
            {
                GBOX_login.Show();
            }
            
            
        }

        private void LNK_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LNK_sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Deseja relmente Sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result==DialogResult.Yes)
            {
                this.Close();
            }
         
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BTN_calc_Click(object sender, EventArgs e)
        {
            Form datecalc = new Projeto_B.Form2();
            datecalc.ShowDialog();
        }
    }
}