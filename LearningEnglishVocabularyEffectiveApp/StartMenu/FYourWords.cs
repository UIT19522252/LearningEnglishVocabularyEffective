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
	public partial class FYourWords : Form
	{
		public FYourWords()
		{
			InitializeComponent();
		}

        private void ScrlWord_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tbxWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddWord_Click(sender, e);
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {

        }
    }
}
