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
        int dm = 0;
        int demso = 0;

        String connString = Data.ConnString;
        public string iduser = "1";
        public string[] EL = new string[10];
        public string[] VN = new string[10];
        public string yourchoice;
        public Button a;
        protected void Get10Words()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            String sqlQuery = "select WORD,MEAN from Learned y join VOCABULARY v on y.id_word = v.id where y.id_user="+Data.iduser;
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                    Random rd = new Random();
                    int i = rd.Next(0, 10);
                    while (EL[i] != null)
                    {
                        i = rd.Next(0, 10);
                        if (demso == 10) return;
                    }
                   EL[i] = reader[0].ToString();
                   VN[i] = reader[1].ToString();
                  demso += 1;
            }
            connection.Close();

        }


        public void RandomButton()
        {
            List<Button> mButton = new List<Button>(20);
            mButton.Add(this.button1);
            mButton.Add(this.button2);
            mButton.Add(this.button3);
            mButton.Add(this.button4);
            mButton.Add(this.button5);
            mButton.Add(this.button6);
            mButton.Add(this.button7);
            mButton.Add(this.button8);
            mButton.Add(this.button9);
            mButton.Add(this.button10);
            mButton.Add(this.button11);
            mButton.Add(this.button12);
            mButton.Add(this.button13);
            mButton.Add(this.button14);
            mButton.Add(this.button15);
            mButton.Add(this.button16);
            mButton.Add(this.button17);
            mButton.Add(this.button18);
            mButton.Add(this.button19);
            mButton.Add(this.button20);

            for (int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                int m = rd.Next(0, 20);
                while (mButton[m].Text != "")
                {
                    m = rd.Next(0, 20);
                }
                mButton[m].Text = EL[i];
                while (mButton[m].Text != "")
                {
                    m = rd.Next(0, 20);
                }
                mButton[m].Text = VN[i];
            }
        }
        public GRearangeTheWords()
        {
            InitializeComponent();
            this.correct.Hide();
            this.incorrect.Hide();
            this.TBDiem.Hide();
            this.TBtime.Hide();
            this.diemtb.Hide();
            this.timetb.Hide();
            this.btnAgain.Hide();
            this.btnExit.Hide();
            this.Get10Words();
            this.RandomButton();
            startime = DateTime.Now;
            diem.Text = "0";
        }
        private void GRearangeTheWords_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
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
                    if (EL[i] == yourchoice)
                    {
                        if (VN[i] == button1.Text)
                        {
                            button1.Hide();
                            a.Hide();
                            result = true;
                            dem++;
                            yourchoice = null;
                            a = null;
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (yourchoice == null)
            {
                yourchoice = button10.Text;
                a = button10;
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                                dm += 10;
                            }
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
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
            string h, m, s;
            if (spantime.Hours < 10)
                h = "0" + spantime.Hours.ToString();
            else
                h = spantime.Hours.ToString();
            if (spantime.Minutes < 10)
                m = "0" + spantime.Minutes.ToString();
            else
                m = spantime.Minutes.ToString();
            if (spantime.Seconds < 10)
                s = "0" + spantime.Seconds.ToString();
            else
                s = spantime.Seconds.ToString();
            time.Text = h + ":" + m + ":" + s;
            if (dem == 10)
            {
                timer1.Stop();
                time.Hide();
                diem.Hide();
                lbtime.Hide();
                lbpoint.Hide();
                diemtb.Text = diem.Text;
                timetb.Text = time.Text;
                TBDiem.Show();
                TBtime.Show();
                diemtb.Show();
                timetb.Show();
                btnAgain.Show();
                btnExit.Show();
                correct.Hide();
                guna2Button1.Hide();
            }
        }

        private void again_Click(object sender, EventArgs e)
        {
           
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
                            dm += 10;
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
                            dm += 10;
                        }
                    }
                }
                if (result == false)
                {
                    incorrect.Show();
                    correct.Hide();
                    yourchoice = null;
                    a = null;
                    dm -= 5;
                }
                else
                {
                    correct.Show();
                    incorrect.Hide();
                }
            }
            diem.Text = dm.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FPractice tabLearnNewWord = new FPractice();
            tabLearnNewWord.AutoScroll = true;
            tabLearnNewWord.TopLevel = false;
            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(tabLearnNewWord);

            tabLearnNewWord.FormBorderStyle = FormBorderStyle.None;
            tabLearnNewWord.Show();
            pnlLoad.Dock = DockStyle.Fill;
            pnlLoad.Visible = true;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            GRearangeTheWords newgame = new GRearangeTheWords();

            newgame.AutoScroll = true;
            newgame.TopLevel = false;
            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(newgame);

            newgame.FormBorderStyle = FormBorderStyle.None;
            newgame.Show();
            pnlLoad.Dock = DockStyle.Fill;
            pnlLoad.Visible = true;
            btnExit.Visible = btnAgain.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FPractice tabLearnNewWord = new FPractice();
            tabLearnNewWord.AutoScroll = true;
            tabLearnNewWord.TopLevel = false;
            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(tabLearnNewWord);

            tabLearnNewWord.FormBorderStyle = FormBorderStyle.None;
            tabLearnNewWord.Show();
            pnlLoad.Dock = DockStyle.Fill;
            pnlLoad.Visible = true;
            btnExit.Visible = btnAgain.Visible = false;
        }
    }
}
