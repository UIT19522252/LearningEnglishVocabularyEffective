using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class FCarRacingGame : Form
    {
        bool NE = true;
        int heart = 3;
        int score = 0;
        int count = 0;
        bool isRight = false;
        bool RockOn = false;
        int ROCK;
        public FCarRacingGame()
        {
            InitializeComponent();
            this.pnlQuestion.Visible = false;
            ROCK = 0;
            this.Rock.Visible = false; 
            //timerTree.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool Accident()
        {
            if (this.Rock.Left < this.car.Left && this.Rock.Right > this.car.Left || this.Rock.Left < this.car.Right && this.Rock.Right > this.car.Right)
                if (this.Rock.Bottom == this.car.Top - this.car.Height)
                    return true;
            return false;
        }

        public bool Accident2()
        {
            if (this.Rock.Left < this.car.Left && this.Rock.Right > this.car.Left || this.Rock.Left < this.car.Right && this.Rock.Right > this.car.Right)
                if (this.Rock.Bottom >= this.car.Top - this.car.Height)
                    return true;
            return false;
        }

        private void timerTree_Tick(object sender, EventArgs e)
        {
            this.lblTotalScore.Text = score.ToString();
            int x = 5;
            if (tree1.Top > this.panelGame.Bottom)
                tree1.Top = -1 * this.tree1.Height;
            else tree1.Top += x;


            if (tree2.Top > this.panelGame.Bottom)
                tree2.Top = -1 * this.tree1.Height;
            else tree2.Top += x;



            if (tree3.Top > this.panelGame.Bottom)
                tree3.Top = -1 * this.tree1.Height;
            else tree3.Top += x;



            if (tree4.Top > this.panelGame.Bottom)
                tree4.Top = -1 * this.tree1.Height;
            else tree4.Top += x;



            if (tree5.Top > this.panelGame.Bottom)
                tree5.Top = -1 * this.tree1.Height;
            else tree5.Top += x;



            if (tree6.Top > this.panelGame.Bottom)
                tree6.Top = -1 * this.tree1.Height;
            else tree6.Top += x;


            if (line1.Top > this.panelGame.Bottom)
                line1.Top = -1 * this.line1.Height;
            else line1.Top += x;



            if (line2.Top > this.panelGame.Bottom)
                line2.Top = -1 * this.line1.Height;
            else line2.Top += x;



            if (line3.Top > this.panelGame.Bottom)
                line3.Top = -1 * this.line1.Height;
            else line3.Top += x;



            if (line4.Top > this.panelGame.Bottom)
                line4.Top = -1 * this.line1.Height;
            else line4.Top += x;



            if (RockOn)
            {
                this.Rock.Top += x;
            }

            if (Accident())
            {
                this.pnlQuestion.Visible = true;
                this.pnlQuestion.Dock = DockStyle.Fill;
                this.timerTree.Stop();
                this.timerRock.Stop();
                pnlQuestionApr();
            }

            if (Accident2())
            {
                if (heart > 0)
                {
                    if (isRight)
                    {
                        this.car.Left += 5 * x;

                    }
                    else
                    {
                        this.car.Left -= 5 * x;

                    }
                }
                else
                {
                    GmOv.Text = "Game over!\n Your score: " + score;
                    timerRock.Stop();
                    GameOver();
                }
            }
        }

        public void pnlQuestionApr()
        {
            LoadQuestion();
            this.question.Text = Data.newWord[0].question;
            loadAnswer();

        }
        public void GameOver()
        {
            if (Rock.Bottom < car.Top)
            Rock.Top += 5;
            else
            {
                //GmOv.Text = "Game over!\n Your score: " + score;
                GmOv.Visible = true;
                timerTree.Stop();
                guna2Button1.Visible = true;
            }
        }
        private void FCarRacingGame_Load(object sender, EventArgs e)
        {
            this.countStart.Visible = false;
        }

        private void timerRock_Tick(object sender, EventArgs e)
        {
            ROCK += 1;
            if (ROCK == 28)
            {
                GmOv.Text = "You win!\n Your score: 100";
                GameOver();
            }
            if (ROCK % 5 == 0)
            {
                RockOn = true;
                this.Rock.Visible = true;
                this.Rock.Top = -1 * this.Rock.Height;
                this.Rock.Left = this.car.Left - (this.car.Width - this.car.Width) / 2;
                if (isRight)
                    isRight = false;
                else isRight = true;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timerStart.Start();

            this.countStart.Visible = true;

        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            
            if (count == 4)
            {
                timerTree.Start();
                timerRock.Start();
                timerStart.Stop();
                this.Start.Visible = false;
                this.countStart.Visible = false;
            }
            countStart.Text = (4 - count).ToString();
            count++;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.pnlQuestion.Visible = false;
            timerTree.Start();
            timerRock.Start();

        }






        /*string connString = @"Server=LAPTOP-QJ254BVV\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
        int demso = 0;
        //public string iduser = "1";
        public string[] EL = new string[5];
        public string[] VN = new string[5];
        public string yourchoice;
        public Button a;
        protected void Get5Words()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            String sqlQuery = "select top 5 * from ToLearn y join VOCABULARY v on y.id_word = v.id where y.id_user=" + Data.iduser+" order by newid()";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Random rd = new Random();
                int i = rd.Next(0, 10);
                while (EL[i] != null)
                {
                    i = rd.Next(0, 5);
                    if (demso == 5)
                    {
                        connection.Close();
                        return;
                    }
                }
                EL[i] = reader[3].ToString();
                VN[i] = reader[4].ToString();
                demso += 1;
            }
            connection.Close();

        }*/
        public static void LoadQuestion()
        {
            Data.newWord.Clear();
            // The: @"Server=LAPTOP-QJ254BVV\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            // Phi: @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            string connString = @"Server=LAPTOP-QJ254BVV\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            // string sqlQuery = "select top 1 * from Learned y join VOCABULARY v on y.id_word = v.id where y.id_user=" + Data.iduser + " order by newid()";
            string sqlQuery = "select top 1 * from Learned y join VOCABULARY v on y.id_word = v.id where y.id_user= 1 order by newid()";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Data.newWord.Add(new Question(reader[3].ToString(), reader[4].ToString()));
            }
            connection.Close();

        }

        public void loadAnswer()
        {
            Data.listAnswer.Clear();
            // The: @"Server=LAPTOP-QJ254BVV\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            // Phi: @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            string connString = @"Server=LAPTOP-QJ254BVV\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            string sqlQuery = "select top 3 * from VOCABULARY order by newid()";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Data.listAnswer.Add(new Question(reader[1].ToString(), reader[2].ToString()));
            }
            connection.Close();
            Data.listAnswer.Add(Data.newWord[0]);
            Question tmp = Data.listAnswer[3];
            Random rd = new Random();
            int rdIndex = rd.Next(0, 4);
            Data.listAnswer[3] = Data.listAnswer[rdIndex];
            Data.listAnswer[rdIndex] = tmp;

            this.AnswerA.Text = "A. " + Data.listAnswer[0].answer;
            this.AnswerB.Text = "B. " + Data.listAnswer[1].answer;
            this.AnswerC.Text = "C. " + Data.listAnswer[2].answer;
            this.AnswerD.Text = "D. " + Data.listAnswer[3].answer;


        }

        private void AnswerC_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            string s = a.Text.Remove(0, 3);
            if (s == Data.newWord[0].answer)
            {
                tmp = 0;
                Correct.Text = "Correct!";
                timerCorrect.Start();
                score += 20;
            }
            else
            {
                heart--;
                lblHeart.Text = "x" + heart;
                if (heart == 0)
                {
                    tmp = 0;
                    Correct.Text = "You Lose!";
                    timerCorrect.Start();
                }
                else
                {
                    tmp = 0;
                    Correct.Text = "Incorrect!";
                    timerInCorrect.Start();
                    pnlQuestionApr();
                }
            }
            
        }

        int tmp = 0;
        private void timerCorrect_Tick(object sender, EventArgs e)
        {
            if (tmp == 0)
                Correct.Visible = true;
            else
            {
                Correct.Visible = false;
                timerCorrect.Stop();
                this.pnlQuestion.Visible = false;
                timerTree.Start();
                timerRock.Start();
            }
            tmp++;
        }

        private void timerInCorrect_Tick(object sender, EventArgs e)
        {
            if (tmp == 0)
                Correct.Visible = true;
            else
            {
                Correct.Visible = false;
                timerCorrect.Stop();
            }
            tmp++;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
