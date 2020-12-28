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
            Data.crrWord.Clear();
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
            pnlLoad.Visible = false;







        }

        private void btlStart_Click(object sender, EventArgs e)
        {
            Data.ArrNumber = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            FLearnNewWord tabLearnNewWord = new FLearnNewWord(pnlLoad);
            tabLearnNewWord.AutoScroll = true;
            tabLearnNewWord.TopLevel = false;
            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(tabLearnNewWord);

            tabLearnNewWord.FormBorderStyle = FormBorderStyle.None;
            tabLearnNewWord.Show();
            pnlLoad.Visible = true;
        }

        private void pnlLoad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
