namespace StartMenu
{
    partial class ReLearn
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
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.lblWordRL = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 25;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.btnOK.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(438, 389);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(306, 97);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK!!!";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblWordRL
            // 
            this.lblWordRL.BackColor = System.Drawing.Color.Transparent;
            this.lblWordRL.CheckedState.Parent = this.lblWordRL;
            this.lblWordRL.CustomImages.Parent = this.lblWordRL;
            this.lblWordRL.FillColor = System.Drawing.Color.Transparent;
            this.lblWordRL.Font = new System.Drawing.Font("FS Nokio Bold", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWordRL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.lblWordRL.HoverState.Parent = this.lblWordRL;
            this.lblWordRL.Location = new System.Drawing.Point(260, 260);
            this.lblWordRL.Name = "lblWordRL";
            this.lblWordRL.ShadowDecoration.Parent = this.lblWordRL;
            this.lblWordRL.Size = new System.Drawing.Size(662, 89);
            this.lblWordRL.TabIndex = 1;
            this.lblWordRL.Text = "Text go there";
            this.lblWordRL.UseTransparentBackground = true;
            this.lblWordRL.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ReLearn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.LearnNewWords4;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.lblWordRL);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReLearn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReLearn";
            this.Load += new System.EventHandler(this.ReLearn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button lblWordRL;
    }
}