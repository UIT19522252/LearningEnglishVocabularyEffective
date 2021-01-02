using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Policy;
using System.Security.AccessControl;

namespace StartMenu
{
	class sqlConnection
	{
		String connString = Data.ConnString;
		WebActivity wa = new WebActivity();
		public List<string> Suggest(string word)
		{
			List<string> res = new List<string>();
			res.Add(word);
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD,MEAN from VOCABULARY where WORD like '" + word + "%'";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					if(reader[0].ToString().IndexOf("?")==-1)
						res.Add(reader[0].ToString());
					if (reader[1].ToString().IndexOf("?") == -1)
						res.Add(reader[1].ToString());
				}
			}
			reader.Close();
			connection.Close();
			return res;
		}
		public void CustomFlashCard(string word, string mean)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "insert into FlashCard (word, mean, userID) values ('" + word + "', N'" + mean + "'," + Data.iduser + ")";
			//MessageBox.Show(sqlQuery);
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			reader.Close();
			connection.Close();
		}
		public void Learned(string word_id)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "insert into Learned (id_word, id_user) values (" + word_id + "," + Data.iduser + ")";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			reader.Close();
			connection.Close();
		}
		public void ToLearn(string word_id)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "insert into ToLearn (id_word, id_user) values (" + word_id + "," + Data.iduser + ")";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			reader.Close();
			connection.Close();
		}
		public int countLearned()
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			string sqlQuery = "select count(*) as dem from Learned where id_user=" + Data.iduser;
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					int k = int.Parse(reader[0].ToString());
					reader.Close();
					return k;
				}
			}
			reader.Close();
			return -1;
		}
		public string getLearned()
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			string res = "";
			int k = 1;
			string sqlQuery = "select WORD +' : ' + MEAN+' (Ex: ' + EXAMPLE+')' from VOCABULARY v join Learned l on v.id=l.id_word and id_user=" + Data.iduser;
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					res+=k+". "+reader[0].ToString()+"\n";
					k++;
				}
			}
			reader.Close();
			return res;
		}
		public List<List<string>> getOwnFlashCard()
		{
			List<List<string>> ls = new List<List<string>>();
			List<string> id = new List<string>();
			List<string> word = new List<string>();
			List<string> mean = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select f.id, f.word, f.mean from FlashCard f where f.userID =" + Data.iduser + "order by f.id";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				{
					id.Add(reader[0].ToString());
					word.Add(reader[1].ToString());
					mean.Add(reader[2].ToString());
				}
			}
			ls.Add(id);
			ls.Add(word);
			ls.Add(mean);
			reader.Close();
			connection.Close();
			return ls;
		}
		public string FindEmail(string a)
		{
			string Email = "Null";
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			String sqlQuery = "select email from USERINFO where username='" + a + "'";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					Email = reader[0].ToString();
					reader.Close();
					connection.Close();
					return Email;
				}
			}
			connection.Close();
			return Email;
		}
		public string getRandomWord()
		{
			List<string> res = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD from VOCABULARY order by newid()";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					string newWord = reader[0].ToString();
					if (newWord.Length < 2) continue;
					if (canConnect(newWord.Substring(newWord.Length - 2), new List<string>()))
					{
						res.Add(newWord);
						break;
					}
				}
			}
			reader.Close();
			connection.Close();
			return res[0];
		}
		public bool isValidWord(string word)
		{
			List<string> res = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD from VOCABULARY where WORD = '" + word + "'";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					res.Add(reader[0].ToString());
				}
			}
			reader.Close();
			connection.Close();
			if (res.Count == 0) return false;
			else return true;
		}
		public bool canConnect(string word, List<string> DuplicateList)
		{
			List<string> res = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD from VOCABULARY where WORD like '" + word + "%' order by NEWID()";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					string newWord = reader[0].ToString();
					if (FindList(newWord, DuplicateList) == false && wa.checkWord(word) == true)
					{
						res.Add(newWord);
						break;
					}
				}
			}
			reader.Close();
			connection.Close();
			if (res.Count == 0) return false;
			return true;
		}
		public string SuggestOne(string word, List<string> DuplicateList)
		{
			word = word.Substring(word.Length - 2);
			List<string> res = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD from VOCABULARY where WORD like '" + word + "%' order by NEWID()";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					string newWord = reader[0].ToString();
					if (newWord.Length < 2) continue;
					if (canConnect(newWord.Substring(newWord.Length - 2), DuplicateList))//&& FindList(newWord, DuplicateList)==false)
					{
						res.Add(newWord);
						break;
					}
				}
			}
			reader.Close();
			connection.Close();
			if (res.Count == 0) return "abcde";
			return res[0];
		}
		public bool FindList(string word, List<string> Duplicate)
		{
			for (int i = 0; i < Duplicate.Count; i++)
			{
				if (Duplicate[i].Equals(word))
				{
					return true;
				}
			}
			return false;
		}
		public string Decription(string word)
		{
			string res = "";
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD, WORDTYPE, MEAN, EXAMPLE,PRONUN from" +
				" VOCABULARY where WORD = '" + word + "'" ;
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					res += "Word: " + reader[0].ToString() + "\n";
					res += "Classifier: " + reader[1].ToString() + "\n";
					res += "Means: " + reader[2].ToString() + "\n";
					res += "Example: " + reader[3].ToString() + "\n";
					if(reader[4].ToString()!="")
					res += "Pronuciation: " + reader[4].ToString() + "\n";
					break;
				}
			}
			reader.Close();
			connection.Close();
			return res;
		}
		public string Decription2(string word)
		{
			string res = "";
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD, WORDTYPE, MEAN, EXAMPLE,PRONUN from" +
				" VOCABULARY where WORD = '" + word + "'";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					res += "Word: " + reader[0].ToString() + "\n";
					res += "Classifier: " + reader[1].ToString() + "\n";
					res += "Means: " + reader[2].ToString() + "\n";
					res += "Example: " + reader[3].ToString() + "\n";
					if (reader[4].ToString() != "")
						res += "Pronuciation: " + reader[4].ToString() + "\n";
					break;
				}
			}
			reader.Close();
			if (res=="")
			{
				sqlQuery = "select WORD, WORDTYPE, MEAN, EXAMPLE,PRONUN from" +
				" VOCABULARY where MEAN = N'" + word + "'";
				command = new SqlCommand(sqlQuery, connection);
				reader = command.ExecuteReader();
				while (reader.HasRows)
				{
					if (reader.Read() == false) break;
					else
					{
						res += "Word: " + reader[0].ToString() + "\n";
						res += "Classifier: " + reader[1].ToString() + "\n";
						res += "Means: " + reader[2].ToString() + "\n";
						res += "Example: " + reader[3].ToString() + "\n";
						if (reader[4].ToString() != "")
							res += "Pronuciation: " + reader[4].ToString() + "\n";
						break;
					}
				}
			}
			connection.Close();
			return res;
		}
		public string getLinkPic(string word)
		{
			string res = "";
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select LINKPIC from" +
				" VOCABULARY where WORD = '" + word + "'";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					res = reader[0].ToString();
					break;
				}
			}
			reader.Close();
			connection.Close();
			return res;
		}
		public List<string> GetAllType()
		{
			List<string> AllType = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select TENLOAI from LOAI";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					AllType.Add(reader[0].ToString());
				}
			}
			reader.Close();
			connection.Close();
			return AllType;
		}
		public List<List<string>> getMean(int type)
		{
			List<List<string>> ls = new List<List<string>>();
			List<string> WORD = new List<string>();
			List<string> MEAN = new List<string>();
			List<string> LINKPIC = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD, MEAN, LINKPIC from VOCABULARY where MALOAI=" + type;
			//MessageBox.Show(sqlQuery);
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					WORD.Add(reader[0].ToString());
					MEAN.Add(reader[1].ToString());
					LINKPIC.Add(reader[2].ToString());
				}
			}
			ls.Add(WORD);
			ls.Add(MEAN);
			ls.Add(LINKPIC);
			reader.Close();
			connection.Close();
			return ls;
		}
		public List<List<string>> getMeanID()
		{
			List<List<string>> ls = new List<List<string>>();
			List<string> WORD = new List<string>();
			List<string> MEAN = new List<string>();
			List<string> LINKPIC = new List<string>();
			List<string> ID = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD, MEAN, LINKPIC, ID from VOCABULARY v where v.id not in (select id_word from Learned l where l.id_user = " + Data.iduser + ") and v.id not in (select id_word from ToLearn t where t.id_user = " + Data.iduser + ") order by v.id";
			//MessageBox.Show(sqlQuery);
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					WORD.Add(reader[0].ToString());
					MEAN.Add(reader[1].ToString());
					LINKPIC.Add(reader[2].ToString());
					ID.Add(reader[3].ToString());
				}
			}
			ls.Add(WORD);
			ls.Add(MEAN);
			ls.Add(LINKPIC);
			ls.Add(ID);
			reader.Close();
			connection.Close();
			return ls;
		}
	}
}
