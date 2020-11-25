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
			string connString = @"Server=LAPTOP-QJ254BVV\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";

			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			string sqlQuery = "select top 5 * from VOCABULARY order by newid()";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				Data.newWord.Add(new Question(reader[0].ToString(), reader[1].ToString()));
			}
			connection.Close();

		}
		public static void addWord()
		{
			if (Data.crrWord.Count == 0)
			{
				Data.crrWord.Add(Data.newWord[0]);
				Data.ArrNumber.Add(0);
				Data.ArrNumber.Add(0);
				Data.ArrNumber.Add(0);
				Data.ArrNumber.Add(0);
				Data.ArrNumber.Add(0);

				Data.crrWord.Add(Data.newWord[1]);
				Data.ArrNumber.Add(1);
				Data.ArrNumber.Add(1);
				Data.ArrNumber.Add(1);
				Data.ArrNumber.Add(1);
				Data.ArrNumber.Add(1);

			}
			else if (Data.crrWord.Count == 2)
			{
				Data.crrWord.Add(Data.newWord[2]);
				Data.ArrNumber.Add(2);
				Data.ArrNumber.Add(2);
				Data.ArrNumber.Add(2);
				Data.ArrNumber.Add(2);
				Data.ArrNumber.Add(2);

				Data.crrWord.Add(Data.newWord[3]);
				Data.ArrNumber.Add(3);
				Data.ArrNumber.Add(3);
				Data.ArrNumber.Add(3);
				Data.ArrNumber.Add(3);
				Data.ArrNumber.Add(3);

			}
			else if (Data.crrWord.Count == 4)
			{
				Data.crrWord.Add(Data.newWord[4]);
				Data.ArrNumber.Add(4);
				Data.ArrNumber.Add(4);
				Data.ArrNumber.Add(4);
				Data.ArrNumber.Add(4);
				Data.ArrNumber.Add(4);
			}

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
