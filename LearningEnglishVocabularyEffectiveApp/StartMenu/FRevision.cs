using Guna.UI2.HtmlRenderer.Adapters;
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
	public partial class FRevision : Form
	{
		int state = 0, k = 0;
		sqlConnection sql = new sqlConnection();
		List<string> yFWord = new List<string>();
		List<string> yFMean = new List<string>();
		List<string> Eng = new List<string>();
		List<string> Vie = new List<string>();
		List<string> LinkPic = new List<string>();
		List<string> id = new List<string>();
		public FRevision()
		{
			InitializeComponent();
			this.pnYourFlashCard.Visible = false;
			this.DoubleBuffered = true;
			this.pnlLoad.Dock = DockStyle.Fill;
			this.pnCheck.Hide();
			this.pnStatistic.Hide();
			pnYourFlashCard.Hide();
		}
		private void btNext_Click(object sender, EventArgs e)
		{
			if (k < yFWord.Count - 1)
			{
				k++;
			}
			else
			{
				k = 0;
			}
			if (yFWord.Count > 0 && k < yFWord.Count)
			{
				btFlashCard.Text = yFWord[k];
				this.btFlip.Text = yFMean[k];
			}
		}
		private void btBack_Click(object sender, EventArgs e)
		{
			this.pnYourFlashCard.Visible = false;
		}
		private void pnYourFlashCard_Paint(object sender, PaintEventArgs e)
		{

		}
		private void btNope_Click(object sender, EventArgs e)
		{
			sql.ToLearn(id[k]);
			if (k < 10)
			{
				k++;
			}
			else
			{
				this.pnCheck.Visible = false;
			}
			if (Eng.Count > 0)
			{
				btFlashCard2.Text = Eng[k];
				pbImage.Image = null;
				pbImage.LoadAsync(LinkPic[k]);
				btFlip2.Text = Eng[k];
			}
		}
		private void btKnow_Click(object sender, EventArgs e)
		{
			sql.Learned(id[k]);
			if (k < 10)
			{
				k++;
			}
			else
			{
				pnCheck.Visible = false;
			}
			if (Eng.Count > 0)
			{
				btFlashCard2.Text = Eng[k];
				pbImage.Image = null;
				pbImage.LoadAsync(LinkPic[k]);
				btFlip2.Text = Eng[k];
			}
		}
		private void btBack2_Click(object sender, EventArgs e)
		{
			this.pnCheck.Visible = false;
		}
		private void btStatistic_Click(object sender, EventArgs e)
		{
			this.pnCheck.Hide();
			pnYourFlashCard.Hide();
			this.pnStatistic.Visible = true;
			this.pnStatistic.Dock = DockStyle.Fill;
			this.lbUsername.Text ="Username: "+ Data.username;
			this.lbId.Text = "UserID: " + Data.iduser;
			this.lbEmail.Text = "Email: " + sql.FindEmail(Data.username);
			this.lbToLearn.Text = "To Learn: " + sql.countToLearn();
			this.lbLearned.Text = "Learned: " + sql.countLearned();
			pnStatistic.Show();
		}
		private void btBack3_Click(object sender, EventArgs e)
		{
			this.pnStatistic.Visible = false;
		}
        private void btnBack_Click_1(object sender, EventArgs e)
        {
			this.pnCheck.Visible = false;
        }
        private void FRevision_Load(object sender, EventArgs e)
        {
			pnlLoad.Visible = false;
        }
		private void btFlashCard2_Click(object sender, EventArgs e)
		{
			if (state == 0)
			{
				state = 1;
				btFlip2.Text = Eng[k];
			}
			else
			{
				state = 0;
				btFlip2.Text = Vie[k];
			}
		}
		private void pbImage_Click(object sender, EventArgs e)
		{
			if (state == 0)
			{
				state = 1;
				btFlip2.Text = Eng[k];
			}
			else
			{
				state = 0;
				btFlip2.Text = Vie[k];
			}
		}
		private void btFlip2_Click(object sender, EventArgs e)
		{
			if(state==0)
			{
				state = 1;
				btFlip2.Text = Eng[k];
			}
			else
			{
				state = 0;
				btFlip2.Text = Vie[k];
			}	
		}
		private void btLearnNewWord_Click(object sender, EventArgs e)
		{
			if (Data.CheckForInternetConnection())
			{
				this.pnCheck.Hide();
				this.pnStatistic.Hide();
				pnYourFlashCard.Hide();
				FPreviewNewWord tabLearnNewWord = new FPreviewNewWord();
				tabLearnNewWord.AutoScroll = true;
				tabLearnNewWord.TopLevel = false;
				pnlLoad.Controls.Clear();
				pnlLoad.Controls.Add(tabLearnNewWord);

				tabLearnNewWord.FormBorderStyle = FormBorderStyle.None;
				tabLearnNewWord.Show();
				pnlLoad.Visible = true;
			}
			else
            {
				FError f = new FError("Turn on your Internet connection!", "Error");
				f.Show();
			}				
		}
		private void btYourFlashCard_Click(object sender, EventArgs e)
		{
			if (Data.CheckForInternetConnection())
			{
				this.pnCheck.Hide();
				this.pnStatistic.Hide();

				this.pnYourFlashCard.Visible = true;
				this.pnYourFlashCard.Dock = DockStyle.Fill;
				List<List<string>> ls = sql.getOwnFlashCard();
				yFWord = ls[1];
				yFMean = ls[2];
				k = 0;
				if (yFWord.Count > 0)
				{
					btFlashCard.Text = yFWord[k];
					btFlip.Text = yFMean[k];
				}
				pnYourFlashCard.Show();
			}
			else
            {
				FError f = new FError("Turn on your Internet connection!", "Error");
				f.Show();
			}				
		}
		private void btCheck_Click(object sender, EventArgs e)
		{
			if (Data.CheckForInternetConnection())
			{
				this.pnStatistic.Hide();
				this.pnYourFlashCard.Hide();
				this.pnCheck.Dock = DockStyle.Fill;
				this.pnCheck.Visible = true;
				List<List<string>> st = sql.getMeanID();
				Eng = st[0];
				Vie = st[1];
				LinkPic = st[2];
				id = st[3];
				k = 0;
				btFlip2.Text = Eng[k];
				if (st.Count > 0)
				{
					btFlashCard2.Text = Eng[k];
					pbImage.Image = null;
					pbImage.LoadAsync(LinkPic[k]);
					this.btFlip2.Text = Eng[k];
				}
				this.pnCheck.Show();
			}
			else
            {
				FError f = new FError("Turn on your Internet connection!", "Error");
				f.Show();
			}				
		}
	}
}
