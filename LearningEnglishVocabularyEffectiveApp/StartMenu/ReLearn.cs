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
    public partial class ReLearn : Form
    {
        public ReLearn()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void ReLearn_Load(object sender, EventArgs e)
        {
            lblWordRL.Text = Data.currentQuestion.question + " : " + Data.currentQuestion.answer;
        }
    }
}
