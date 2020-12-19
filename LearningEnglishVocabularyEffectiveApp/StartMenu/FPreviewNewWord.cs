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
    public partial class FPreviewNewWord : Form
    {
        public FPreviewNewWord()
        {
            InitializeComponent();
            BackEnd.LoadData();
            BackEnd.addWord();
            BackEnd.addWord();
            BackEnd.addWord();
            this.guna2Button1.Text = Data.crrWord[0].question;
            this.guna2Button6.Text = Data.crrWord[0].answer;

            this.guna2Button2.Text = Data.crrWord[1].question;
            this.guna2Button7.Text = Data.crrWord[1].answer;

            this.guna2Button3.Text = Data.crrWord[2].question;
            this.guna2Button8.Text = Data.crrWord[2].answer;

            this.guna2Button4.Text = Data.crrWord[3].question;
            this.guna2Button9.Text = Data.crrWord[3].answer;

            this.guna2Button5.Text = Data.crrWord[4].question;
            this.guna2Button10.Text = Data.crrWord[4].answer;







        }

        private void btlStart_Click(object sender, EventArgs e)
        {
            FLearnNewWord f = new FLearnNewWord();
            this.Hide();
            f.ShowDialog();
            if (Data.XONG == true) this.Close();
            this.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void FPreviewNewWord_Load(object sender, EventArgs e)
        {

        }
    }
}
