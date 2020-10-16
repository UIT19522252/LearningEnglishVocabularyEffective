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
            this.btnPRgame1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPRgame2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPRreturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnPRuser = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btnPRgame1
            // 
            this.btnPRgame1.AutoRoundedCorners = true;
            this.btnPRgame1.BackColor = System.Drawing.Color.Transparent;
            this.btnPRgame1.BorderRadius = 41;
            this.btnPRgame1.CheckedState.Parent = this.btnPRgame1;
            this.btnPRgame1.CustomImages.Parent = this.btnPRgame1;
            this.btnPRgame1.FillColor = System.Drawing.Color.Transparent;
            this.btnPRgame1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPRgame1.ForeColor = System.Drawing.Color.Transparent;
            this.btnPRgame1.HoverState.Parent = this.btnPRgame1;
            this.btnPRgame1.Location = new System.Drawing.Point(209, 317);
            this.btnPRgame1.Name = "btnPRgame1";
            this.btnPRgame1.ShadowDecoration.Parent = this.btnPRgame1;
            this.btnPRgame1.Size = new System.Drawing.Size(788, 85);
            this.btnPRgame1.TabIndex = 2;
            this.btnPRgame1.Text = "guna2Button2";
            // 
            // btnPRgame2
            // 
            this.btnPRgame2.AutoRoundedCorners = true;
            this.btnPRgame2.BackColor = System.Drawing.Color.Transparent;
            this.btnPRgame2.BorderRadius = 38;
            this.btnPRgame2.CheckedState.Parent = this.btnPRgame2;
            this.btnPRgame2.CustomImages.Parent = this.btnPRgame2;
            this.btnPRgame2.FillColor = System.Drawing.Color.Transparent;
            this.btnPRgame2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPRgame2.ForeColor = System.Drawing.Color.Transparent;
            this.btnPRgame2.HoverState.Parent = this.btnPRgame2;
            this.btnPRgame2.Location = new System.Drawing.Point(222, 443);
            this.btnPRgame2.Name = "btnPRgame2";
            this.btnPRgame2.ShadowDecoration.Parent = this.btnPRgame2;
            this.btnPRgame2.Size = new System.Drawing.Size(784, 79);
            this.btnPRgame2.TabIndex = 3;
            this.btnPRgame2.Text = "guna2Button1";
            // 
            // btnPRreturn
            // 
            this.btnPRreturn.BackColor = System.Drawing.Color.Transparent;
            this.btnPRreturn.CheckedState.Parent = this.btnPRreturn;
            this.btnPRreturn.CustomImages.Parent = this.btnPRreturn;
            this.btnPRreturn.FillColor = System.Drawing.Color.Transparent;
            this.btnPRreturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPRreturn.ForeColor = System.Drawing.Color.Transparent;
            this.btnPRreturn.HoverState.Parent = this.btnPRreturn;
            this.btnPRreturn.Location = new System.Drawing.Point(12, 12);
            this.btnPRreturn.Name = "btnPRreturn";
            this.btnPRreturn.ShadowDecoration.Parent = this.btnPRreturn;
            this.btnPRreturn.Size = new System.Drawing.Size(69, 66);
            this.btnPRreturn.TabIndex = 5;
            this.btnPRreturn.Text = "guna2Button4";
            // 
            // btnPRuser
            // 
            this.btnPRuser.BackColor = System.Drawing.Color.Transparent;
            this.btnPRuser.CheckedState.Parent = this.btnPRuser;
            this.btnPRuser.CustomImages.Parent = this.btnPRuser;
            this.btnPRuser.FillColor = System.Drawing.Color.Transparent;
            this.btnPRuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPRuser.ForeColor = System.Drawing.Color.Transparent;
            this.btnPRuser.HoverState.Parent = this.btnPRuser;
            this.btnPRuser.Location = new System.Drawing.Point(888, 12);
            this.btnPRuser.Name = "btnPRuser";
            this.btnPRuser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPRuser.ShadowDecoration.Parent = this.btnPRuser;
            this.btnPRuser.Size = new System.Drawing.Size(48, 46);
            this.btnPRuser.TabIndex = 6;
            this.btnPRuser.Text = "guna2CircleButton1";
            // 
            // FPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StartMenu.Properties.Resources.Practice;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.btnPRuser);
            this.Controls.Add(this.btnPRreturn);
            this.Controls.Add(this.btnPRgame2);
            this.Controls.Add(this.btnPRgame1);
            this.Name = "FPractice";
            this.Text = "PRACTICE";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPRgame1;
        private Guna.UI2.WinForms.Guna2Button btnPRgame2;
        private Guna.UI2.WinForms.Guna2Button btnPRreturn;
        private Guna.UI2.WinForms.Guna2CircleButton btnPRuser;
    }
}