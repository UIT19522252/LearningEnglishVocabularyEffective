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
using System.IO;
using System.CodeDom.Compiler;

namespace StartMenu
{
	public partial class Dictionary : Form
	{
        Timer timer1 = new Timer();
        List<string> Meanings;
        WebActivity wa = new WebActivity();
        sqlConnection sql = new sqlConnection();
        List<string> my_list = new List<string>();
        bool isChange = false;
        int index = 1;
        public Dictionary()
		{
			InitializeComponent();
            this.DoubleBuffered = true;
            var acsc = new AutoCompleteStringCollection();
            acsc.AddRange(sql.Suggest("").ToArray());
            tbWord1.AutoCompleteCustomSource = acsc;
            isChange = false;
            this.btMakeFlashCard.Enabled = false;
        }
        public void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
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
            this.rtbMean.Text = "";
            if (File.Exists("temp.mp3"))
            {
                try
                {
                    File.Delete("temp.mp3");
                }
                catch (Exception ev)
                {

                }
            }
            
            if (tbWord.Text == "") return;
            this.lbPronuciation.Visible = false;
            this.btSpeaker.Visible = false;
            Meanings = wa.onlineDictionary(tbWord.Text);
            if (Meanings.Count == 0 || Meanings[0] == "Error")
            {
                AppendText(rtbMean, "Không tìm thấy từ được nhập", Color.Blue);
                this.btMakeFlashCard.Enabled = false;
                return;
            }
            this.btMakeFlashCard.Visible = true;
            if (Meanings[0] != "Null")
            {
                this.lbPronuciation.Text = "Pronuciation: " + Meanings[0];
                this.lbPronuciation.Visible = true;
            }
            if (File.Exists("temp.mp3"))
            {
                this.btSpeaker.Visible = true;
            }

            for (int i = 1; i < Meanings.Count; i++)
            {
                int k = Meanings[i].IndexOf(";");
                if (k == -1) continue;
                string mean = Meanings[i].Substring(0, k);
                string wordformat = Meanings[i].Substring(k + 1, Meanings[i].Length - k - 1);
                AppendText(rtbMean, wordformat + "\n", Color.Blue);
                AppendText(rtbMean, "     " + mean + "\n", Color.Black);
            }
            this.btMakeFlashCard.Enabled = true;
        }
        private void btSpeaker_Click(object sender, EventArgs e)
        {
            
            timer1.Interval = 5000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            WebActivity wa = new WebActivity();
            wa.openAudio("temp.mp3");
            wa.playAudio();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            WebActivity wa = new WebActivity();
            wa.openAudio("temp.mp3");
            wa.stopAudio();
        }
        
        private void btFind1_Click(object sender, EventArgs e)
        {
            this.rtbMean1.Text = sql.Find(this.tbWord1.Text);
        }
        
        private void btDicoffline_Click(object sender, EventArgs e)
        {
            this.pnOfflineDic.Visible = true;
            this.pnOfflineDic.Dock = DockStyle.Fill;
            this.btSpeaker.Visible = false;
            this.lbPronuciation.Visible = false;
        }
        private void btOnlineDictionary_Click(object sender, EventArgs e)
        {
            this.pnOfflineDic.Visible = false;
        }
        private void btMakeFlashCard_Click(object sender, EventArgs e)
        {
            this.pnMakeFlashCard.Visible = true;
            this.pnMakeFlashCard.Dock = DockStyle.Fill;
            this.btSpeaker.Visible = false;
            this.lbPronuciation.Visible = false;
            lbWord.Text = this.tbWord.Text;
            index = 1;
            string m = Meanings[index];
            m = m.Substring(0, m.IndexOf(";"));
            btFlashCard.Text = m;
            this.btMakeFlashCard.Enabled = false;
        }
        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            this.btMakeFlashCard.Enabled = false;
        }
        private void btFlashCard_Click(object sender, EventArgs e)
        {

        }
        private void btChoose_Click(object sender, EventArgs e)
        {
            sql.CustomFlashCard(this.lbWord.Text, this.btFlashCard.Text);
            this.pnMakeFlashCard.Visible=false;
            this.tbWord.Text = "";
            this.btMakeFlashCard.Enabled = false;
            this.rtbMean.Text = "";
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            index += 1;
            if (index == Meanings.Count)
            {
                index = 1;
            }
            string m = Meanings[index];
            m = m.Substring(0, m.IndexOf(";"));
            btFlashCard.Text = m;
        }

        private void tbWord1_TextChanged(object sender, EventArgs e)
        {
            this.rtbMean1.Text = "";
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {

        }

        private void hideMKFL_Click(object sender, EventArgs e)
        {
            this.pnMakeFlashCard.Visible = false;
        }
    }
}
