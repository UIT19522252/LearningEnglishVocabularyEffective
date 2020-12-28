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
    public partial class FReportUs : Form
    {
        LoginActivity f = new LoginActivity();
        public FReportUs()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.btnSend.Enabled = false;
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress("app.english.vocabulary@gmail.com");
                try
                {
                    mail.To.Add("19522252@gm.uit.edu.vn");
                    mail.Subject = "Report";

                    mail.Body = tbReport.Text + "\n from user: " + Data.username;
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
            finally
            {
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
