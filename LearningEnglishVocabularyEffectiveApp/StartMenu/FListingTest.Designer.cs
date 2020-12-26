namespace StartMenu
{
    partial class FListingTest
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
            this.A = new System.Windows.Forms.CheckBox();
            this.B = new System.Windows.Forms.CheckBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.D = new System.Windows.Forms.CheckBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbIncorrect = new System.Windows.Forms.Label();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.btNote = new Guna.UI2.WinForms.Guna2Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btketqua = new Guna.UI2.WinForms.Guna2Button();
            this.btAfter = new Guna.UI2.WinForms.Guna2Button();
            this.btBefore = new Guna.UI2.WinForms.Guna2Button();
            this.Pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("FS Nokio Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A.Location = new System.Drawing.Point(130, 110);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(18, 17);
            this.A.TabIndex = 1;
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("FS Nokio Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.B.Location = new System.Drawing.Point(130, 201);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(18, 17);
            this.B.TabIndex = 2;
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("FS Nokio Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.C.Location = new System.Drawing.Point(130, 285);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(18, 17);
            this.C.TabIndex = 3;
            this.C.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("FS Nokio Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.D.Location = new System.Drawing.Point(130, 370);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(18, 17);
            this.D.TabIndex = 4;
            this.D.UseVisualStyleBackColor = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImage = global::StartMenu.Properties.Resources.SPEAEKER;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(568, 19);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(45, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pic);
            this.panel1.Location = new System.Drawing.Point(656, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 428);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btBefore);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 447);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btAfter);
            this.panel3.Location = new System.Drawing.Point(1044, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 442);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.lbIncorrect);
            this.panel4.Controls.Add(this.lbCorrect);
            this.panel4.Controls.Add(this.btNote);
            this.panel4.Controls.Add(this.guna2Button1);
            this.panel4.Controls.Add(this.lbKetQua);
            this.panel4.Controls.Add(this.btketqua);
            this.panel4.Controls.Add(this.A);
            this.panel4.Controls.Add(this.B);
            this.panel4.Controls.Add(this.C);
            this.panel4.Controls.Add(this.D);
            this.panel4.Location = new System.Drawing.Point(6, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1172, 536);
            this.panel4.TabIndex = 11;
            // 
            // lbIncorrect
            // 
            this.lbIncorrect.AutoSize = true;
            this.lbIncorrect.Font = new System.Drawing.Font("FS Nokio Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lbIncorrect.Location = new System.Drawing.Point(151, 432);
            this.lbIncorrect.Name = "lbIncorrect";
            this.lbIncorrect.Size = new System.Drawing.Size(101, 34);
            this.lbIncorrect.TabIndex = 8;
            this.lbIncorrect.Text = "Incorrect";
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrect.ForeColor = System.Drawing.Color.Red;
            this.lbCorrect.Location = new System.Drawing.Point(151, 432);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(83, 25);
            this.lbCorrect.TabIndex = 7;
            this.lbCorrect.Text = "Correct";
            // 
            // btNote
            // 
            this.btNote.BorderRadius = 15;
            this.btNote.CheckedState.Parent = this.btNote;
            this.btNote.CustomImages.Parent = this.btNote;
            this.btNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btNote.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNote.ForeColor = System.Drawing.Color.White;
            this.btNote.HoverState.Parent = this.btNote;
            this.btNote.Location = new System.Drawing.Point(803, 474);
            this.btNote.Name = "btNote";
            this.btNote.ShadowDecoration.Parent = this.btNote;
            this.btNote.Size = new System.Drawing.Size(180, 45);
            this.btNote.TabIndex = 6;
            this.btNote.Text = "Don\'t Appear again";
            this.btNote.Click += new System.EventHandler(this.btNote_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.Font = new System.Drawing.Font("FS Nokio Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKetQua.Location = new System.Drawing.Point(295, 490);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(220, 45);
            this.lbKetQua.TabIndex = 5;
            this.lbKetQua.Click += new System.EventHandler(this.lbKetQua_Click);
            // 
            // btketqua
            // 
            this.btketqua.BorderRadius = 15;
            this.btketqua.CheckedState.Parent = this.btketqua;
            this.btketqua.CustomImages.Parent = this.btketqua;
            this.btketqua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btketqua.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.btketqua.ForeColor = System.Drawing.Color.White;
            this.btketqua.HoverState.Parent = this.btketqua;
            this.btketqua.Location = new System.Drawing.Point(70, 474);
            this.btketqua.Name = "btketqua";
            this.btketqua.ShadowDecoration.Parent = this.btketqua;
            this.btketqua.Size = new System.Drawing.Size(180, 45);
            this.btketqua.TabIndex = 0;
            this.btketqua.Text = "Result";
            this.btketqua.Click += new System.EventHandler(this.btketqua_Click);
            // 
            // btAfter
            // 
            this.btAfter.BorderRadius = 5;
            this.btAfter.CheckedState.Parent = this.btAfter;
            this.btAfter.CustomImages.Parent = this.btAfter;
            this.btAfter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btAfter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btAfter.ForeColor = System.Drawing.Color.White;
            this.btAfter.HoverState.Parent = this.btAfter;
            this.btAfter.Image = global::StartMenu.Properties.Resources.next;
            this.btAfter.ImageSize = new System.Drawing.Size(50, 50);
            this.btAfter.Location = new System.Drawing.Point(4, 7);
            this.btAfter.Name = "btAfter";
            this.btAfter.ShadowDecoration.Parent = this.btAfter;
            this.btAfter.Size = new System.Drawing.Size(100, 425);
            this.btAfter.TabIndex = 7;
            this.btAfter.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btBefore
            // 
            this.btBefore.BorderRadius = 5;
            this.btBefore.CheckedState.Parent = this.btBefore;
            this.btBefore.CustomImages.Parent = this.btBefore;
            this.btBefore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btBefore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBefore.ForeColor = System.Drawing.Color.White;
            this.btBefore.HoverState.Parent = this.btBefore;
            this.btBefore.Image = global::StartMenu.Properties.Resources.previous;
            this.btBefore.ImageSize = new System.Drawing.Size(50, 50);
            this.btBefore.Location = new System.Drawing.Point(3, 19);
            this.btBefore.Name = "btBefore";
            this.btBefore.ShadowDecoration.Parent = this.btBefore;
            this.btBefore.Size = new System.Drawing.Size(100, 425);
            this.btBefore.TabIndex = 6;
            this.btBefore.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Pic
            // 
            this.Pic.Location = new System.Drawing.Point(-31, 0);
            this.Pic.Name = "Pic";
            this.Pic.ShadowDecoration.Parent = this.Pic;
            this.Pic.Size = new System.Drawing.Size(393, 425);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_Click);
            // 
            // FListingTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FListingTest";
            this.Text = "FListingTest";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Pic;
        private System.Windows.Forms.CheckBox A;
        private System.Windows.Forms.CheckBox B;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.CheckBox D;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btBefore;
        private Guna.UI2.WinForms.Guna2Button btAfter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btketqua;
        private System.Windows.Forms.Label lbKetQua;
        private Guna.UI2.WinForms.Guna2Button btNote;
        private System.Windows.Forms.Label lbIncorrect;
        private System.Windows.Forms.Label lbCorrect;
    }
}