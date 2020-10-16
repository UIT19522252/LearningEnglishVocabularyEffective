using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class FRamdom10fc : Form
    {
        public FRamdom10fc()
        {
            InitializeComponent();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void FRamdom10fc_Load(object sender, EventArgs e)
        {

        }

        private void btnRDreturn_Click(object sender, EventArgs e)
        {
            StartMenu f = new StartMenu();
            this.Close();
            f.ShowDialog();
        }
    }
}
