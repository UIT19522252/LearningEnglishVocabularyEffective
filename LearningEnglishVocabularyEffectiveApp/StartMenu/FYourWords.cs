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
	public partial class FYourWords : Form
	{
        Timer timer1 = new Timer();
        public FYourWords()
		{
			InitializeComponent();
            this.DoubleBuffered = true;
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
            if (tbxWord.Text == "") return;
            this.lbPronuciation.Visible = false;
            this.btSpeaker.Visible = false;

            WebActivity wa = new WebActivity();
            List<string> Meanings = wa.onlineDictionary(tbxWord.Text);
            if(Meanings.Count == 0 || Meanings[0] == "Error")
            {
                AppendText(rtbMean, "Không tìm thấy từ được nhập", Color.Blue);
                return;
            }
            if (Meanings[0] != "Null")
            {
                this.lbPronuciation.Text = "Pronuciation: " + Meanings[0];
                this.lbPronuciation.Visible = true;
            }
            else
            {
                AppendText(rtbMean, "Không tìm thấy từ được nhập", Color.Blue);
                return;
            }
            if (File.Exists("temp.mp3"))
            {
                this.btSpeaker.Visible = true;
            }   
            
            if(Meanings[0]!="Null")
            {
                this.lbPronuciation.Text = "Pronuciation: " + Meanings[0];
                this.lbPronuciation.Visible = true;
            }    

            for(int i = 1; i < Meanings.Count; i++)
            {
                int k = Meanings[i].IndexOf(";");
                if (k == -1) continue;
                string mean = Meanings[i].Substring(0, k);
                string wordformat = Meanings[i].Substring(k + 1, Meanings[i].Length - k - 1);
                AppendText(rtbMean, wordformat + "\n", Color.Blue);
                AppendText(rtbMean, "     " + mean + "\n", Color.Black);
            }    
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
    }
}
