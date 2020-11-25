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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblCorrect = new Guna.UI2.WinForms.Guna2Button();
            this.TimerVisitable = new System.Windows.Forms.Timer(this.components);
            this.AnswerA = new System.Windows.Forms.Button();
            this.AnswerC = new System.Windows.Forms.Button();
            this.AnswerB = new System.Windows.Forms.Button();
            this.AnswerD = new System.Windows.Forms.Button();
            this.Questions = new Guna.UI2.WinForms.Guna2Button();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 37;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(9, 8);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(83, 76);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.CheckedState.Parent = this.lblCorrect;
            this.lblCorrect.CustomImages.Parent = this.lblCorrect;
            this.lblCorrect.FillColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblCorrect.ForeColor = System.Drawing.Color.Red;
            this.lblCorrect.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.lblCorrect.HoverState.Parent = this.lblCorrect;
            this.lblCorrect.Location = new System.Drawing.Point(-4, 186);
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
            // AnswerA
            // 
            this.AnswerA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AnswerA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.AnswerA.ForeColor = System.Drawing.Color.Teal;
            this.AnswerA.Location = new System.Drawing.Point(173, 305);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(337, 98);
            this.AnswerA.TabIndex = 7;
            this.AnswerA.Text = "A.";
            this.AnswerA.UseVisualStyleBackColor = false;
            this.AnswerA.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerC
            // 
            this.AnswerC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AnswerC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.AnswerC.ForeColor = System.Drawing.Color.Teal;
            this.AnswerC.Location = new System.Drawing.Point(670, 305);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(337, 98);
            this.AnswerC.TabIndex = 8;
            this.AnswerC.Text = "C.";
            this.AnswerC.UseVisualStyleBackColor = false;
            this.AnswerC.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerB
            // 
            this.AnswerB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AnswerB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.AnswerB.ForeColor = System.Drawing.Color.Teal;
            this.AnswerB.Location = new System.Drawing.Point(173, 437);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(337, 98);
            this.AnswerB.TabIndex = 9;
            this.AnswerB.Text = "B.";
            this.AnswerB.UseVisualStyleBackColor = false;
            this.AnswerB.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerD
            // 
            this.AnswerD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AnswerD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.AnswerD.ForeColor = System.Drawing.Color.Teal;
            this.AnswerD.Location = new System.Drawing.Point(670, 437);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(337, 98);
            this.AnswerD.TabIndex = 10;
            this.AnswerD.Text = "D.";
            this.AnswerD.UseVisualStyleBackColor = false;
            this.AnswerD.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // Questions
            // 
            this.Questions.BackColor = System.Drawing.Color.Transparent;
            this.Questions.CheckedState.Parent = this.Questions;
            this.Questions.CustomImages.Parent = this.Questions;
            this.Questions.FillColor = System.Drawing.Color.Transparent;
            this.Questions.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Questions.ForeColor = System.Drawing.Color.DimGray;
            this.Questions.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Questions.HoverState.Parent = this.Questions;
            this.Questions.Location = new System.Drawing.Point(-11, 143);
            this.Questions.Name = "Questions";
            this.Questions.ShadowDecoration.Parent = this.Questions;
            this.Questions.Size = new System.Drawing.Size(1181, 99);
            this.Questions.TabIndex = 11;
            this.Questions.Text = "Question will go here";
            this.Questions.UseTransparentBackground = true;
            // 
            // btnDone
            // 
            this.btnDone.CheckedState.Parent = this.btnDone;
            this.btnDone.CustomImages.Parent = this.btnDone;
            this.btnDone.FillColor = System.Drawing.Color.Gainsboro;
            this.btnDone.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Teal;
            this.btnDone.HoverState.Parent = this.btnDone;
            this.btnDone.Location = new System.Drawing.Point(434, 336);
            this.btnDone.Name = "btnDone";
            this.btnDone.ShadowDecoration.Parent = this.btnDone;
            this.btnDone.Size = new System.Drawing.Size(315, 142);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "OK";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FLearnNewWord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.LearnNewWords;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.Questions);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.AnswerB);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerA);
            this.Controls.Add(this.guna2Button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FLearnNewWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARN NEW WORDS";
            this.Load += new System.EventHandler(this.FLearnNewWord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button lblCorrect;
        private System.Windows.Forms.Timer TimerVisitable;
        private System.Windows.Forms.Button AnswerA;
        private System.Windows.Forms.Button AnswerC;
        private System.Windows.Forms.Button AnswerB;
        private System.Windows.Forms.Button AnswerD;
        private Guna.UI2.WinForms.Guna2Button Questions;
        private Guna.UI2.WinForms.Guna2Button btnDone;
    }
}