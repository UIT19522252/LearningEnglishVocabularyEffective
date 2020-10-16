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
            this.Hide();
            temp.formMenu = new StartMenu(temp.username);
            temp.formMenu.ShowDialog();
            this.Show();
        }
    }
}
