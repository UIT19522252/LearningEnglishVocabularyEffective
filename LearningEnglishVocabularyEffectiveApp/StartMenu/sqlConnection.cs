using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StartMenu
{
	struct Word
	{
		public string id;
		public string eng;
		public string viet;
		public Word(string a, string b, string c)
		{
			id = a;
			eng = b;
			viet = c;
		}
	};
	class sqlConnection
	{
		String connString = @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
		public string Find(string word)
		{
			string res = "Không tìm thấy từ được nhập";
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select MEAN from VOCABULARY where WORD='" + word + "'";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					res = reader[0].ToString();
				}
			}
			reader.Close();
			connection.Close();
			return res;
		}
		public List<string> Suggest(string word)
		{
			List<string> res = new List<string>();
			res.Add(word);
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD from VOCABULARY where WORD like '" + word + "%'";
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
			return res;
		}
		public void CustomFlashCard(string word, string mean)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "insert into FlashCard (word, mean, userID) values ('" + word + "', N'" + mean + "', 0)";
			//MessageBox.Show(sqlQuery);
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			reader.Close();
			connection.Close();
		}
	}
}
