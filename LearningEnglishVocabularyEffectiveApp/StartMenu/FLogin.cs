using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace StartMenu
{
    public partial class FLogin : Form
    {
        LoginActivity login = new LoginActivity();
        string code = "";
        User temp = new User();
        public FLogin()
        {
            InitializeComponent();
            this.pnGmail.Hide();
            this.pnNewPass.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginActivity lg = new LoginActivity();
            if (lg.checkUser(tbxUsrname.Text,tbxPassword.Text)==true)
            {
                this.Hide();
                temp.formMenu = new FInterface();
                Data.username = tbxUsrname.Text;
                Data.iduser = lg.FindID(tbxUsrname.Text).ToString();
                temp.formMenu.ShowDialog();
                this.tbxPassword.Text= "";
                this.tbxUsrname.Text = "";
                this.Show();
            }    
            else
            {
               /* FError f = new FError("Login Failed", "Message");
                f.ShowDialog();*/
                this.tbxPassword.Text = "";
                this.tbxUsrname.Text = "";
                this.lblWrong.Visible = true;
                return;
            }                
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FSignUp f = new FSignUp();
            f.ShowDialog();
           
            this.tbxPassword.Text = "";
            this.tbxUsrname.Text = "";
            this.lblWrong.Visible = false;
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            this.lblWrong.Visible = false;
        }

        private void tbxUsrname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                tbxPassword.Focus();

        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
            if (e.KeyCode == Keys.Down)
                btnLogin.Focus();
            if (e.KeyCode == Keys.Up)
                tbxUsrname.Focus();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                tbxPassword.Focus();
            if (e.KeyCode == Keys.Down)
                btnSignUp.Focus();
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void btnSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
               btnLogin.Focus();
            if (e.KeyCode == Keys.Enter)
                btnSignUp_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pnGmail.Show();
            lbSentmailAgain.Hide();
        }

        private double random_Digit()
        {
            double cd;
            Random rd = new Random();
            cd = rd.Next(100000, 999999);
            return cd;
        }
        private void lbSentGmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (login.CheckUserNameFromMail(this.tbEmail.Text.ToString()) != "No")
            {
                this.lbSentmailAgain.Show();
                this.lbSentmail.Hide();
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new System.Net.Mail.MailAddress("app.english.vocabulary@gmail.com");
                if (this.tbEmail.Text == "")
                {
                    FError f = new FError("Enter your mail", "Message");
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();
                }
                else
                {
                    mail.To.Add(this.tbEmail.Text);
                    mail.Subject = "Confirm account";
                    code = random_Digit().ToString();
                    mail.Body = code + " is your confirm code ";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("app.english.vocabulary@gmail.com", "phiphucthe");

                    try
                    {
                        smtp.Send(mail);
                    }

                    catch (SmtpException ex)
                    {
                        MessageBox.Show("Can't sent your mail");
                    }
                }
            }
            else MessageBox.Show("Ban chua co tai khoan voi email nay!");
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(code == tbCode.Text)
            {
                pnNewPass.Show();
                this.lblUserName.Text = "Hello "+ login.CheckUserNameFromMail(tbEmail.Text) +" !";
                Data.username = login.CheckUserNameFromMail(tbEmail.Text);


            }
            else
            {

                FError f = new FError(" Code confirm was wrong", "Message");
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
        }

        private void btRePass_Click(object sender, EventArgs e)
        {
            if (this.tbNewpass.Text == this.tbCNewpass.Text)
            {
                login.ChangePassword(tbCNewpass.Text);
                this.pnGmail.Hide();
                this.pnNewPass.Hide();
                MessageBox.Show("Dat lai mat khau thanh cong!");
            }
            else
            {
                MessageBox.Show("Nhap lai mat khau khong chinh xac!");
            }
        }

        private void lbSentmailAgain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lbSentmailAgain.Show();
            this.lbSentmail.Hide();
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress("app.english.vocabulary@gmail.com");
            if (this.tbEmail.Text == "")
            {
                FError f = new FError("Enter your mail", "Message");
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            else
            {
                mail.To.Add(this.tbEmail.Text);
                mail.Subject = "Confirm account";
                code = random_Digit().ToString();
                mail.Body = code + " is your confirm code ";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("app.english.vocabulary@gmail.com", "phiphucthe");

                try
                {
                    smtp.Send(mail);
                }

                catch (SmtpException ex)
                {
                    MessageBox.Show("Can't sent your mail");
                }
            }
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            if (this.tbCode.Text == "") this.btConfirm.Enabled = false;
            else this.btConfirm.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pnNewPass.Hide();
            this.pnGmail.Hide();
        }
    }
}
