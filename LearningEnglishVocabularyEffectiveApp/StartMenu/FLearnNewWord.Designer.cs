namespace StartMenu
{
    partial class FLearnNewWord
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
            this.lblCorrect = new Guna.UI2.WinForms.Guna2Button();
            this.TimerVisitable = new System.Windows.Forms.Timer(this.components);
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.AnswerB = new Guna.UI2.WinForms.Guna2Button();
            this.AnswerA = new Guna.UI2.WinForms.Guna2Button();
            this.AnswerD = new Guna.UI2.WinForms.Guna2Button();
            this.AnswerC = new Guna.UI2.WinForms.Guna2Button();
            this.Questions = new Guna.UI2.WinForms.Guna2Button();
            this.btnScore = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.lblWordRL = new System.Windows.Forms.Label();
            this.TimerWrong = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnLearnAgain = new Guna.UI2.WinForms.Guna2Button();
            this.timerOutOfTime = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCorrect
            // 
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.CheckedState.Parent = this.lblCorrect;
            this.lblCorrect.CustomImages.Parent = this.lblCorrect;
            this.lblCorrect.FillColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Red;
            this.lblCorrect.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.lblCorrect.HoverState.Parent = this.lblCorrect;
            this.lblCorrect.Location = new System.Drawing.Point(12, 187);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.ShadowDecoration.Parent = this.lblCorrect;
            this.lblCorrect.Size = new System.Drawing.Size(1158, 113);
            this.lblCorrect.TabIndex = 6;
            this.lblCorrect.Text = "Correct!";
            this.lblCorrect.UseTransparentBackground = true;
            // 
            // TimerVisitable
            // 
            this.TimerVisitable.Interval = 1000;
            this.TimerVisitable.Tick += new System.EventHandler(this.TimerVisitable_Tick);
            // 
            // btnDone
            // 
            this.btnDone.AutoRoundedCorners = true;
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BorderColor = System.Drawing.Color.White;
            this.btnDone.BorderRadius = 37;
            this.btnDone.BorderThickness = 2;
            this.btnDone.CheckedState.Parent = this.btnDone;
            this.btnDone.CustomImages.Parent = this.btnDone;
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnDone.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.HoverState.Parent = this.btnDone;
            this.btnDone.Location = new System.Drawing.Point(296, 407);
            this.btnDone.Name = "btnDone";
            this.btnDone.ShadowDecoration.Parent = this.btnDone;
            this.btnDone.Size = new System.Drawing.Size(248, 77);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Learn Next";
            this.btnDone.UseTransparentBackground = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // AnswerB
            // 
            this.AnswerB.BackColor = System.Drawing.Color.Transparent;
            this.AnswerB.BorderRadius = 25;
            this.AnswerB.CheckedState.Parent = this.AnswerB;
            this.AnswerB.CustomImages.Parent = this.AnswerB;
            this.AnswerB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.AnswerB.Font = new System.Drawing.Font("FS Nokio Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AnswerB.ForeColor = System.Drawing.Color.White;
            this.AnswerB.HoverState.Parent = this.AnswerB;
            this.AnswerB.Location = new System.Drawing.Point(658, 260);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.ShadowDecoration.Parent = this.AnswerB;
            this.AnswerB.Size = new System.Drawing.Size(252, 144);
            this.AnswerB.TabIndex = 13;
            this.AnswerB.Text = "B.";
            this.AnswerB.UseTransparentBackground = true;
            this.AnswerB.Click += new System.EventHandler(this.AnswerB_Click);
            // 
            // AnswerA
            // 
            this.AnswerA.BackColor = System.Drawing.Color.Transparent;
            this.AnswerA.BorderRadius = 25;
            this.AnswerA.CheckedState.Parent = this.AnswerA;
            this.AnswerA.CustomImages.Parent = this.AnswerA;
            this.AnswerA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.AnswerA.Font = new System.Drawing.Font("FS Nokio Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AnswerA.ForeColor = System.Drawing.Color.White;
            this.AnswerA.HoverState.Parent = this.AnswerA;
            this.AnswerA.Location = new System.Drawing.Point(273, 260);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.ShadowDecoration.Parent = this.AnswerA;
            this.AnswerA.Size = new System.Drawing.Size(252, 144);
            this.AnswerA.TabIndex = 14;
            this.AnswerA.Text = "A.";
            this.AnswerA.UseTransparentBackground = true;
            this.AnswerA.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerD
            // 
            this.AnswerD.BackColor = System.Drawing.Color.Transparent;
            this.AnswerD.BorderRadius = 25;
            this.AnswerD.CheckedState.Parent = this.AnswerD;
            this.AnswerD.CustomImages.Parent = this.AnswerD;
            this.AnswerD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.AnswerD.Font = new System.Drawing.Font("FS Nokio Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AnswerD.ForeColor = System.Drawing.Color.White;
            this.AnswerD.HoverState.Parent = this.AnswerD;
            this.AnswerD.Location = new System.Drawing.Point(658, 425);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.ShadowDecoration.Parent = this.AnswerD;
            this.AnswerD.Size = new System.Drawing.Size(252, 144);
            this.AnswerD.TabIndex = 15;
            this.AnswerD.Text = "D.";
            this.AnswerD.UseTransparentBackground = true;
            this.AnswerD.Click += new System.EventHandler(this.AnswerD_Click);
            // 
            // AnswerC
            // 
            this.AnswerC.BackColor = System.Drawing.Color.Transparent;
            this.AnswerC.BorderRadius = 25;
            this.AnswerC.CheckedState.Parent = this.AnswerC;
            this.AnswerC.CustomImages.Parent = this.AnswerC;
            this.AnswerC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.AnswerC.Font = new System.Drawing.Font("FS Nokio Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AnswerC.ForeColor = System.Drawing.Color.White;
            this.AnswerC.HoverState.Parent = this.AnswerC;
            this.AnswerC.Location = new System.Drawing.Point(273, 425);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.ShadowDecoration.Parent = this.AnswerC;
            this.AnswerC.Size = new System.Drawing.Size(252, 144);
            this.AnswerC.TabIndex = 16;
            this.AnswerC.Text = "C.";
            this.AnswerC.UseTransparentBackground = true;
            this.AnswerC.Click += new System.EventHandler(this.AnswerC_Click);
            // 
            // Questions
            // 
            this.Questions.BackColor = System.Drawing.Color.Transparent;
            this.Questions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.Questions.BorderRadius = 20;
            this.Questions.BorderThickness = 3;
            this.Questions.CheckedState.Parent = this.Questions;
            this.Questions.CustomImages.Parent = this.Questions;
            this.Questions.FillColor = System.Drawing.Color.Transparent;
            this.Questions.Font = new System.Drawing.Font("FS Nokio Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Questions.ForeColor = System.Drawing.Color.Black;
            this.Questions.HoverState.Parent = this.Questions;
            this.Questions.Location = new System.Drawing.Point(461, 159);
            this.Questions.Name = "Questions";
            this.Questions.ShadowDecoration.Parent = this.Questions;
            this.Questions.Size = new System.Drawing.Size(260, 60);
            this.Questions.TabIndex = 17;
            this.Questions.Text = "Questions";
            // 
            // btnScore
            // 
            this.btnScore.AutoRoundedCorners = true;
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BorderRadius = 31;
            this.btnScore.CheckedState.Parent = this.btnScore;
            this.btnScore.CustomImages.Parent = this.btnScore;
            this.btnScore.FillColor = System.Drawing.Color.DarkRed;
            this.btnScore.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.HoverState.Parent = this.btnScore;
            this.btnScore.Location = new System.Drawing.Point(1070, 12);
            this.btnScore.Name = "btnScore";
            this.btnScore.ShadowDecoration.Parent = this.btnScore;
            this.btnScore.Size = new System.Drawing.Size(65, 65);
            this.btnScore.TabIndex = 18;
            this.btnScore.Text = "0";
            this.btnScore.UseTransparentBackground = true;
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.White;
            this.pnlLoad.BackgroundImage = global::StartMenu.Properties.Resources.LearnNewWords4;
            this.pnlLoad.Controls.Add(this.btnOK);
            this.pnlLoad.Controls.Add(this.lblWordRL);
            this.pnlLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoad.Location = new System.Drawing.Point(0, 0);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(1182, 628);
            this.pnlLoad.TabIndex = 19;
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 20;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(94)))));
            this.btnOK.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(478, 410);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(243, 73);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblWordRL
            // 
            this.lblWordRL.Font = new System.Drawing.Font("FS Nokio Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWordRL.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWordRL.Location = new System.Drawing.Point(12, 260);
            this.lblWordRL.Name = "lblWordRL";
            this.lblWordRL.Size = new System.Drawing.Size(1158, 68);
            this.lblWordRL.TabIndex = 0;
            this.lblWordRL.Text = "label1";
            this.lblWordRL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerWrong
            // 
            this.TimerWrong.Interval = 1000;
            this.TimerWrong.Tick += new System.EventHandler(this.TimerWrong_Tick);
            // 
            // btnHome
            // 
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.White;
            this.btnHome.BorderRadius = 37;
            this.btnHome.BorderThickness = 2;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnHome.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(639, 407);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(248, 77);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLearnAgain
            // 
            this.btnLearnAgain.AutoRoundedCorners = true;
            this.btnLearnAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnLearnAgain.BorderColor = System.Drawing.Color.White;
            this.btnLearnAgain.BorderRadius = 37;
            this.btnLearnAgain.BorderThickness = 2;
            this.btnLearnAgain.CheckedState.Parent = this.btnLearnAgain;
            this.btnLearnAgain.CustomImages.Parent = this.btnLearnAgain;
            this.btnLearnAgain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnLearnAgain.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnLearnAgain.ForeColor = System.Drawing.Color.White;
            this.btnLearnAgain.HoverState.Parent = this.btnLearnAgain;
            this.btnLearnAgain.Location = new System.Drawing.Point(467, 406);
            this.btnLearnAgain.Name = "btnLearnAgain";
            this.btnLearnAgain.ShadowDecoration.Parent = this.btnLearnAgain;
            this.btnLearnAgain.Size = new System.Drawing.Size(248, 77);
            this.btnLearnAgain.TabIndex = 21;
            this.btnLearnAgain.Text = "OK";
            this.btnLearnAgain.UseTransparentBackground = true;
            this.btnLearnAgain.Visible = false;
            this.btnLearnAgain.Click += new System.EventHandler(this.btnLearnAgain_Click);
            // 
            // timerOutOfTime
            // 
            this.timerOutOfTime.Interval = 1000;
            this.timerOutOfTime.Tick += new System.EventHandler(this.timerOutOfTime_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(20, 22);
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "0";
            // 
            // FLearnNewWord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.LearnNewWords4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLearnAgain);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.Questions);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.AnswerA);
            this.Controls.Add(this.AnswerB);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FLearnNewWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARN NEW WORDS";
            this.Load += new System.EventHandler(this.FLearnNewWord_Load);
            this.pnlLoad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button lblCorrect;
        private System.Windows.Forms.Timer TimerVisitable;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button AnswerB;
        private Guna.UI2.WinForms.Guna2Button AnswerA;
        private Guna.UI2.WinForms.Guna2Button AnswerD;
        private Guna.UI2.WinForms.Guna2Button AnswerC;
        private Guna.UI2.WinForms.Guna2Button Questions;
        private Guna.UI2.WinForms.Guna2Button btnScore;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.Timer TimerWrong;
        private System.Windows.Forms.Label lblWordRL;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnLearnAgain;
        private System.Windows.Forms.Timer timerOutOfTime;
        private System.Windows.Forms.Label lblTime;
    }
}