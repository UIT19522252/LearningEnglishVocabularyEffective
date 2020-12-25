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
    public partial class FSignUp : Form
    {
        string code = "";
        public FSignUp()
        {
           
            InitializeComponent();
            this.lbSentmailAgain.Hide();
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(this.tbCode.Text != code)
            {
                FError f = new FError(" Code confirm was wrong", "Message");
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            else if(tbxRepeatPass.Text!=tbxPass.Text)
            {
                FError f = new FError("Password and repeat password are not match ", "Message");
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            } 
            else
            {
                LoginActivity lg = new LoginActivity();
                if (lg.Signup(tbxUsername.Text, tbxPass.Text))
                {
                    MessageBox.Show("Sign up succesfully!", "Congratulation!");
                    this.Hide();
                    this.Close();
                }
            }    
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                tbxPass.Focus();
            }    
        }

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                tbxRepeatPass.Focus();
            if (e.KeyCode == Keys.Up)
                tbxUsername.Focus();
        }

        private void tbxRepeatPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSignup_Click(sender, e);
            if (e.KeyCode == Keys.Up)
                tbxPass.Focus();
            if (e.KeyCode == Keys.Down)
                btnSignup.Focus();
        }

        private void btnSignup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                tbxRepeatPass.Focus();
            if (e.KeyCode == Keys.Left)
                btnSignin.Focus();
            if (e.KeyCode == Keys.Enter)
                btnSignup_Click(sender, e);
        }

        private void btnSignin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                tbxRepeatPass.Focus();
            if (e.KeyCode == Keys.Right)
                btnSignup.Focus();
            if (e.KeyCode == Keys.Enter)
                btnSignin_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private double random_Digit()
        {
            double cd;
            Random rd = new Random();
            cd = rd.Next(100000, 999999);
            return cd;
        }
        private void lbSentmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lbSentmailAgain.Show();
            this.lbSentmail.Hide();
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress("app.english.vocabulary@gmail.com");
            if (this.tbxUsername.Text =="")
            {
                FError f = new FError("Enter your mail", "Message");
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            else
            {
                mail.To.Add(this.tbxUsername.Text);
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

        private void lbSentmailAgain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lbSentmailAgain.Show();
            this.lbSentmail.Hide();
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress("app.english.vocabulary@gmail.com");
            if (this.tbxUsername.Text == null)
            {
                FError f = new FError("Enter your mail", "Message");
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            else
            {
                try
                {
                    mail.To.Add(this.tbxUsername.Text);
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
                catch
                {
                    FError f = new FError("Your gmail was wrong", "Message");
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();
                }
            }
        }
    }
}
