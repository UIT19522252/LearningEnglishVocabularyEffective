namespace StartMenu
{
    partial class FPractice
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
            this.btGame1 = new Guna.UI2.WinForms.Guna2Button();
            this.btGame2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btGame1
            // 
            this.btGame1.AutoRoundedCorners = true;
            this.btGame1.BackColor = System.Drawing.Color.Transparent;
            this.btGame1.BorderRadius = 37;
            this.btGame1.CheckedState.Parent = this.btGame1;
            this.btGame1.CustomImages.Parent = this.btGame1;
            this.btGame1.FillColor = System.Drawing.Color.Transparent;
            this.btGame1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btGame1.ForeColor = System.Drawing.Color.White;
            this.btGame1.HoverState.Parent = this.btGame1;
            this.btGame1.Location = new System.Drawing.Point(207, 296);
            this.btGame1.Name = "btGame1";
            this.btGame1.ShadowDecoration.Parent = this.btGame1;
            this.btGame1.Size = new System.Drawing.Size(776, 76);
            this.btGame1.TabIndex = 0;
            this.btGame1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btGame2
            // 
            this.btGame2.AutoRoundedCorners = true;
            this.btGame2.BackColor = System.Drawing.Color.Transparent;
            this.btGame2.BorderRadius = 35;
            this.btGame2.CheckedState.Parent = this.btGame2;
            this.btGame2.CustomImages.Parent = this.btGame2;
            this.btGame2.FillColor = System.Drawing.Color.Transparent;
            this.btGame2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btGame2.ForeColor = System.Drawing.Color.White;
            this.btGame2.HoverState.Parent = this.btGame2;
            this.btGame2.Location = new System.Drawing.Point(207, 411);
            this.btGame2.Name = "btGame2";
            this.btGame2.ShadowDecoration.Parent = this.btGame2;
            this.btGame2.Size = new System.Drawing.Size(775, 72);
            this.btGame2.TabIndex = 1;
            this.btGame2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoad.Location = new System.Drawing.Point(1009, 55);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(200, 100);
            this.pnlLoad.TabIndex = 2;
            // 
            // FPractice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.Practice4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 620);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.btGame2);
            this.Controls.Add(this.btGame1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPractice";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btGame1;
        private Guna.UI2.WinForms.Guna2Button btGame2;
        private System.Windows.Forms.Panel pnlLoad;
    }
}