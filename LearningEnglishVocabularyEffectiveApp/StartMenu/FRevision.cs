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
	public partial class FRevision : Form
	{
		public FRevision()
		{
			InitializeComponent();
		}

        private void btnRan10_Click(object sender, EventArgs e)
        {
			FRamdom10fc f = new FRamdom10fc();
			this.Close();
			f.ShowDialog();
        }

        private void btnAllFlashCards_Click(object sender, EventArgs e)
        {
			FAllFlashCards f = new FAllFlashCards();
			this.Close();
			f.ShowDialog();
        }
    }
}
