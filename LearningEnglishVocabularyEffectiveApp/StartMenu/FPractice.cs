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
    public partial class FPractice : Form
    {
        public FPractice()
        {
            InitializeComponent();
            this.pnlLoad.Dock = DockStyle.Fill;
            this.pnlLoad.Visible = false;
        }

        //Game chon tu giong nhau
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Data.CheckForInternetConnection())
            {
                GRearangeTheWords game = new GRearangeTheWords();
                game.AutoScroll = true;
                game.TopLevel = false;
                pnlLoad.Controls.Clear();
                pnlLoad.Controls.Add(game);

                game.FormBorderStyle = FormBorderStyle.None;
                game.Show();
                pnlLoad.Visible = true;
            }
            else
            {
                FError f = new FError("Turn on your Internet connection!", "Error");
                f.Show();
            }    
        }

        //Game giet boss
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Data.CheckForInternetConnection())
            {
                GWordConnection game = new GWordConnection();
                game.AutoScroll = true;
                game.TopLevel = false;
                pnlLoad.Controls.Clear();
                pnlLoad.Controls.Add(game);

                game.FormBorderStyle = FormBorderStyle.None;
                game.Show();
                pnlLoad.Visible = true;
            }
            else
            {
                FError f = new FError("Turn on your Internet connection!", "Error");
                f.Show();
            }    
        }
    }
}
