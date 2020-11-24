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
            StartMenu f = new StartMenu();
            this.Hide();
            this.Close();
            f.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GRearangeTheWords GRTW = new GRearangeTheWords();
           
            this.Hide();
            this.Close();
            GRTW.ShowDialog();
        }
    }
}
