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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuest1 f = new frmQuest1();
            f.ShowDialog();
        }
    }
}
