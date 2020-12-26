using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace StartMenu
{
	public static class BackEnd
	{



		public static void LoadData()
		{
			string connString = Data.ConnString;

			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			string sqlQuery = @"select top 5 * from VOCABULARY x where x.id not in ( select id_word from Learned l where l.id_user =" + Data.iduser + " )  order by newid()"; 

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				Data.newWord.Add(new Question(reader[1].ToString(), reader[3].ToString()));
				Data.id.Add(reader[0].ToString());
			}
			connection.Close();

		}
		public static void addWord()
		{
			Data.crrWord.Add(Data.newWord[4]);
			Data.crrWord.Add(Data.newWord[3]);
			Data.crrWord.Add(Data.newWord[2]);
			Data.crrWord.Add(Data.newWord[1]);
			Data.crrWord.Add(Data.newWord[0]);
		}
		public static int getQuestion()
		{
			int n = 0, num = 0;
			if (Data.ArrNumber.Count == 1) n = Data.ArrNumber[0];
			else
			if (Data.ArrNumber.Count == 0) return -1;
			else
			{
				Random r = new Random();
				num = r.Next(0, Data.ArrNumber.Count);
				n = Data.ArrNumber[num];
			}
			Data.ArrNumber.RemoveAt(num);
			return n;
		}
		public static bool checkRightAnswer()
		{
			return true;
		}
	}
}
