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
    public partial class frmQuest1 : Form
    {
        public frmQuest1()
        {
            InitializeComponent();
        }

        private void btnResposta1_Click(object sender, EventArgs e)
        {
            Quiz_LOL.Program.pdl += -10;
            MessageBox.Show("Que pena vc errou :(");
            this.Hide();
            frmQuest2 f = new frmQuest2();
            f.ShowDialog();
        }

        private void btnResposta2_Click(object sender, EventArgs e)
        {
            Quiz_LOL.Program.pdl += -10;
            MessageBox.Show("Que pena vc errou :(");
            this.Hide();
            frmQuest2 f = new frmQuest2();
            f.ShowDialog();
        }

        private void btnResposta3_Click(object sender, EventArgs e)
        {
            Quiz_LOL.Program.pdl += 20;
            MessageBox.Show("Parabens vc acertou :)");
            this.Hide();
            frmQuest2 f = new frmQuest2();
            f.ShowDialog();
        }
    }
}
