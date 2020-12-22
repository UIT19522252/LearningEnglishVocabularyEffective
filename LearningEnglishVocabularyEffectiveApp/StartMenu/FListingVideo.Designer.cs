namespace StartMenu
{
    partial class FListingVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListingVideo));
            this.label1 = new System.Windows.Forms.Label();
            this.BFILM = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BCARTOON = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BSHOW = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(349, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐÂY LÀ FORM VIDEO";
            // 
            // BFILM
            // 
            this.BFILM.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BFILM.CheckedState.Parent = this.BFILM;
            this.BFILM.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.BFILM.HoverState.Parent = this.BFILM;
            this.BFILM.Image = ((System.Drawing.Image)(resources.GetObject("BFILM.Image")));
            this.BFILM.ImageRotate = 0F;
            this.BFILM.Location = new System.Drawing.Point(500, 175);
            this.BFILM.Name = "BFILM";
            this.BFILM.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BFILM.PressedState.Parent = this.BFILM;
            this.BFILM.Size = new System.Drawing.Size(185, 180);
            this.BFILM.TabIndex = 2;
            // 
            // BCARTOON
            // 
            this.BCARTOON.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BCARTOON.CheckedState.Parent = this.BCARTOON;
            this.BCARTOON.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.BCARTOON.HoverState.Parent = this.BCARTOON;
            this.BCARTOON.Image = ((System.Drawing.Image)(resources.GetObject("BCARTOON.Image")));
            this.BCARTOON.ImageRotate = 0F;
            this.BCARTOON.Location = new System.Drawing.Point(843, 175);
            this.BCARTOON.Name = "BCARTOON";
            this.BCARTOON.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BCARTOON.PressedState.Parent = this.BCARTOON;
            this.BCARTOON.Size = new System.Drawing.Size(185, 180);
            this.BCARTOON.TabIndex = 3;
            // 
            // BSHOW
            // 
            this.BSHOW.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BSHOW.CheckedState.Parent = this.BSHOW;
            this.BSHOW.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.BSHOW.HoverState.Parent = this.BSHOW;
            this.BSHOW.Image = ((System.Drawing.Image)(resources.GetObject("BSHOW.Image")));
            this.BSHOW.ImageRotate = 0F;
            this.BSHOW.Location = new System.Drawing.Point(168, 175);
            this.BSHOW.Name = "BSHOW";
            this.BSHOW.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BSHOW.PressedState.Parent = this.BSHOW;
            this.BSHOW.Size = new System.Drawing.Size(185, 180);
            this.BSHOW.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(182, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "SHOW";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(526, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "FILM";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(812, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "CARTOON";
            // 
            // FListingVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BSHOW);
            this.Controls.Add(this.BCARTOON);
            this.Controls.Add(this.BFILM);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FListingVideo";
            this.Text = "FListingVideo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton BFILM;
        private Guna.UI2.WinForms.Guna2ImageButton BCARTOON;
        private Guna.UI2.WinForms.Guna2ImageButton BSHOW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}