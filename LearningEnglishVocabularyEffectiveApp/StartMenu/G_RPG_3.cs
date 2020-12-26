using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace StartMenu
{
	public partial class G_RPG_3 : Form
	{
		public G_RPG_3()
		{
			InitializeComponent();
		}
		List<string> Means = new List<string>();
		List<string> Words = new List<string>();
		List<PictureBox> pbList = new List<PictureBox>();
		List<TextBox> tbList = new List<TextBox>();
		List<int> answer = new List<int>();
		Random r = new Random();
		Point MouseLocation = new Point();
		bool isStart = true;
		Point tempPoint = new Point();
		List<Button> conPoint = new List<Button>();
		List<Point> start = new List<Point>();
		List<Point> end = new List<Point>();
		Pen tempPen;
		List<int> Seq = new List<int>();
		public G_RPG_3(List<string> _Words, List<string> _Means)
		{
			InitializeComponent();
			pbList.Add(pictureBox1);
			pbList.Add(pictureBox2);
			pbList.Add(pictureBox3);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			tbList.Add(textBox1);
			tbList.Add(textBox2);
			tbList.Add(textBox3);
			conPoint.Add(button1);
			conPoint.Add(button2);
			conPoint.Add(button3);
			conPoint.Add(button4);
			conPoint.Add(button5);
			conPoint.Add(button6);
			this.DoubleBuffered = true;
			AddEventClick();
			Newgame(_Words, _Means);
			InitPen();
		}
		void Newgame(List<string> _Words, List<string> _Means)
		{
			Words = new List<string>(_Words);
			Means = new List<string>(_Means);
			AddToRichTextBox();
			AddToTextBox();
			AddEventClick();
		}
		void AddEventClick()
		{
			for (int i = 0; i < conPoint.Count; i++)
			{
				conPoint[i].Click += new System.EventHandler(Connect);
			}
		}
		private void Connect(object sender, EventArgs e)
		{
			int index = conPoint.IndexOf(((Button)(sender)));
			if (end.Count == 3)
			{

				return;
			}

			Point point = new Point(((Button)sender).Location.X + ((Button)sender).Size.Width / 2,
				((Button)sender).Location.Y + ((Button)sender).Size.Height / 2);
			if (index > 2 && isStart == true) return;
			if (index <= 2 && isStart == false) return;
			if (isStart == true)
			{
				start.Add(point);
				Seq.Add(index);
				tempPoint = MouseLocation;
			}
			else
			{
				Seq.Add(index);
				end.Add(point);
				if (end.Count == 3)
				{
					this.btSubmit.Enabled = true;
				}
			}
			((Button)(sender)).Click -= Connect;
			isStart = !isStart;
			this.Invalidate();
		}
		void AddToRichTextBox()
		{
			answer.Clear();
			for (int i = 0; i < 3; i++)
			{
				int k = r.Next(0, Means.Count);
				while (answer.IndexOf(k) != -1)
				{
					k = r.Next(0, Means.Count);
				}
				answer.Add(k);
				this.pbList[i].LoadAsync(Means[k]);
			}
		}
		void AddToTextBox()
		{
			List<int> ran = new List<int>();
			for (int i = 0; i < 3; i++)
			{
				int k = r.Next(0, answer.Count);
				while (ran.IndexOf(answer[k]) != -1)
				{
					k = r.Next(0, answer.Count);
				}
				ran.Add(answer[k]);
				this.tbList[i].Text = Words[answer[k]];
			}
		}
		private void button7_Click(object sender, EventArgs e)
		{

		}
		private void InitPen()
		{
			tempPen = new Pen(Color.DarkBlue);
			tempPen.Width = 4;
			tempPen.StartCap = LineCap.NoAnchor;
			tempPen.EndCap = LineCap.NoAnchor;
			tempPen.DashStyle = DashStyle.Solid;
		}
		private void NormalStage2_Paint(object sender, PaintEventArgs e)
		{
			
		}
		private void Submit(object sender, EventArgs e)
		{
			
		}
		private void btNewGame_Click(object sender, EventArgs e)
		{
			Newgame(Words, Means);
			start.Clear();
			end.Clear();
			Seq.Clear();
			this.Invalidate();
			this.HPBoss.Value = 100;
			this.HPPlayer.Value = 100;
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			if (answer[Seq[0]] == Words.IndexOf(tbList[Seq[1] % 3].Text)
				&& answer[Seq[2]] == Words.IndexOf(tbList[Seq[3] % 3].Text)
				&& answer[Seq[4]] == Words.IndexOf(tbList[Seq[5] % 3].Text))
			{
				MessageBox.Show("Đúng rồi");
				this.HPBoss.Value -= 10;
				if (this.HPBoss.Value == 0)
				{
					MessageBox.Show("Boss was defeated");
					string[] arrLine = File.ReadAllLines("HighScore2.txt");
					string linetype = arrLine[Data.type];
					int time = int.Parse(linetype.Substring(linetype.IndexOf(": ") + 2));
					time++;
					arrLine[Data.type] = "[" + Data.type + "]: " + time;
					File.WriteAllLines("HighScore2.txt", arrLine);
					this.Close();
				}
				Newgame(Words, Means);
				start.Clear();
				end.Clear();
				Seq.Clear();
				this.Invalidate();
			}
			else
			{
				MessageBox.Show("Sai cmnr");
				start.Clear();
				end.Clear();
				isStart = true;
				AddEventClick();
				this.Invalidate();
			}
		}

		private void G_RPG_3_MouseMove(object sender, MouseEventArgs e)
		{
			MouseLocation = e.Location;
			if (isStart == false)
			{
				tempPoint = MouseLocation;
				this.Invalidate();
			}
		}

		private void G_RPG_3_Paint(object sender, PaintEventArgs e)
		{
			for (int i = 0; i < start.Count && i < end.Count; i++)
			{
				e.Graphics.DrawLine(tempPen, start[i], end[i]);
			}
			if (isStart == false)
			{
				e.Graphics.DrawLine(tempPen, start[start.Count - 1], tempPoint);
			}
		}
	}
}
