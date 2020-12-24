using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StartMenu
{
	class ConnectionGame
	{
		List<string> Duplicate = new List<string>();
		sqlConnection sql = new sqlConnection();
		WebActivity wa = new WebActivity();
		public int HP;
		public int score;
		public ConnectionGame()
		{
			HP = 3;
			score = 0;
		}
		public string Init()
		{
			string res = sql.getRandomWord();
			while (res.Length <= 2)
			{
				res = sql.getRandomWord();
			}
			Duplicate.Add(res);
			return res;
		}
		private bool FindList(string answer)
		{
			for (int i = 0; i < Duplicate.Count; i++)
			{
				if (Duplicate[i] == answer)
				{
					return true;
				}
			}
			return false;
		}
		public string PotentialAnswer()
		{
			string find = Duplicate[Duplicate.Count - 1];
			string h;
			if ((h=sql.SuggestOne(find, Duplicate))=="abcde")
			{
				return "No Answer";
			}
			else
			{
				return h; 
			}
		}
		public string NewGame()
		{
			Duplicate.Clear();
			string res;
			res = sql.getRandomWord();
			while (res.Length <= 2)
			{
				res = sql.getRandomWord();
			}
			Duplicate.Add(res);
			return res;
		}
		public string NextTurn()
		{
			string find = Duplicate[Duplicate.Count - 1];
			string h;
			if ((h = sql.SuggestOne(find, Duplicate)) == "abcde")
			{
				score += 10;
				return "No Answer";
			}
			else
			{
				Duplicate.Add(h);
				return h;
			}
		}
		public bool CheckAnswer(string question, string answer)
		{
			if (answer.Length < 2) return false;
			if (question.Substring(question.Length - 2) != answer.Substring(0, 2) || FindList(answer) == true)
			{
				HP--;
				return false;
			}
			if (sql.isValidWord(answer) || wa.checkWord(answer) == true)
			{
				score++;
				Duplicate.Add(answer);
				return true;
			}
			else
			{
				HP--;
				return false;
			}
		}
		public string Decription(string word)
		{
			string res=sql.Decription(word);
			return res;
		}	
		public string getLinkPic(string word)
		{
			return sql.getLinkPic(word);
		}
		public void AllOver()
		{
			string path = "HighScore.txt";
			if (!File.Exists(path))
			{
				using (StreamWriter sw = File.CreateText(path))
				{ 
				}
			}
			using (StreamWriter sw = File.AppendText(path))
			{
				sw.WriteLine(score);
				score = 0;
			}
		}
	}
}
