﻿namespace StartMenu
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
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.lblWrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxUsrname
            // 
            this.tbxUsrname.AutoRoundedCorners = true;
            this.tbxUsrname.BackColor = System.Drawing.Color.Transparent;
            this.tbxUsrname.BorderColor = System.Drawing.Color.Aqua;
            this.tbxUsrname.BorderRadius = 25;
            this.tbxUsrname.BorderThickness = 0;
            this.tbxUsrname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsrname.DefaultText = "";
            this.tbxUsrname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUsrname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUsrname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUsrname.DisabledState.Parent = this.tbxUsrname;
            this.tbxUsrname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUsrname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUsrname.FocusedState.Parent = this.tbxUsrname;
            this.tbxUsrname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbxUsrname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUsrname.HoverState.Parent = this.tbxUsrname;
            this.tbxUsrname.Location = new System.Drawing.Point(617, 122);
            this.tbxUsrname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxUsrname.Name = "tbxUsrname";
            this.tbxUsrname.PasswordChar = '\0';
            this.tbxUsrname.PlaceholderText = "Your user name";
            this.tbxUsrname.SelectedText = "";
            this.tbxUsrname.ShadowDecoration.Parent = this.tbxUsrname;
            this.tbxUsrname.Size = new System.Drawing.Size(262, 53);
            this.tbxUsrname.TabIndex = 0;
            this.tbxUsrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxUsrname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUsrname_KeyDown);
            // 
            // tbxPassword
            // 
            this.tbxPassword.AutoRoundedCorners = true;
            this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbxPassword.BorderColor = System.Drawing.Color.Aqua;
            this.tbxPassword.BorderRadius = 25;
            this.tbxPassword.BorderThickness = 0;
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
            this.tbxPassword.Location = new System.Drawing.Point(617, 189);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.PlaceholderText = "Your password";
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.ShadowDecoration.Parent = this.tbxPassword;
            this.tbxPassword.Size = new System.Drawing.Size(262, 53);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 32;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Showcard Gothic", 10.8F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(608, 285);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(189, 67);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Animated = true;
            this.btnSignUp.AutoRoundedCorners = true;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderRadius = 18;
            this.btnSignUp.CheckedState.Parent = this.btnSignUp;
            this.btnSignUp.CustomImages.Parent = this.btnSignUp;
            this.btnSignUp.FillColor = System.Drawing.Color.Transparent;
            this.btnSignUp.Font = new System.Drawing.Font("Showcard Gothic", 10.8F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.HoverState.Parent = this.btnSignUp;
            this.btnSignUp.Location = new System.Drawing.Point(645, 461);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.ShadowDecoration.Parent = this.btnSignUp;
            this.btnSignUp.Size = new System.Drawing.Size(125, 38);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSignUp_KeyDown);
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.lblWrong.Location = new System.Drawing.Point(604, 263);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(245, 19);
            this.lblWrong.TabIndex = 5;
            this.lblWrong.Text = "*Incorrect Username or Password";
            // 
            // FLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.LoginNewForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsrname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbxUsrname;
        private Guna.UI2.WinForms.Guna2TextBox tbxPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private System.Windows.Forms.Label lblWrong;
    }
}