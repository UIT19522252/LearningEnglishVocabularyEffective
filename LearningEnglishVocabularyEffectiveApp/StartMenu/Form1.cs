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
	public partial class StartMenu : Form
	{
		string username;
		public StartMenu()
		{
			InitializeComponent();

		}
        public StartMenu(string username)
		{
			InitializeComponent();
			this.username = username;

		}

		private void btnLNW_Click(object sender, EventArgs e)
        {
			FLearnNewWord f = new FLearnNewWord();
			this.Close();
			f.ShowDialog();
			
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
			FPractice f = new FPractice();
			this.Close();
			f.ShowDialog();
        }

        private void btnRevision_Click(object sender, EventArgs e)
        {
			FRevision f = new FRevision();
			this.Close();
			f.ShowDialog();
        }

        private void btnYourWords_Click(object sender, EventArgs e)
        {
			FYourWords f = new FYourWords();
			this.Close();
			f.ShowDialog();
        }

        private void btnIntroducetions_Click(object sender, EventArgs e)
        {
			FIntroduction f = new FIntroduction();
			this.Close();
			f.ShowDialog();
        }
    }
}
