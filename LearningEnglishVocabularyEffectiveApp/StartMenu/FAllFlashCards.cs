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
	public partial class FAllFlashCards : Form
	{
		public FAllFlashCards()
		{
			InitializeComponent();
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			FRevision f = new FRevision();
			this.Hide();
			f.ShowDialog();
			this.Close();
        }
    }
}
