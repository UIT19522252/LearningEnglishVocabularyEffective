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
        bool isEng = true;
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
               btFind_Click(sender, e);
        }
        private void btnAddWord_Click(object sender, EventArgs e)
        {

        }
        private void btFind_Click(object sender, EventArgs e)
        {
            this.rtbMean.Text = "";    
            if (tbWord.Text == "") return;
            this.lbPronuciation.Visible = false;
            this.btSpeaker.Visible = false;

            string mean;
            if (isEng == true)
                mean = wa.onlineDict(tbWord.Text);
            else
                mean = wa.VieToEng(tbWord.Text);
            if (mean == "")
            {
                this.rtbMean.Text = "Không tìm thấy từ được nhập";
                return;
            }
            this.btSpeaker.Visible = true;
            this.rtbMean.Text = mean;
            if(mean.IndexOf("Means: ")==-1)
            {
                return;
            }    
            this.btMakeFlashCard.Visible = true;
            this.btMakeFlashCard.Enabled = true;
        }
        private void btSpeaker_Click(object sender, EventArgs e)
        {
            if(this.pnOfflineDic.Visible == true)
                Data.voice.Read(tbWord1.Text);
            else
                Data.voice.Read(tbWord.Text);
        }
        private void btFind1_Click(object sender, EventArgs e)
        {
            this.rtbMean1.Text = sql.Decription2(this.tbWord1.Text);
            if (this.rtbMean1.Text == "")
            {
                this.rtbMean1.Text = "Không tìm thấy từ được nhập";
            }
            else this.btspeaker2.Visible = true;
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
            this.btSpeaker.Visible = false;
        }
        private void btMakeFlashCard_Click(object sender, EventArgs e)
        {
            this.pnMakeFlashCard.Visible = true;
            this.pnMakeFlashCard.Dock = DockStyle.Fill;
            this.btSpeaker.Visible = false;
            this.lbPronuciation.Visible = false;
            lbWord.Text = this.tbWord.Text;
            //index = 1;
            //string m = ;
            //m = m.Substring(0, m.IndexOf(";"));
            string m = this.rtbMean.Text;
            m = m.Substring(m.IndexOf("Means: ") + 7);
            m = m.Substring(0, m.IndexOf("E"));
            btFlashCard.Text = m;
            this.btMakeFlashCard.Enabled = false;
        }
        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            this.btMakeFlashCard.Enabled = false;
        }
        private void btChoose_Click(object sender, EventArgs e)
        {
            sql.CustomFlashCard(this.lbWord.Text, this.btFlashCard.Text);
            this.pnMakeFlashCard.Visible=false;
            this.tbWord.Text = "";
            this.btMakeFlashCard.Enabled = false;
            this.rtbMean.Text = "";
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

        private void btspeaker2_Click(object sender, EventArgs e)
        {
            if (this.pnOfflineDic.Visible == true)
                Data.voice.Read(tbWord1.Text);
            else
                Data.voice.Read(tbWord.Text);
        }

        private void tbWord1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btFind1_Click(sender, e);
            }
        }

        private void swRemember_Login_CheckedChanged(object sender, EventArgs e)
        {
            if(isEng==true)
            {
                isEng = false;
                this.lblLanguge.Text = "Vietnamese to English";
            }    
            else
            {
                isEng = true;
                this.lblLanguge.Text = "English to Vietnamese";
            }                
        }
    }
}
