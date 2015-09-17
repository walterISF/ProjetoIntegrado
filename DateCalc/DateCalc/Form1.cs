using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalc
{
    public partial class Form1 : Form
    {
        DateTime DataSistema = System.DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point pt = new Point(9, 83);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = true;
            GBOX_incrementos.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";

            LBL_dataA.Text = "Data nascimento:";
            TXT_dataA.Enabled = true;

            LBL_dataB.Text = "";
            TXT_dataB.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point pt = new Point(9, 83);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = true;
            GBOX_incrementos.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";

            LBL_dataA.Text = "Data A:";
            TXT_dataA.Enabled = true;

            LBL_dataB.Text = "Data B:";
            TXT_dataB.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point pt = new Point(9,62);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = false;
            GBOX_incrementos.Visible = true;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";

            LBL_dataA.Text = "Data A:";
            TXT_dataA.Enabled = true;

            LBL_dataB.Text = "Incrementar:";
            TXT_dataB.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point pt = new Point(9, 62);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = false;
            GBOX_incrementos.Visible = true;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";

            LBL_dataA.Text = "Data A:";
            TXT_dataA.Enabled = true;

            LBL_dataB.Text = "Decrementar:";
            TXT_dataB.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Point pt = new Point(9, 83);
            LBL_dataB.Location = pt;
            TXT_dataB.Visible = true;
            GBOX_incrementos.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";

            LBL_dataA.Text = "Data:";
            TXT_dataA.Enabled = true;

            LBL_dataB.Text = "";
            TXT_dataB.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TXT_dataB.Visible = true;
            GBOX_incrementos.Visible = false;
            TXT_dataA.Text = "";
            TXT_dataB.Text = "";

            LBL_dataA.Text = "";
            TXT_dataA.Enabled = false;

            LBL_dataB.Text = "";
            TXT_dataB.Enabled = false;
        }
    }
}
