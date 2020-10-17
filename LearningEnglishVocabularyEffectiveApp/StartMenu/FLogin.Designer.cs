namespace StartMenu
{
    partial class FLogin
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
			this.tbxUsrname = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.lblForgotPassword = new System.Windows.Forms.Label();
			this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// tbxUsrname
			// 
			this.tbxUsrname.AutoRoundedCorners = true;
			this.tbxUsrname.BackColor = System.Drawing.Color.Transparent;
			this.tbxUsrname.BorderColor = System.Drawing.Color.Aqua;
			this.tbxUsrname.BorderRadius = 21;
			this.tbxUsrname.BorderThickness = 2;
			this.tbxUsrname.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbxUsrname.DefaultText = "";
			this.tbxUsrname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbxUsrname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbxUsrname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbxUsrname.DisabledState.Parent = this.tbxUsrname;
			this.tbxUsrname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbxUsrname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbxUsrname.FocusedState.Parent = this.tbxUsrname;
			this.tbxUsrname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.tbxUsrname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbxUsrname.HoverState.Parent = this.tbxUsrname;
			this.tbxUsrname.Location = new System.Drawing.Point(418, 236);
			this.tbxUsrname.Margin = new System.Windows.Forms.Padding(4);
			this.tbxUsrname.Name = "tbxUsrname";
			this.tbxUsrname.PasswordChar = '\0';
			this.tbxUsrname.PlaceholderText = "Your user name";
			this.tbxUsrname.SelectedText = "";
			this.tbxUsrname.ShadowDecoration.Parent = this.tbxUsrname;
			this.tbxUsrname.Size = new System.Drawing.Size(396, 45);
			this.tbxUsrname.TabIndex = 0;
			this.tbxUsrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbxPassword
			// 
			this.tbxPassword.AutoRoundedCorners = true;
			this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
			this.tbxPassword.BorderColor = System.Drawing.Color.Aqua;
			this.tbxPassword.BorderRadius = 21;
			this.tbxPassword.BorderThickness = 2;
			this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbxPassword.DefaultText = "";
			this.tbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbxPassword.DisabledState.Parent = this.tbxPassword;
			this.tbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbxPassword.FocusedState.Parent = this.tbxPassword;
			this.tbxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.tbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbxPassword.HoverState.Parent = this.tbxPassword;
			this.tbxPassword.Location = new System.Drawing.Point(418, 289);
			this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.PasswordChar = '*';
			this.tbxPassword.PlaceholderText = "Your password";
			this.tbxPassword.SelectedText = "";
			this.tbxPassword.ShadowDecoration.Parent = this.tbxPassword;
			this.tbxPassword.Size = new System.Drawing.Size(396, 45);
			this.tbxPassword.TabIndex = 1;
			this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnLogin
			// 
			this.btnLogin.Animated = true;
			this.btnLogin.AutoRoundedCorners = true;
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BorderColor = System.Drawing.Color.White;
			this.btnLogin.BorderRadius = 21;
			this.btnLogin.BorderThickness = 2;
			this.btnLogin.CheckedState.Parent = this.btnLogin;
			this.btnLogin.CustomImages.Parent = this.btnLogin;
			this.btnLogin.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.Parent = this.btnLogin;
			this.btnLogin.Location = new System.Drawing.Point(488, 354);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
			this.btnLogin.Size = new System.Drawing.Size(280, 45);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Log in";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblForgotPassword
			// 
			this.lblForgotPassword.AutoSize = true;
			this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblForgotPassword.ForeColor = System.Drawing.Color.Sienna;
			this.lblForgotPassword.Location = new System.Drawing.Point(576, 402);
			this.lblForgotPassword.Name = "lblForgotPassword";
			this.lblForgotPassword.Size = new System.Drawing.Size(89, 13);
			this.lblForgotPassword.TabIndex = 3;
			this.lblForgotPassword.Text = "Forgot Pasword?";
			// 
			// btnSignUp
			// 
			this.btnSignUp.Animated = true;
			this.btnSignUp.AutoRoundedCorners = true;
			this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
			this.btnSignUp.BorderColor = System.Drawing.Color.White;
			this.btnSignUp.BorderRadius = 21;
			this.btnSignUp.BorderThickness = 2;
			this.btnSignUp.CheckedState.Parent = this.btnSignUp;
			this.btnSignUp.CustomImages.Parent = this.btnSignUp;
			this.btnSignUp.FillColor = System.Drawing.Color.Lime;
			this.btnSignUp.Font = new System.Drawing.Font("Showcard Gothic", 10.8F);
			this.btnSignUp.ForeColor = System.Drawing.Color.White;
			this.btnSignUp.HoverState.Parent = this.btnSignUp;
			this.btnSignUp.Location = new System.Drawing.Point(488, 424);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.ShadowDecoration.Parent = this.btnSignUp;
			this.btnSignUp.Size = new System.Drawing.Size(280, 45);
			this.btnSignUp.TabIndex = 4;
			this.btnSignUp.Text = "Sign up!";
			this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
			// 
			// FLogin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::StartMenu.Properties.Resources.Login2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1182, 628);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.lblForgotPassword);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.tbxPassword);
			this.Controls.Add(this.tbxUsrname);
			this.Name = "FLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbxUsrname;
        private Guna.UI2.WinForms.Guna2TextBox tbxPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
    }
}