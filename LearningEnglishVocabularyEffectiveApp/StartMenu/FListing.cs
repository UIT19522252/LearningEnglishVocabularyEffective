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
    public partial class FListing : Form
    {
        FListingVideo tabVideo = new FListingVideo();
        FListingMusic tabMusic =  new FListingMusic();
        FListingTest tabTest = new FListingTest();

        public FListing()
        {
            InitializeComponent();
            videoSelected.Visible = false;
            musicSelected.Visible = false;
            testSelected.Visible = false;



            object sender = new object();
            EventArgs e = new EventArgs();
            btnTestTab_Click(sender, e);
        }

        private void btnViDeoTab_Click(object sender, EventArgs e)
        {
            if (Data.CheckForInternetConnection())
            {
                tabMusic.Close();
                tabTest.Close();
                videoSelected.Visible = true;
                musicSelected.Visible = false;
                testSelected.Visible = false;

                tabVideo = new FListingVideo();
                tabVideo.TopLevel = false;
                pnlLoadForm.Controls.Clear();
                pnlLoadForm.Controls.Add(tabVideo);
                tabVideo.FormBorderStyle = FormBorderStyle.None;
                tabVideo.Show();
            }
            else
            {
                FError f = new FError("Turn on your Internet connection!", "Error");
                f.Show();
            }
        }

        private void btnMusicTab_Click(object sender, EventArgs e)
        {
            if (Data.CheckForInternetConnection())
            {
                tabTest.Close();
                tabVideo.Close();
                videoSelected.Visible = false;
                musicSelected.Visible = true;
                testSelected.Visible = false;

                tabMusic = new FListingMusic();
                tabMusic.TopLevel = false;
                pnlLoadForm.Controls.Clear();
                pnlLoadForm.Controls.Add(tabMusic);
                tabMusic.FormBorderStyle = FormBorderStyle.None;
                tabMusic.Show();
            }
            else
            {
                FError f = new FError("Turn on your Internet connection!", "Error");
                f.Show();
            }
        }

        private void btnTestTab_Click(object sender, EventArgs e)
        {
            if (Data.CheckForInternetConnection())
            {
                tabVideo.Close();
                tabMusic.Close();
                videoSelected.Visible = false;
                musicSelected.Visible = false;
                testSelected.Visible = true;

                tabTest = new FListingTest();
                tabTest.TopLevel = false;
                pnlLoadForm.Controls.Clear();
                pnlLoadForm.Controls.Add(tabTest);
                tabTest.FormBorderStyle = FormBorderStyle.None;
                tabTest.Show();
            }
            else
            {
                FError f = new FError("Turn on your Internet connection!", "Error");
                f.Show();
            }
        }
    }
}
