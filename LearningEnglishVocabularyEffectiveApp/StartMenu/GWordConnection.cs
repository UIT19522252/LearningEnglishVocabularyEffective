using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace StartMenu
{
	public partial class GWordConnection : Form
	{
		static List<int> ls = new List<int> { 5, 15, 25, 45, 95, 205 };
		ConnectionGame game = new ConnectionGame();
		List<string> UsedWord = new List<string>();
		sqlConnection sql = new sqlConnection();
		WebActivity wa = new WebActivity();
		public GWordConnection()
		{
			InitializeComponent();
			this.pbWord.SizeMode = PictureBoxSizeMode.Zoom;
			this.rtbNPC.Text = game.Init();
			richTextBox1.Text = this.rtbNPC.Text + "\n";
			this.rtbDecription.Text = game.Decription(this.rtbNPC.Text);
			pbWord.InitialImage = null;
			this.pbWord.LoadAsync(game.getLinkPic(this.rtbNPC.Text));
			this.lbSeq.Text = this.rtbNPC.Text.Substring(this.rtbNPC.Text.Length - 2);
			Control.CheckForIllegalCrossThreadCalls = false;
		}
		private void GameOver()
		{
			MessageBox.Show("Thua rồi nhé hihi", "GameOver");
			game.AllOver();
			ShowDuplicated();
			game = new ConnectionGame();
			foreach (Control x in this.Controls)
			{
				if (x is TextBox)
				{
					((TextBox)x).Text = "";
				}
				else if (x is PictureBox)
				{
					((PictureBox)x).Image = null;
					x.Visible = true;
				}
				else if (x is RichTextBox)
				{
					((RichTextBox)x).Text = "";
				}
			}
			this.rtbNPC.Text = game.Init();
			richTextBox1.Text = this.rtbNPC.Text + "\n";
			this.rtbDecription.Text = game.Decription(this.rtbNPC.Text);
			pbWord.InitialImage = null;
			this.pbWord.LoadAsync(game.getLinkPic(this.rtbNPC.Text));
			this.lbSeq.Text = this.rtbNPC.Text.Substring(this.rtbNPC.Text.Length - 2);
		}
		private void Lose()
		{
			if (game.HP == 2)
			{
				pictureBox3.Visible = false;
			}
			else if (game.HP == 1)
			{
				pictureBox2.Visible = false;
			}
			else if (game.HP == 0)
			{
				pictureBox1.Visible = false;
			}
			else if (game.HP == -1)
			{
				string ans;
				if ((ans = game.PotentialAnswer()) != "No Answer")
				{
					this.rtbWord.Text = ans;
					this.pnNotification.Dock = DockStyle.Fill;
					this.lbMessage.Text = "Thua rồi nha con, Đáp án nè";
					this.rtbDecrip.Text = LoadDecrip(ans);
					this.pnNotification.Visible = true;
				}
				else
					MessageBox.Show("Tôi cũng không tìm thấy đáp án", "Solution");
				GameOver();
				return;
			}
			this.lbScore.Text = "Score: " + game.score;
			tbPlayer.Text = "";
			string res;
			if ((res = game.PotentialAnswer()) != "No Answer")
			{
				this.rtbWord.Text = res;
				this.pnNotification.Dock = DockStyle.Fill;
				this.lbMessage.Text = "Bạn thua rồi, đáp án là: ";
				this.rtbDecrip.Text = LoadDecrip(res);
				this.pnNotification.Visible = true;
			}
			else
				MessageBox.Show("Tôi cũng không tìm thấy đáp án", "Solution");
			this.rtbNPC.Text = game.NewGame();
			this.rtbDecription.Text = game.Decription(this.rtbNPC.Text);
			pbWord.Image = null;
			this.pbWord.LoadAsync(game.getLinkPic(this.rtbNPC.Text));
			this.lbSeq.Text = this.rtbNPC.Text.Substring(this.rtbNPC.Text.Length - 2);
			richTextBox1.Text = "";
		}
		public string LoadDecrip(string word)
		{
			string des = "";
			if ((des = sql.Decription(word)) != "")
			{
				return des;
			}
			//Khi mạng mạnh sẽ tiếp tục
			try
			{
				des += "WORD: " + word + "\n";
				string h = wa.getSource("https://dictionary.cambridge.org/vi/dictionary/english-vietnamese/" + word);
				if (h.IndexOf("lp-m_l-25") != -1) return "";
				h = h.Substring(h.IndexOf("ti tb") + 7);
				string type = h.Substring(0, h.IndexOf("<"));
				des += "Classifier: " + type + "\n";
				h = h.Substring(h.IndexOf("ipa dipa") + 10);
				string pro = h.Substring(0, h.IndexOf("<"));
				des += "Pronuciation: " + pro + "\n";
				int ki;
				if ((ki = h.IndexOf("trans dtrans")) != -1)
				{
					h = h.Substring(ki);
					h = h.Substring(h.IndexOf(">") + 1);
					string VI = h.Substring(0, h.IndexOf("<"));
					des += "Means: " + VI + "\n";
				}
				h = h.Substring(h.IndexOf("eg deg") + 8);
				string etc = h.Substring(0, h.IndexOf("</div>"));
				while (etc.IndexOf("<") != -1)
				{
					string k = etc.Substring(etc.IndexOf("<"), etc.IndexOf(">") - etc.IndexOf("<") + 1);
					etc = etc.Replace(k, "");
				}
				des += "Example: " + etc + "\n";
			}
			catch (Exception ex)
			{

			}
			return des;
		}
		private void Correct()
		{
			this.rtbWord.Text = this.tbPlayer.Text;
			this.pnNotification.Dock = DockStyle.Fill;
			this.lbMessage.Text = "Bạn giỏi quá";
			this.rtbDecrip.Text = LoadDecrip(this.tbPlayer.Text);
			this.pnNotification.Visible = true;

			Level();
			this.lbScore.Text = "Score: " + game.score;
			richTextBox1.Text += tbPlayer.Text + "\n";
			this.rtbNPC.Text = game.NextTurn();
			if (this.rtbNPC.Text == "No Answer")
			{
				tbPlayer.Text = "";
				NPCLose();
				return;
			}
			richTextBox1.Text += this.rtbNPC.Text + "\n";
			this.rtbDecription.Text = game.Decription(this.rtbNPC.Text);
			pbWord.Image = null;
			this.pbWord.LoadAsync(game.getLinkPic(this.rtbNPC.Text));
			this.lbSeq.Text = this.rtbNPC.Text.Substring(this.rtbNPC.Text.Length - 2);
			tbPlayer.Text = "";
		}
		private void NPCLose()
		{
			this.pnNotification.Dock = DockStyle.Fill;
			this.lbMessage.Text = "Bái phục, các hạ thắng rồi";
			this.pnNotification.Visible = true;
			this.lbScore.Text = "Score: " + game.score;
			tbPlayer.Text = "";
			this.rtbNPC.Text = game.NewGame();
			this.rtbDecription.Text = game.Decription(this.rtbNPC.Text);
			pbWord.Image = null;
			this.pbWord.LoadAsync(game.getLinkPic(this.rtbNPC.Text));
			this.lbSeq.Text = this.rtbNPC.Text.Substring(this.rtbNPC.Text.Length - 2);
			this.richTextBox1.Text = this.rtbNPC.Text + "\n";
		}
		private void btSubmit_Click(object sender, EventArgs e)
		{
			if (tbPlayer.Text.Length < 2) return;
			//Check xem đã nối đúng chưa
			string NPC = rtbNPC.Text;
			string Player = tbPlayer.Text;
			if (game.CheckAnswer(NPC, Player) == true)
			{
				Correct();
				UsedWord.Add(Player);
			}
			else
			{
				Lose();
			}
		}
		private void btNewGame_Click(object sender, EventArgs e)
		{
			Thread th = new Thread(GameOver1);
			th.IsBackground = true;
			th.Start();
		}
		private void GameOver1()
		{
			DialogResult dialogResult = MessageBox.Show("Your are playing, Sure to leave??",
				"Message", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{

			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}
			game.AllOver();
			ShowDuplicated();
			game = new ConnectionGame();
			foreach (Control x in this.Controls)
			{
				if (x is TextBox)
				{
					((TextBox)x).Text = "";
				}
				else if (x is PictureBox)
				{
					((PictureBox)x).Image = null;
					x.Visible = true;
				}
				else if (x is RichTextBox)
				{
					((RichTextBox)x).Text = "";
				}
			}
			this.lbScore.Text = "Score: " + 0;
			this.rtbNPC.Text = game.Init();
			richTextBox1.Text = this.rtbNPC.Text + "\n";
			this.rtbDecription.Text = game.Decription(this.rtbNPC.Text);
			pbWord.InitialImage = null;
			this.pbWord.LoadAsync(game.getLinkPic(this.rtbNPC.Text));
			this.lbSeq.Text = this.rtbNPC.Text.Substring(this.rtbNPC.Text.Length - 2);
		}
		private void btHighScore_Click(object sender, EventArgs e)
		{
			string data = "";
			string line;
			if(File.Exists("HighScore.txt")==false)
			{
				return;
			}	
			StreamReader file = new StreamReader("HighScore.txt");
			while ((line = file.ReadLine()) != null)
			{
				data += line + "\n";
			}
			file.Close();
			MessageBox.Show(data, "High Score");
		}
		private void Level()
		{
			int index = 0;
			int score = game.score;
			while (score > ls[index] && index < ls.Count)
			{
				score -= ls[index];
				index++;
			}
			this.lbLevel.Text = "Level " + index;
			int value = (int)(score * 100.0 / ls[index]);
			if (value > 100) value = 100;
			this.pgbLevel.Value = value;
		}
		private void ShowDuplicated()
		{
			string data = UsedWord.Count / 2 + " từ đã dùng: " + "\n";
			for (int i = 0; i < UsedWord.Count / 2; i++)
			{
				data += UsedWord[2 * i + 1] + "\n";
			}
			MessageBox.Show(data);
			UsedWord.Clear();
		}
		private void btOK_Click(object sender, EventArgs e)
		{
			this.pnNotification.Visible = false;
		}
	}
}
