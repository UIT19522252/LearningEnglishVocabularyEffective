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
    public partial class FLearnNewWord : Form
    {
        Voice voice = new Voice();
        int time = 0;
        int temp = 0;
        int score = 0;
        Panel root = new Panel();
        public FLearnNewWord()
        {
            InitializeComponent();
            timerOutOfTime.Start();
            btnSpeaker2.Visible = false;
            this.btnDone.Visible = false;
            pnlLoad.Visible = false;
            btnScore.Text = score.ToString();



            temp = BackEnd.getQuestion();
            if (temp != -1)
            {
                this.Questions.Text = Data.newWord[temp % 5].question.ToString();
                Data.currentQuestion = Data.newWord[temp % 5];
                loadAnswer();
            }
        }

        public FLearnNewWord(Panel frame)
        {
            InitializeComponent();
            timerOutOfTime.Start();

            btnSpeaker2.Visible = false;
            this.btnDone.Visible = false;
            pnlLoad.Visible = false;
            btnScore.Text = score.ToString();
            root = frame;

            temp = BackEnd.getQuestion();
            if (temp != -1)
            {
                this.Questions.Text = Data.newWord[temp % 5].question.ToString();
                Data.currentQuestion = Data.newWord[temp % 5];
                loadAnswer();
            }
        }






        // btnBack


        int getIndexofQuestion()
        {
            for (int i = 0; i < Data.newWord.Count; i++)
                if (Data.newWord[i].question == Data.currentQuestion.question)
                    return i;
            return -1;
        }
        void WrongAnswer()
        {
            this.btnSpeaker2.Text = "Incorrect!";
            int n = getIndexofQuestion();
            if (n < 0) return;
            score -= 8;
            if (score <= -50)
            {
                btnScore.Text = score.ToString();
                this.btnSpeaker2.Visible = true;
                this.btnSpeaker2.Text = "Your must be learn 5 new words again!";
                btnLearnAgain.Visible = true;
                Data.XONG = true;
                this.AnswerA.Visible = this.AnswerB.Visible = this.AnswerC.Visible = this.AnswerD.Visible = this.Questions.Visible = false;
                Questions.Enabled = false;
            }
            else
            {
                btnScore.Text = score.ToString();
                Data.ArrNumber.Add(n);
                Data.ArrNumber.Add(n);
                btnSpeaker2.Visible = true;
                TimerWrong.Start();

            }

        }

        private void TimerVisitable_Tick(object sender, EventArgs e)
        {
            TimerVisitable.Stop();
            this.btnSpeaker2.Visible = false;
            int temp = BackEnd.getQuestion();

            if (temp != -1)
            {
                this.Questions.Text = Data.newWord[temp % 5].question.ToString();
                Data.currentQuestion = Data.newWord[temp % 5];
                loadAnswer();
            }
            else
            {
                this.btnSpeaker2.Visible = true;
                this.btnSpeaker2.Text = "Congratulation !\n You have learn 5 new words!";
                timerOutOfTime.Stop();
                this.lblTime.Hide();
                this.LearnSuccess();
                Data.XONG = true;
                this.btnDone.Visible = true;
                this.btnHome.Visible = true;
                this.AnswerA.Visible = this.AnswerB.Visible = this.AnswerC.Visible = this.AnswerD.Visible = this.Questions.Visible = false;
                Questions.Enabled = false;
            }
        }

        private void FLearnNewWord_Load(object sender, EventArgs e)
        {
            voice.Read(".");
        }

        public void loadAnswer()
        {
            Data.listAnswer.Clear();
            string connString = Data.ConnString;

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            string sqlQuery = "select top 3 ID, WORD, MEAN from VOCABULARY order by newid()";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Data.listAnswer.Add(new Question(reader[1].ToString(), reader[2].ToString()));
            }
            connection.Close();
            Data.listAnswer.Add(Data.currentQuestion);
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


        private void btnDone_Click(object sender, EventArgs e)
        {
            if (Data.CheckForInternetConnection())
            {
                FPreviewNewWord tabLearnNewWord = new FPreviewNewWord();
                tabLearnNewWord.AutoScroll = true;
                tabLearnNewWord.TopLevel = false;
                root.Controls.Clear();
                root.Controls.Add(tabLearnNewWord);

                tabLearnNewWord.FormBorderStyle = FormBorderStyle.None;
                tabLearnNewWord.Show();
                root.Visible = true;
            }
            else
            {
                FError f = new FError("Turn on your Internet connection!", "Error");
                f.Show();
            }                
        }

        private void AnswerA_Click(object sender, EventArgs e)
        {
            string s = AnswerA.Text.Remove(0, 3);
            if (s == Data.currentQuestion.answer)
            {
                voice.Read(Data.currentQuestion.question);
                TimerVisitable.Start();
                this.btnSpeaker2.Text = "Correct!";
                score += 4;
                btnScore.Text = score.ToString();
                this.btnSpeaker2.Visible = true;
            }
            else WrongAnswer();
        }

        private void AnswerB_Click(object sender, EventArgs e)
        {
            string s = AnswerB.Text.Remove(0, 3);
            if (s == Data.currentQuestion.answer)
            {
                voice.Read(Data.currentQuestion.question);

                TimerVisitable.Start();
                this.btnSpeaker2.Text = "Correct!";
                score += 4;
                btnScore.Text = score.ToString();
                this.btnSpeaker2.Visible = true;
            }
            else WrongAnswer();
        }

        private void AnswerC_Click(object sender, EventArgs e)
        {
            string s = AnswerC.Text.Remove(0, 3);
            if (s == Data.currentQuestion.answer)
            {
                voice.Read(Data.currentQuestion.question);

                TimerVisitable.Start();
                this.btnSpeaker2.Text = "Correct!";
                score += 4;
                btnScore.Text = score.ToString();
                this.btnSpeaker2.Visible = true;
            }
            else WrongAnswer(); 
        }

        private void AnswerD_Click(object sender, EventArgs e)
        {
            string s = AnswerD.Text.Remove(0, 3);
            if (s == Data.currentQuestion.answer)
            {
                voice.Read(Data.currentQuestion.question);

                TimerVisitable.Start();
                this.btnSpeaker2.Text = "Correct!";
                score += 4;
                btnScore.Text = score.ToString();
                this.btnSpeaker2.Visible = true;
            }
            else WrongAnswer();
        }


        void LearnSuccess()
        {
            sqlConnection sql = new sqlConnection();
            sql.Learned(Data.id[0]);
            sql.Learned(Data.id[1]);
            sql.Learned(Data.id[2]);
            sql.Learned(Data.id[3]);
            sql.Learned(Data.id[4]);

        }

        private void TimerWrong_Tick(object sender, EventArgs e)
        {
                TimerWrong.Stop();
                this.btnSpeaker2.Visible = false;

                lblWordRL.Text = Data.currentQuestion.question + " : " + Data.currentQuestion.answer;
                pnlLoad.Visible = true;

            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlLoad.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FIntroduction tabLearnNewWord = new FIntroduction();
            tabLearnNewWord.AutoScroll = true;
            tabLearnNewWord.TopLevel = false;
            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(tabLearnNewWord);

            tabLearnNewWord.FormBorderStyle = FormBorderStyle.None;
            tabLearnNewWord.Show();
            pnlLoad.Visible = true;
            this.btnSpeaker2.Visible = false;
            this.btnDone.Visible = false;
            this.btnHome.Visible = false;
        }

        private void btnLearnAgain_Click(object sender, EventArgs e)
        {
            root.Visible = false;
            this.Close();
        }

        private void timerOutOfTime_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (time == 180)
            {
                timerOutOfTime.Stop();
                this.btnSpeaker2.Visible = true;
                this.btnSpeaker2.Text = "Out of time!\nYour must be learn 5 new words again!";
                btnLearnAgain.Visible = true;
                Data.XONG = true;
                this.AnswerA.Visible = this.AnswerB.Visible = this.AnswerC.Visible = this.AnswerD.Visible = this.Questions.Visible = false;
                Questions.Enabled = false;
            }
            lblTime.Text = "Time: " + time.ToString();

        }

        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            voice.Read(Data.currentQuestion.question);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            voice.Read(Data.currentQuestion.question);
        }
    }
}
