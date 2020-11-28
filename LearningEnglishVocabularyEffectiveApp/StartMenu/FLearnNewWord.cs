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
        int temp = 0;

        public FLearnNewWord()
        {
            InitializeComponent();
            lblCorrect.Visible = false;
            this.btnDone.Visible = false;
        }

        

        

        

        // btnBack
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int getIndexofQuestion()
        {
            for (int i = 0; i < Data.newWord.Count; i++)
                if (Data.newWord[i].question == Data.currentQuestion.question)
                    return i;
            return -1;
        }
        void WrongAnswer()
        {
            this.lblCorrect.Text = "Incorrect!";
            int n = getIndexofQuestion();
            if (n < 0) return;
            Data.ArrNumber.Add(n);
            Data.ArrNumber.Add(n);
            ReLearn f = new ReLearn();
            this.Hide();
            f.ShowDialog();
            this.Show();
            TimerVisitable.Start();
            this.Questions.Text = "";
            this.lblCorrect.Visible = true;

        }

        private void TimerVisitable_Tick(object sender, EventArgs e)
        {
            TimerVisitable.Stop();
            this.lblCorrect.Visible = false;
            int temp = BackEnd.getQuestion();

            if (temp != -1)
            {
                this.Questions.Text = Data.newWord[temp % 5].question.ToString();
                Data.currentQuestion = Data.newWord[temp % 5];
                loadAnswer();
            }
            else
            {
                this.lblCorrect.Visible = true;
                this.lblCorrect.Text = "Congratulation !\n You have learn 5 new words!";
                Data.XONG = true;
                this.btnDone.Visible = true;
                this.AnswerA.Visible = this.AnswerB.Visible = this.AnswerC.Visible = this.AnswerD.Visible = this.Questions.Visible = false;
                Questions.Enabled = false;
            }
        }

        private void FLearnNewWord_Load(object sender, EventArgs e)
        {
            temp = BackEnd.getQuestion();
            if (temp != -1)
            {
                this.Questions.Text = Data.newWord[temp % 5].question.ToString();
                Data.currentQuestion = Data.newWord[temp % 5];
                loadAnswer();
            }
        }

        public void loadAnswer()
        {
            Data.listAnswer.Clear();
            string connString = @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            string sqlQuery = "select top 3 * from VOCABULARY order by newid()";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Data.listAnswer.Add(new Question(reader[0].ToString(), reader[1].ToString()));
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

        private void AnswerA_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            string s = a.Text.Remove(0, 3);
            if (s == Data.currentQuestion.answer)
            {
                TimerVisitable.Start();
                this.lblCorrect.Text = "Correct!";

                this.lblCorrect.Visible = true;
            }
            else WrongAnswer();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
