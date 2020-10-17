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
		String connString = @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=Data;User Id=sa;Password=1;";
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

			String sqlQuery = "select * from USERINFOR";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				if(reader[1].Equals(a))
				{
					if (HashPassword(b).Equals(reader[2]))
					{
						connection.Close();
						return true;
					}
					else
						return false;
				}	
			}
			connection.Close();
			return false;
		}
		public void Signup(string a, string b)
		{
			if (a.Length < 6 || b.Length < 8)
			{
				FError f = new FError("Password must have more than 7 characters and Username must has more than 5 character", "Message");
				f.ShowDialog();
				return;
			}
			if (findUser(a)==true)
			{
				FError f = new FError("Username were used", "Message");
				f.ShowDialog();
				return;
			}
			SqlConnection connection = new SqlConnection(connString);
			int _id = countUser() + 1;

			try
			{
				string statement = "insert into USERINFOR(id, userName, hashPassword) values(" + "'" + _id.ToString() + "',"
				+ "'" + a + "'," + "'" + HashPassword(b) + "')";
				connection.Open();
				SqlCommand command = new SqlCommand(statement, connection);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				FError f = new FError("Connection or data reader failed", "Error");
				f.ShowDialog();
			}
			finally
			{
				connection.Close();
			}
		}	
		public bool findUser(string a)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			String sqlQuery = "select * from USERINFOR";

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
		public int countUser()
		{
			int count = 0;
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			String sqlQuery = "select * from USERINFOR";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				count++;
			}
			connection.Close();
			return count;
		}
	}
}
