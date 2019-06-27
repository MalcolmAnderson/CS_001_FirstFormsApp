using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_001_FirstFormsApp
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtName.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoHappy_CheckedChanged(object sender, EventArgs e)
        {
            picSad.Visible = false;
            picHappy.Visible = true;
        }

        private void rdoSad_CheckedChanged(object sender, EventArgs e)
        {
            picHappy.Visible = false;
            picSad.Visible = true;
        }
    }
}
