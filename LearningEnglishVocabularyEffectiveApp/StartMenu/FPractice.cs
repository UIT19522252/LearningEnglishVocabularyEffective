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
    public partial class FPractice : Form
    {
        public FPractice()
        {
            InitializeComponent();
        }
        //btn Back
        private void guna2Button3_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            this.Close();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GRearangeTheWords game1 = new GRearangeTheWords();
            this.Hide();
            game1.ShowDialog();
            this.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
