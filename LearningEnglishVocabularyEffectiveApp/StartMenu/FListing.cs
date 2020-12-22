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
        public FListing()
        {
            InitializeComponent();
            videoSelected.Visible = false;
            musicSelected.Visible = false;
            testSelected.Visible = false;
        }

        private void btnViDeoTab_Click(object sender, EventArgs e)
        {
            videoSelected.Visible = true;
            musicSelected.Visible = false;
            testSelected.Visible = false;

            FListingVideo tabVideo = new FListingVideo();
            tabVideo.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabVideo);
            tabVideo.FormBorderStyle = FormBorderStyle.None;
            tabVideo.Show();
        }

        private void btnMusicTab_Click(object sender, EventArgs e)
        {
            videoSelected.Visible = false;
            musicSelected.Visible = true;
            testSelected.Visible = false;

            FListingMusic tabMusic = new FListingMusic();
            tabMusic.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabMusic);
            tabMusic.FormBorderStyle = FormBorderStyle.None;
            tabMusic.Show();
        }

        private void btnTestTab_Click(object sender, EventArgs e)
        {
            videoSelected.Visible = false;
            musicSelected.Visible = false;
            testSelected.Visible = true;

            FListingTest tabTest = new FListingTest();
            tabTest.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabTest);
            tabTest.FormBorderStyle = FormBorderStyle.None;
            tabTest.Show();
        }
    }
}
