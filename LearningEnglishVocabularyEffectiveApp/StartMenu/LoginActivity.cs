using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace StartMenu
{
	class LoginActivity
	{
		String connString = @"Server=LAPTOP-QJ254BVV\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
		static string HashPassword(string rawData)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
		public bool checkUser(string a, string b)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			String sqlQuery = "select * from USERINFO where username='"+ a+"'";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				if (HashPassword(b).Equals(reader[2]))
				{
					connection.Close();
					return true;
				}
				else
					return false;
			}
			connection.Close();
			return false;
		}
		public bool Signup(string a, string b)
		{
			if (a.Length < 6 || b.Length < 8)
			{
				FError f = new FError("Password must have more than 7 characters and Username must has more than 5 character", "Message");
				f.StartPosition = FormStartPosition.CenterScreen;
				f.ShowDialog();
				return false;
			}
			if (findUser(a)==true)
			{
				FError f = new FError("Username were used", "Message");
				f.StartPosition = FormStartPosition.CenterScreen;
				f.ShowDialog();
				return false;
			}
			SqlConnection connection = new SqlConnection(connString);
			try
			{
				string statement = "insert into USERINFO(username, hashPass) values ("
					+ "'" + a + "'," + "'" + HashPassword(b) + "')";
				connection.Open();
				SqlCommand command = new SqlCommand(statement, connection);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				FError f = new FError("Connection or data reader failed", "Error");
				f.StartPosition = FormStartPosition.CenterScreen;
				f.ShowDialog();
				return false;
			}
			finally
			{
				connection.Close();
			}
			return true;
		}	
		public bool findUser(string a)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			String sqlQuery = "select * from USERINFO where username='"+a+"'";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				if (reader[1].Equals(a))
				{
					connection.Close();
					return true;
				}
			}
			connection.Close();
			return false;
		}
		public int FindID(string a)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			String sqlQuery = "select * from USERINFO where username='" + a + "'";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					int k = int.Parse(reader[0].ToString());
					reader.Close();
					connection.Close();
					return k;
				}	
			}
			connection.Close();
			return -1;
		}
		
	}
}
