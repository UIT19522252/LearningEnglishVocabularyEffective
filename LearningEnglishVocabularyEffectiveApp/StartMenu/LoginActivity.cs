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
				if(reader[1]==a)
				{
					if(HashPassword(b)==reader[2])
					{
						connection.Close();
						return true;
					}						
				}	
			}
			connection.Close();
			return false;
		}
		public void Signup(string a, string b)
		{
			if (a.Length < 6 || b.Length < 8)
			{
				MessageBox.Show("Password must have more than 7 characters and Username must has more than 5 character  ", "Message");
				return;
			}
			if (findUser(a)==true)
			{
				MessageBox.Show("Username were used");
				return;
			}	
			SqlConnection connection = new SqlConnection(connString);
			try
			{
				connection.Open();
				String sqlQuery1 = "select * from USERINFOR";
				int countid=1;
				SqlCommand command1 = new SqlCommand(sqlQuery1, connection);
				SqlDataReader reader = command1.ExecuteReader();

				while (reader.HasRows)
				{
					if (reader.Read() == false) break;
					else countid++;
				}
				connection.Close();
				String sqlQuery = "insert into USERINFOR(id, userName, hashPassword) values(";
				SqlCommand command = new SqlCommand(sqlQuery, connection);
				sqlQuery += (countid +",");
				sqlQuery += ("'" + a + "',");
				sqlQuery += ("'"+ HashPassword(b) + "')");
				//MessageBox.Show(sqlQuery);
				int rs = command.ExecuteNonQuery();
				if (rs != 1)
				{
					throw new Exception("Failed Query");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
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
				if (reader[1] == a)
				{ 
					return true;
				}
			}
			connection.Close();
			return false;
		}
	}
}
