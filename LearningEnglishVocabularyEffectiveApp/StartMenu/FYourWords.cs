using Dictionary;
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
            string h = "NguyenCongPhi";
            MessageBox.Show(h);
            hihi(h);
            MessageBox.Show(h);
		}
        public string hihi(string h)
        {
            h = h.Substring(3, h.Length - 3);
            return h;
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

        private void btFind_Click(object sender, EventArgs e)
        {
            if (tbxWord.Text == "") return;
            WebActivity wa = new WebActivity();
            string[] Meanings = wa.onlineDictionary(tbxWord.Text,10);
            for(int i=0;i<Meanings.Length;i++)
            {
                this.rtbMean.Text += Meanings[i] + "\n";
            }    
        }
    }
}
