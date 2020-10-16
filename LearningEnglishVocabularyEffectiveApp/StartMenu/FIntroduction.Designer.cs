namespace StartMenu
{
    partial class FIntroduction
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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 35;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(24, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(79, 73);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FIntroduction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.Introduction;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btnBack);
            this.Name = "FIntroduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}