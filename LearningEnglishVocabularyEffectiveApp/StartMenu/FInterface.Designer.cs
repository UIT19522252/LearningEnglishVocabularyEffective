namespace StartMenu
{
    partial class FInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerHideMenu = new System.Windows.Forms.Timer(this.components);
            this.timerShowMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlStatusBar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnLearnNewWord = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnPractice = new Guna.UI2.WinForms.Guna2Button();
            this.btnDictionary = new Guna.UI2.WinForms.Guna2Button();
            this.btnRevision = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowMenu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLoadForm = new System.Windows.Forms.Panel();
            this.pnlStatusBar.SuspendLayout();
            this.pnlMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 70;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timerHideMenu
            // 
            this.timerHideMenu.Interval = 10;
            this.timerHideMenu.Tick += new System.EventHandler(this.timerHideMenu_Tick);
            // 
            // timerShowMenu
            // 
            this.timerShowMenu.Interval = 3;
            this.timerShowMenu.Tick += new System.EventHandler(this.timerShowMenu_Tick);
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.pnlStatusBar.Controls.Add(this.pnlMenu1);
            this.pnlStatusBar.Controls.Add(this.btnClose);
            this.pnlStatusBar.Controls.Add(this.btnShowMenu);
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 0);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.ShadowDecoration.Parent = this.pnlStatusBar;
            this.pnlStatusBar.Size = new System.Drawing.Size(1162, 55);
            this.pnlStatusBar.TabIndex = 2;
            // 
            // pnlMenu1
            // 
            this.pnlMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.pnlMenu1.BorderColor = System.Drawing.Color.White;
            this.pnlMenu1.Controls.Add(this.btnLearnNewWord);
            this.pnlMenu1.Controls.Add(this.btnHome);
            this.pnlMenu1.Controls.Add(this.btnPractice);
            this.pnlMenu1.Controls.Add(this.btnDictionary);
            this.pnlMenu1.Controls.Add(this.btnRevision);
            this.pnlMenu1.CustomBorderColor = System.Drawing.Color.White;
            this.pnlMenu1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.pnlMenu1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.pnlMenu1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.pnlMenu1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.pnlMenu1.ForeColor = System.Drawing.Color.White;
            this.pnlMenu1.Location = new System.Drawing.Point(46, 3);
            this.pnlMenu1.Name = "pnlMenu1";
            this.pnlMenu1.ShadowDecoration.Parent = this.pnlMenu1;
            this.pnlMenu1.Size = new System.Drawing.Size(1061, 47);
            this.pnlMenu1.TabIndex = 0;
            // 
            // btnLearnNewWord
            // 
            this.btnLearnNewWord.BorderColor = System.Drawing.Color.White;
            this.btnLearnNewWord.BorderThickness = 2;
            this.btnLearnNewWord.CheckedState.Parent = this.btnLearnNewWord;
            this.btnLearnNewWord.CustomImages.Parent = this.btnLearnNewWord;
            this.btnLearnNewWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnLearnNewWord.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLearnNewWord.ForeColor = System.Drawing.Color.White;
            this.btnLearnNewWord.HoverState.Parent = this.btnLearnNewWord;
            this.btnLearnNewWord.Location = new System.Drawing.Point(8, 7);
            this.btnLearnNewWord.Name = "btnLearnNewWord";
            this.btnLearnNewWord.ShadowDecoration.Parent = this.btnLearnNewWord;
            this.btnLearnNewWord.Size = new System.Drawing.Size(213, 40);
            this.btnLearnNewWord.TabIndex = 1;
            this.btnLearnNewWord.Text = "Learn New Words";
            this.btnLearnNewWord.Click += new System.EventHandler(this.btnLearnNewWord_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderColor = System.Drawing.Color.White;
            this.btnHome.BorderThickness = 2;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnHome.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(845, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.BorderColor = System.Drawing.Color.White;
            this.btnPractice.BorderThickness = 2;
            this.btnPractice.CheckedState.Parent = this.btnPractice;
            this.btnPractice.CustomImages.Parent = this.btnPractice;
            this.btnPractice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnPractice.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPractice.ForeColor = System.Drawing.Color.White;
            this.btnPractice.HoverState.Parent = this.btnPractice;
            this.btnPractice.Location = new System.Drawing.Point(227, 7);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.ShadowDecoration.Parent = this.btnPractice;
            this.btnPractice.Size = new System.Drawing.Size(200, 40);
            this.btnPractice.TabIndex = 6;
            this.btnPractice.Text = "Practice";
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.BorderColor = System.Drawing.Color.White;
            this.btnDictionary.BorderThickness = 2;
            this.btnDictionary.CheckedState.Parent = this.btnDictionary;
            this.btnDictionary.CustomImages.Parent = this.btnDictionary;
            this.btnDictionary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnDictionary.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDictionary.ForeColor = System.Drawing.Color.White;
            this.btnDictionary.HoverState.Parent = this.btnDictionary;
            this.btnDictionary.Location = new System.Drawing.Point(639, 7);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.ShadowDecoration.Parent = this.btnDictionary;
            this.btnDictionary.Size = new System.Drawing.Size(200, 40);
            this.btnDictionary.TabIndex = 4;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnRevision
            // 
            this.btnRevision.BorderColor = System.Drawing.Color.White;
            this.btnRevision.BorderThickness = 2;
            this.btnRevision.CheckedState.Parent = this.btnRevision;
            this.btnRevision.CustomImages.Parent = this.btnRevision;
            this.btnRevision.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnRevision.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRevision.ForeColor = System.Drawing.Color.White;
            this.btnRevision.HoverState.Parent = this.btnRevision;
            this.btnRevision.Location = new System.Drawing.Point(433, 7);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.ShadowDecoration.Parent = this.btnRevision;
            this.btnRevision.Size = new System.Drawing.Size(200, 40);
            this.btnRevision.TabIndex = 5;
            this.btnRevision.Text = "Revision";
            this.btnRevision.Click += new System.EventHandler(this.btnRevision_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::StartMenu.Properties.Resources.nônnnon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1113, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnShowMenu.BackgroundImage = global::StartMenu.Properties.Resources.oke;
            this.btnShowMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowMenu.CheckedState.Parent = this.btnShowMenu;
            this.btnShowMenu.CustomImages.Parent = this.btnShowMenu;
            this.btnShowMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnShowMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowMenu.ForeColor = System.Drawing.Color.White;
            this.btnShowMenu.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowMenu.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowMenu.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowMenu.HoverState.Parent = this.btnShowMenu;
            this.btnShowMenu.Location = new System.Drawing.Point(7, 12);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.ShadowDecoration.Parent = this.btnShowMenu;
            this.btnShowMenu.Size = new System.Drawing.Size(35, 35);
            this.btnShowMenu.TabIndex = 1;
            this.btnShowMenu.UseTransparentBackground = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // pnlLoadForm
            // 
            this.pnlLoadForm.BackColor = System.Drawing.Color.White;
            this.pnlLoadForm.Location = new System.Drawing.Point(0, 53);
            this.pnlLoadForm.Name = "pnlLoadForm";
            this.pnlLoadForm.Size = new System.Drawing.Size(1162, 628);
            this.pnlLoadForm.TabIndex = 3;
            // 
            // FInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 678);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.pnlLoadForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FInterface";
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMenu1;
        private Guna.UI2.WinForms.Guna2Button btnShowMenu;
        private System.Windows.Forms.Timer timerHideMenu;
        private System.Windows.Forms.Timer timerShowMenu;
        private Guna.UI2.WinForms.Guna2Button btnPractice;
        private Guna.UI2.WinForms.Guna2Button btnRevision;
        private Guna.UI2.WinForms.Guna2Button btnDictionary;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnLearnNewWord;
        private Guna.UI2.WinForms.Guna2Panel pnlStatusBar;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Panel pnlLoadForm;
    }
}