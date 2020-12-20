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
    public partial class FInterface : Form
    {
        FPreviewNewWord tabPreviewNewWord;
        FPractice tabPractice;
        FRevision tabRevision;
        Dictionary tabDictionary;
        FIntroduction tabHome;

        public FInterface()
        {
            InitializeComponent();
            this.pnlMenu1.Visible = false;
            this.pnlMenu1.Left = -1 * this.pnlMenu1.Width;
            this.btnShowMenu.Visible = true;
            // this.button1.Text= this.Height.ToString() + "\n" + this.pnlLoadForm.Height.ToString() + "\n" + this.pnlStatusBar.Height.ToString();
            //this.btnShowMenu.Visible = false;
        }

        void HideMenuBar()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            btnShowMenu_Click(sender, e);
        }
        private void timerHideMenu_Tick(object sender, EventArgs e)
        {
            if (this.pnlMenu1.Right <= 0)
            {
                timerHideMenu.Stop();
                this.pnlMenu1.Visible = false;
            }
            else
            {
                this.pnlMenu1.Left -= 30;
            }
        }

        private void timerShowMenu_Tick(object sender, EventArgs e)
        {
            if (this.pnlMenu1.Left >= this.btnShowMenu.Right)
            {
                timerShowMenu.Stop();
                this.pnlMenu1.Left = this.btnShowMenu.Right;
            }
              
            else
            {
                this.pnlMenu1.Left += 30;
            }
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu1.Left < 0)
            {
                this.pnlMenu1.Visible = true;
                timerShowMenu.Start();
                timerHideMenu.Stop();
            }
            else
            {
                /*this.pnlMenu.Visible = false;
                this.pnlMenu.Top = -1 * this.pnlMenu.Height;
                this.btnShowMenu.Visible = true;*/
                timerHideMenu.Start();
                timerShowMenu.Stop();
            }
        }

        private void btnLearnNewWord_Click(object sender, EventArgs e)
        {
            tabPreviewNewWord = new FPreviewNewWord();
            tabPreviewNewWord.AutoScroll = true;
            tabPreviewNewWord.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabPreviewNewWord);
           
            tabPreviewNewWord.FormBorderStyle = FormBorderStyle.None;
            tabPreviewNewWord.Show();
           /* this.pnlMenu.Visible = false;
            this.pnlMenu.Left = -1 * this.pnlMenu.Width;*/
            this.btnShowMenu.Visible = true;
            HideMenuBar();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            tabPractice = new FPractice();
            tabPractice.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabPractice);
            tabPractice.FormBorderStyle = FormBorderStyle.None;
            tabPractice.Show();
          /*  this.pnlMenu.Visible = false;
            this.pnlMenu.Left = -1 * this.pnlMenu.Width;*/
            this.btnShowMenu.Visible = true;
            HideMenuBar();
        }

        private void btnRevision_Click(object sender, EventArgs e)
        {
            tabRevision = new FRevision();
            tabRevision.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabRevision);
            tabRevision.FormBorderStyle = FormBorderStyle.None;
            tabRevision.Show();
          /*  this.pnlMenu.Visible = false;
            this.pnlMenu.Left = -1 * this.pnlMenu.Width;*/
            this.btnShowMenu.Visible = true;
            HideMenuBar();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            tabDictionary = new Dictionary();
            tabDictionary.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabDictionary);
            tabDictionary.FormBorderStyle = FormBorderStyle.None;
            tabDictionary.Show();
            /*this.pnlMenu.Visible = false;
            this.pnlMenu.Left = -1 * this.pnlMenu.Width;*/
            this.btnShowMenu.Visible = true;
            HideMenuBar();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabHome = new FIntroduction();
            tabHome.TopLevel = false;
            pnlLoadForm.Controls.Clear();
            pnlLoadForm.Controls.Add(tabHome);
            tabHome.FormBorderStyle = FormBorderStyle.None;
            tabHome.Show();
           /* this.pnlMenu.Visible = false;
            this.pnlMenu.Left = -1 * this.pnlMenu.Width;*/
            this.btnShowMenu.Visible = true;
            HideMenuBar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
