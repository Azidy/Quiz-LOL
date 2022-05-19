using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_LOL
{
    public partial class frmResposta : Form
    {
        public frmResposta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            total = Quiz_LOL.Program.pdl;

            lblPdlTotal.Text = total.ToString();

            lblPdl.Visible = true;
            lblElo.Visible = true;

            if (total >= 100)
            {
                lblEloTotal.Text = "Challenger";
            }

            else
            {
                lblEloTotal.Text = "Ferro";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
