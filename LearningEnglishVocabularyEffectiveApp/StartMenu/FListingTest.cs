using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
namespace StartMenu
{
    public partial class FListingTest : Form
    {
        List<string> id = new List<string>();
        List<string> kq = new List<string>();
        List<string> daA = new List<string>();
        List<string> daB = new List<string>();
        List<string> daC  = new List<string>();
        List<string> daD= new List<string>();
        int chiSo = 0;
        public FListingTest()
        {
            InitializeComponent();
            SQLconnect();
            Showf();
        }
        private void SQLconnect()
        {
            String connString = @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "select * from LisAndPic where ST = 'Y'";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                id.Add(reader[0].ToString());
                kq.Add(reader[1].ToString());
                daA.Add(reader[2].ToString());
                daB.Add(reader[3].ToString());
                daC.Add(reader[4].ToString());
                daD.Add(reader[5].ToString());
            }
            connection.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6) + @"\picandsound\" + id[chiSo] + @".wav";
            
            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.Play();
        }
        private void Showf()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6) + @"\picandsound\" + id[chiSo] + @".jpg";
            Image pt = Image.FromFile(path);
            this.Pic.Image = pt;
            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
            D.Checked = false;
            this.lbCorrect.Hide();
            this.lbIncorrect.Hide();
            A.Text = daA[chiSo].Substring(0,1);
            B.Text = daB[chiSo].Substring(0,1);
            C.Text = daC[chiSo].Substring(0,1);
            D.Text = daD[chiSo].Substring(0,1);
            this.lbKetQua.Hide();
            this.btNote.Hide();
        }
        private void Pic_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (chiSo >= 1)
            {
                chiSo -= 1;
                Showf();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (chiSo >= 0 && chiSo < id.Count() -1 )
            {
                chiSo += 1;
                Showf();
            }
        }

        private void btketqua_Click(object sender, EventArgs e)
        {
            A.Text = daA[chiSo];
            B.Text = daB[chiSo];
            C.Text = daC[chiSo];
            D.Text = daD[chiSo];
            this.lbKetQua.Text = "Result: " + kq[chiSo];
            this.lbKetQua.Show();
            this.btNote.Show();
            if (A.Checked ==true && kq[chiSo] == "A")
            {
                this.lbCorrect.Show();
            }
            else if (B.Checked == true && kq[chiSo] == "B")
            {
                this.lbCorrect.Show();
            }
            else if (C.Checked == true && kq[chiSo] == "C")
            {
                this.lbCorrect.Show();
            }
            else if (D.Checked ==true && kq[chiSo] == "D")
            {
                this.lbCorrect.Show();
            }
            else
                this.lbIncorrect.Show();
        }

        private void btNote_Click(object sender, EventArgs e)
        {
            String connString = @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "update LisAndPic set st = 'N' where id =" + @"'" + id[chiSo]+ @"'";

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            connection.Close();
        }

        private void lbKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
