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
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
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
            this.btnDone.BorderRadius = 70;
            this.btnDone.BorderThickness = 2;
            this.btnDone.CheckedState.Parent = this.btnDone;
            this.btnDone.CustomImages.Parent = this.btnDone;
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnDone.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.HoverState.Parent = this.btnDone;
            this.btnDone.Location = new System.Drawing.Point(434, 396);
            this.btnDone.Name = "btnDone";
            this.btnDone.ShadowDecoration.Parent = this.btnDone;
            this.btnDone.Size = new System.Drawing.Size(315, 142);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "OK";
            this.btnDone.UseTransparentBackground = true;
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
            this.AnswerB.Click += new System.EventHandler(this.Answer);
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
            this.AnswerA.Click += new System.EventHandler(this.Answer);
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
            this.AnswerD.Click += new System.EventHandler(this.Answer);
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
            this.AnswerC.Click += new System.EventHandler(this.Answer);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.guna2Button6.BorderRadius = 20;
            this.guna2Button6.BorderThickness = 3;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("FS Nokio Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Location = new System.Drawing.Point(461, 159);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(260, 60);
            this.guna2Button6.TabIndex = 17;
            this.guna2Button6.Text = "Questions";
            // 
            // FLearnNewWord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.LearnNewWords3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.AnswerA);
            this.Controls.Add(this.AnswerB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FLearnNewWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARN NEW WORDS";
            this.Load += new System.EventHandler(this.FLearnNewWord_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button lblCorrect;
        private System.Windows.Forms.Timer TimerVisitable;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button AnswerB;
        private Guna.UI2.WinForms.Guna2Button AnswerA;
        private Guna.UI2.WinForms.Guna2Button AnswerD;
        private Guna.UI2.WinForms.Guna2Button AnswerC;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
    }
}