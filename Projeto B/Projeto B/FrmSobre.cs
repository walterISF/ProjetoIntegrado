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
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {

            label1.Text = "Objetivos: Desenvolver um software de cadastro, cuja finalidade" +
            "é oferecer ao usuário um ambiente agradável e simples de uso." +
            "funconalidade:Calculadora de datas." +
            "desenvolvedors: Allan Guerra, Walter Inácio" +
            "plataforma: Visual Studio C#" +
            "versão: 1.0";
            
        }
    }
}
