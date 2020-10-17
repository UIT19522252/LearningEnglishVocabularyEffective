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
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            if(tbxRepeatPass.Text!=tbxPass.Text)
            {
                MessageBox.Show("Password and repeat password are not match ", "Message");
            } 
            else
            {
                LoginActivity lg = new LoginActivity();
                lg.Signup(tbxUsername.Text, tbxPass.Text);
            }    
        }
    }
}
