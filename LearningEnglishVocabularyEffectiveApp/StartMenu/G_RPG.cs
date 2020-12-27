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

namespace StartMenu
{
	public partial class G_RPG : Form
	{
		sqlConnection sql = new sqlConnection();
		public G_RPG()
		{
			InitializeComponent();
			LoadInit();
			Type = sql.GetAllType();
			cbbType.DataSource = Type;
			FormLoad();
			RandomToLearn();
			this.cbbType.SelectedIndex = 0;
			cbbType.MaxDropDownItems = 2;
			this.lbPage.Text = currentIndex + "/" + (Words.Count / 3 - 1);
		}
		List<string> Type = new List<string>();
		List<RichTextBox> Mean = new List<RichTextBox>();
		List<TextBox> Word = new List<TextBox>();
		List<PictureBox> Pic = new List<PictureBox>();
		List<string> Means = new List<string>();
		List<string> Words = new List<string>();
		List<string> LinkPic = new List<string>();
		Random r = new Random();
		int currentIndex = 0;
		public void LoadInit()
		{
			Mean.Add(richTextBox1);
			Mean.Add(richTextBox2);
			Mean.Add(richTextBox3);
			Word.Add(textBox1);
			Word.Add(textBox2);
			Word.Add(textBox3);
			Pic.Add(pictureBox1);
			Pic.Add(pictureBox2);
			Pic.Add(pictureBox3);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
		}
		void FormLoad()
		{
			List<List<string>> ls = sql.getMean(this.cbbType.SelectedIndex);
			Words = ls[0];
			Means = ls[1];
			LinkPic = ls[2];
		}
		List<int> answer = new List<int>();
		public void RandomToLearn()
		{
			for (int i = 0; i < 3; i++)
			{
				Pic[i].Image = null;
				Pic[i].LoadAsync(LinkPic[currentIndex * 3 + i]);
				Mean[i].Text = Means[currentIndex * 3 + i];
				Word[i].Text = Words[currentIndex * 3 + i];
			}
		}

		private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			currentIndex = 0;
			Data.type = this.cbbType.SelectedIndex;
			FormLoad();
			RandomToLearn();
			this.lbPage.Text = currentIndex + "/" + (Words.Count / 3 - 1);
		}

        private void btnGame_Click(object sender, EventArgs e)
        {
			G_RPG_2 game = new G_RPG_2(Words, Means,LinkPic);
			game.AutoScroll = true;
			game.TopLevel = false;
			pnlLoad.Controls.Clear();
			pnlLoad.Controls.Add(game);

			game.FormBorderStyle = FormBorderStyle.None;
			game.Show();
			pnlLoad.Dock = DockStyle.Fill;
			pnlLoad.Visible = true;
		}

        private void btnNext_Click(object sender, EventArgs e)
        {
			currentIndex++;
			if (currentIndex * 3 + 3 >= Words.Count)
			{
				currentIndex = 0;
			}
			RandomToLearn();
			this.lbPage.Text = currentIndex + "/" + (Words.Count / 3 - 1);
		}

        private void btnHighScore_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
			currentIndex--;
			if (currentIndex <= 0)
			{
				currentIndex = Words.Count / 3 - 1;
			}
			RandomToLearn();
			this.lbPage.Text = currentIndex + "/" + (Words.Count / 3 - 1);
		}
    }
}
