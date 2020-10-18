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
    public partial class FSignUp : Form
    {
        public FSignUp()
        {
            InitializeComponent();
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {

            if(tbxRepeatPass.Text!=tbxPass.Text)
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
    }
}
