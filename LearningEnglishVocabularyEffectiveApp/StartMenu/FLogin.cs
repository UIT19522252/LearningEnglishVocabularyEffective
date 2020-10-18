using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class FLogin : Form
    {
        User temp = new User();
        public FLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginActivity lg = new LoginActivity();
            if (lg.checkUser(tbxUsrname.Text,tbxPassword.Text)==true)
            {
                this.Hide();
                temp.formMenu = new StartMenu(temp.username);
                temp.formMenu.ShowDialog();
                this.tbxPassword.Text= "";
                this.tbxUsrname.Text = "";
                this.Show();
            }    
            else
            {
                FError f = new FError("Login Failed", "Message");
                f.ShowDialog();
                this.tbxPassword.Text = "";
                this.tbxUsrname.Text = "";
                return;
            }                
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FSignUp f = new FSignUp();
            f.ShowDialog();
            this.tbxPassword.Text = "";
            this.tbxUsrname.Text = "";
        }

        private void tbxUsrname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                tbxPassword.Focus();

        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
            if (e.KeyCode == Keys.Up)
                tbxUsrname.Focus();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                tbxPassword.Focus();
        }
    }
}
