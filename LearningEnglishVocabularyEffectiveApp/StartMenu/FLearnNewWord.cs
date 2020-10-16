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
    public partial class FLearnNewWord : Form
    {
        public FLearnNewWord()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // btnBack
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StartMenu f = new StartMenu();
            this.Close();
            f.ShowDialog();
        }
    }
}
