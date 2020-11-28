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
		int width = 620, height = 256;
		int width2 = 620, height2 = 300;
		sqlConnection sql = new sqlConnection();
		List<Word> st = new List<Word>();
		bool signal = true, isflipping = false;
		public FRevision()
		{
			InitializeComponent();
			this.pnYourFlashCard.Visible = false;
			this.btFlashCard.Size = new System.Drawing.Size(width, height);
			if(st.Count>0)
				btFlashCard.Text = st[k].eng;
			timer2.Interval = 1;
			this.DoubleBuffered = true;
		}
        private void btnBack_Click(object sender, EventArgs e)
        {
			this.Close();
		}
		private void btFlip_Click(object sender, EventArgs e)
		{
			if (isflipping == true) return;
			timer1.Interval = 1;
			timer1.Enabled = true;
			isflipping = true;
		}
		private void btNext_Click(object sender, EventArgs e)
		{
			if (k < st.Count - 1)
			{
				k++;
			}
			else
			{
				k = 0;
			}
			if (st.Count > 0 && k < st.Count)
				btFlashCard.Text = st[k].eng;
		}
		private void btFlashCard_Click(object sender, EventArgs e)
		{
			if (st.Count == 0) return;
			if (state == 0)
			{
				state = 1;
				btFlashCard.Text = st[k].viet;
			}
			else
			{
				state = 0;
				btFlashCard.Text = st[k].eng;
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{

			if (signal == true)
			{
				if (width > 0)
				{
					int x = this.btFlashCard.Location.X + 20;
					int y = this.btFlashCard.Location.Y;
					width -= 40;
					this.btFlashCard.Size = new System.Drawing.Size(width, height);
					this.btFlashCard.Location = new System.Drawing.Point(x, y);
				}
				else
				{
					signal = false;
					if (st.Count > 0)
					{
						if (state == 0)
						{
							state = 1;
							btFlashCard.Text = st[k].viet;
						}
						else
						{
							state = 0;
							btFlashCard.Text = st[k].eng;
						}
					}
				}
			}
			else if (signal == false)
			{
				if (width < 620)
				{
					int x = this.btFlashCard.Location.X - 20;
					int y = this.btFlashCard.Location.Y;
					width += 40;
					this.btFlashCard.Size = new System.Drawing.Size(width, height);
					this.btFlashCard.Location = new System.Drawing.Point(x, y);
				}
				else
				{
					width = 620;
					this.btFlashCard.Size = new System.Drawing.Size(width, height);
					this.btFlashCard.Location = new System.Drawing.Point(303, 220);
					signal = true;
					timer1.Enabled = false;
					isflipping = false;
				}
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
			sql.ToLearn(st[k].id);
			if (k < 10)
			{
				k++;
			}
			else
			{
				this.pnCheck.Visible = false;
			}
			if(st.Count>0)
				btFlashCard2.Text = st[k].eng;
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (signal == true)
			{
				if (width2 > 0)
				{
					int x = this.btFlashCard2.Location.X + 20;
					int y = this.btFlashCard2.Location.Y;
					width2 -= 40;
					this.btFlashCard2.Size = new System.Drawing.Size(width2, height2);
					this.btFlashCard2.Location = new System.Drawing.Point(x, y);
				}
				else
				{
					signal = false;
					if (st.Count > 0)
					{
						if (state == 0)
						{
							state = 1;
							btFlashCard2.Text = st[k].viet;
						}
						else
						{
							state = 0;
							btFlashCard2.Text = st[k].eng;
						}
					}
				}
			}
			else if (signal == false)
			{
				if (width2 < 620)
				{
					int x = this.btFlashCard2.Location.X - 20;
					int y = this.btFlashCard2.Location.Y;
					width2 += 40;
					this.btFlashCard2.Size = new System.Drawing.Size(width2, height2);
					this.btFlashCard2.Location = new System.Drawing.Point(x, y);
				}
				else
				{
					width2 = 620;
					this.btFlashCard2.Size = new System.Drawing.Size(width2, height2);
					this.btFlashCard2.Location = new System.Drawing.Point(276, 235);
					signal = true;
					timer2.Enabled = false;
					isflipping = false;
				}
			}
		}

		private void btKnow_Click(object sender, EventArgs e)
		{
			sql.Learned(st[k].id);
			if (k < 10)
			{
				k++;
			}
			else
			{
				pnCheck.Visible = false;
			}
			if(st.Count>0)
				btFlashCard2.Text = st[k].eng;
		}

		private void btBack2_Click(object sender, EventArgs e)
		{
			this.pnCheck.Visible = false;
		}

		private void btFlip2_Click(object sender, EventArgs e)
		{
			isflipping = true;
			timer2.Enabled = true;
		}
		private void btLearnNewWord_Click(object sender, EventArgs e)
		{
			FLearnNewWord f = new FLearnNewWord();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		private void btYourFlashCard_Click(object sender, EventArgs e)
		{
			this.pnYourFlashCard.Visible = true;
			this.pnYourFlashCard.Dock = DockStyle.Fill;
			st = sql.getOwnFlashCard();
			k = 0;
			if (st.Count > 0)
				btFlashCard.Text = st[k].eng;
		}
		private void btCheck_Click(object sender, EventArgs e)
		{
			this.pnCheck.Visible = true;
			this.pnCheck.Dock = DockStyle.Fill;
			st = sql.getWord();
			if (st.Count > 0)
				btFlashCard2.Text = st[k].eng;
		}
	}
}
