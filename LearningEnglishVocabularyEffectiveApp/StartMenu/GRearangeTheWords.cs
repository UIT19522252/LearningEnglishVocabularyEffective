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
using System.Security.Cryptography;

namespace StartMenu
{
    public partial class GRearangeTheWords : Form
    {
        private DateTime startime; 
        int dem = 0;
        String connString = @"Server=LAPTOP-7LJ1B5F3\SQLEXPRESS;Database=data;User Id=sa;Password=trongphuc123456;";
        public string iduser = "1";
        public string[] EL = new string[10];
        public string[] VN = new string[10];
        public string yourchoice;
        public Button a;
        protected void Get10Words()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            String sqlQuery = "select * from YOURWORDS y join VOCABULARY v on y.idword = v.id";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                
                if (reader[0].ToString() == iduser)
                {
                    
                    int i = 0;
                    while (EL[i] != null)
                    {
                        i++;
                    }
                    EL[i] = reader[3].ToString();
                    VN[i] = reader[4].ToString();
                }
            }
            connection.Close();
           
        }
        public GRearangeTheWords()
        {
            InitializeComponent();
            this.Get10Words();
            this.button1.Text = EL[0];
            this.button9.Text = VN[0];
            this.button2.Text = EL[1];
            this.button14.Text = VN[1];
            this.button3.Text = EL[2];
            this.button19.Text = VN[2];
            this.button4.Text = EL[3];
            this.button20.Text = VN[3];
            this.button5.Text = EL[4];
            this.button18.Text = VN[4];
            this.button6.Text = EL[5];
            this.button16.Text = VN[5];
            this.button7.Text = EL[6];
            this.button15.Text = VN[6];
            this.button8.Text = EL[7];
            this.button12.Text = VN[7];
            this.button17.Text = VN[8];
            this.button11.Text = EL[8];
            this.button10.Text = VN[9];
            this.button13.Text = EL[9];
            startime = DateTime.Now;
        }
        private void GRearangeTheWords_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(yourchoice == null)
            {
                yourchoice = button1.Text;
                a = button1;
            }    
            else if (yourchoice == button1.Text)
            {
                yourchoice = null;
            }    
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if(EL[i] == yourchoice)
                    {
                        if(VN[i] == button1.Text)
                        {
                            button1.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }    
                    } 
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button1.Text)
                        {
                            button1.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }                
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button9.Text;
                a = button9;
            }
            else if (yourchoice == button9.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button9.Text)
                        {
                            result = true;
                            button9.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button9.Text)
                        {
                            button9.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button2.Text;
                a = button2;
            }
            else if (yourchoice == button2.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button2.Text)
                        {
                            result = true;
                            button2.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button2.Text)
                        {
                            button2.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button5.Text;
                a = button5;
            }
            else if (yourchoice == button5.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button5.Text)
                        {
                            result = true;
                            button5.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button5.Text)
                        {
                            button5.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button6.Text;
                a = button6;
            }
            else if (yourchoice == button6.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button6.Text)
                        {
                            result = true;
                            button6.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button6.Text)
                        {
                            button6.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button10.Text;
                a = button9;
            }
            else if (yourchoice == button10.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button10.Text)
                        {
                            result = true;
                            button10.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button10.Text)
                        {
                            button10.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button7.Text;
                a = button7;
            }
            else if (yourchoice == button7.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button7.Text)
                        {
                            result = true;
                            button7.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button7.Text)
                        {
                            button7.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button11.Text;
                a = button11;
            }
            else if (yourchoice == button11.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button11.Text)
                        {
                            result = true;
                            button11.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button11.Text)
                        {
                            button11.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button12.Text;
                a = button12;
            }
            else if (yourchoice == button12.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button12.Text)
                        {
                            result = true;
                            button12.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button12.Text)
                        {
                            button12.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button8.Text;
                a = button8;
            }
            else if (yourchoice == button8.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button8.Text)
                        {
                            result = true;
                            button8.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button8.Text)
                        {
                            button8.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button3.Text;
                a = button3;
            }
            else if (yourchoice == button3.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button3.Text)
                        {
                            result = true;
                            button3.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button3.Text)
                        {
                            button3.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button4.Text;
                a = button4;
            }
            else if (yourchoice == button4.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button4.Text)
                        {
                            result = true;
                            button4.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button4.Text)
                        {
                            button4.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button13.Text;
                a = button13;
            }
            else if (yourchoice == button13.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button13.Text)
                        {
                            result = true;
                            button13.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                        else if (VN[i] == yourchoice)
                        {
                            if (EL[i] == button13.Text)
                            {
                                button13.Hide();
                                a.Hide();
                                result = true;
                                dem++;
                                yourchoice = null;
                                a = null;
                            }
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button17.Text;
                a = button17;
            }
            else if (yourchoice == button17.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button17.Text)
                        {
                            result = true;
                            button17.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button17.Text)
                        {
                            button17.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button14.Text;
                a = button14;
            }
            else if (yourchoice == button14.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button14.Text)
                        {
                            result = true;
                            button14.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button14.Text)
                        {
                            button14.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button18.Text;
                a = button18;
            }
            else if (yourchoice == button18.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button18.Text)
                        {
                            result = true;
                            button18.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button18.Text)
                        {
                            button18.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button15.Text;
                a = button15;
            }
            else if (yourchoice == button15.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button15.Text)
                        {
                            result = true;
                            button15.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button15.Text)
                        {
                            button15.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button19.Text;
                a = button19;
            }
            else if (yourchoice == button19.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button19.Text)
                        {
                            result = true;
                            button19.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button19.Text)
                        {
                            button19.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button16.Text;
                a = button16;
            }
            else if (yourchoice == button16.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button16.Text)
                        {
                            result = true;
                            button16.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button16.Text)
                        {
                            button16.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button20.Text;
                a = button20;
            }
            else if (yourchoice == button20.Text)
            {
                yourchoice = null;
            }
            else
            {
                bool result = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button20.Text)
                        {
                            result = true;
                            button20.Hide();
                            a.Hide();
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                    else if (VN[i] == yourchoice)
                    {
                        if (EL[i] == button20.Text)
                        {
                            button20.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Incorrect");
                    yourchoice = null;
                    a = null;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan spantime = DateTime.Now - startime;
            time.Text = spantime.ToString();
            if (dem == 10) timer1.Stop();
        }
    }
}
