namespace StartMenu
{
    partial class FSignUp
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
            this.tbxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxRepeatPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignup = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignin = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Animated = true;
            this.tbxUsername.AutoRoundedCorners = true;
            this.tbxUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbxUsername.BorderColor = System.Drawing.Color.Aqua;
            this.tbxUsername.BorderRadius = 21;
            this.tbxUsername.BorderThickness = 2;
            this.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.DefaultText = "";
            this.tbxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUsername.DisabledState.Parent = this.tbxUsername;
            this.tbxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUsername.FocusedState.Parent = this.tbxUsername;
            this.tbxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUsername.HoverState.Parent = this.tbxUsername;
            this.tbxUsername.Location = new System.Drawing.Point(502, 241);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.PlaceholderText = "Your username";
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.ShadowDecoration.Parent = this.tbxUsername;
            this.tbxUsername.Size = new System.Drawing.Size(501, 45);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUsername_KeyDown);
            // 
            // tbxRepeatPass
            // 
            this.tbxRepeatPass.Animated = true;
            this.tbxRepeatPass.AutoRoundedCorners = true;
            this.tbxRepeatPass.BackColor = System.Drawing.Color.Transparent;
            this.tbxRepeatPass.BorderColor = System.Drawing.Color.Aqua;
            this.tbxRepeatPass.BorderRadius = 21;
            this.tbxRepeatPass.BorderThickness = 2;
            this.tbxRepeatPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxRepeatPass.DefaultText = "";
            this.tbxRepeatPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxRepeatPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxRepeatPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRepeatPass.DisabledState.Parent = this.tbxRepeatPass;
            this.tbxRepeatPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRepeatPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRepeatPass.FocusedState.Parent = this.tbxRepeatPass;
            this.tbxRepeatPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbxRepeatPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRepeatPass.HoverState.Parent = this.tbxRepeatPass;
            this.tbxRepeatPass.Location = new System.Drawing.Point(502, 352);
            this.tbxRepeatPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxRepeatPass.Name = "tbxRepeatPass";
            this.tbxRepeatPass.PasswordChar = '*';
            this.tbxRepeatPass.PlaceholderText = "Your password";
            this.tbxRepeatPass.SelectedText = "";
            this.tbxRepeatPass.ShadowDecoration.Parent = this.tbxRepeatPass;
            this.tbxRepeatPass.Size = new System.Drawing.Size(501, 45);
            this.tbxRepeatPass.TabIndex = 2;
            this.tbxRepeatPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxRepeatPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRepeatPass_KeyDown);
            // 
            // tbxPass
            // 
            this.tbxPass.Animated = true;
            this.tbxPass.AutoRoundedCorners = true;
            this.tbxPass.BackColor = System.Drawing.Color.Transparent;
            this.tbxPass.BorderColor = System.Drawing.Color.Aqua;
            this.tbxPass.BorderRadius = 21;
            this.tbxPass.BorderThickness = 2;
            this.tbxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPass.DefaultText = "";
            this.tbxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPass.DisabledState.Parent = this.tbxPass;
            this.tbxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPass.FocusedState.Parent = this.tbxPass;
            this.tbxPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPass.HoverState.Parent = this.tbxPass;
            this.tbxPass.Location = new System.Drawing.Point(502, 296);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.PlaceholderText = "Your password";
            this.tbxPass.SelectedText = "";
            this.tbxPass.ShadowDecoration.Parent = this.tbxPass;
            this.tbxPass.Size = new System.Drawing.Size(501, 45);
            this.tbxPass.TabIndex = 1;
            this.tbxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPass_KeyDown);
            // 
            // btnSignup
            // 
            this.btnSignup.Animated = true;
            this.btnSignup.AutoRoundedCorners = true;
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BorderColor = System.Drawing.Color.White;
            this.btnSignup.BorderRadius = 38;
            this.btnSignup.BorderThickness = 2;
            this.btnSignup.CheckedState.Parent = this.btnSignup;
            this.btnSignup.CustomImages.Parent = this.btnSignup;
            this.btnSignup.FillColor = System.Drawing.Color.Lime;
            this.btnSignup.Font = new System.Drawing.Font("Showcard Gothic", 13.8F);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.HoverState.Parent = this.btnSignup;
            this.btnSignup.Location = new System.Drawing.Point(762, 423);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.ShadowDecoration.Parent = this.btnSignup;
            this.btnSignup.Size = new System.Drawing.Size(287, 79);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Sign Up!";
            this.btnSignup.UseTransparentBackground = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.Animated = true;
            this.btnSignin.AutoRoundedCorners = true;
            this.btnSignin.BackColor = System.Drawing.Color.Transparent;
            this.btnSignin.BorderColor = System.Drawing.Color.White;
            this.btnSignin.BorderRadius = 38;
            this.btnSignin.BorderThickness = 2;
            this.btnSignin.CheckedState.Parent = this.btnSignin;
            this.btnSignin.CustomImages.Parent = this.btnSignin;
            this.btnSignin.Font = new System.Drawing.Font("Showcard Gothic", 13.8F);
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.HoverState.Parent = this.btnSignin;
            this.btnSignin.Location = new System.Drawing.Point(433, 423);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.ShadowDecoration.Parent = this.btnSignin;
            this.btnSignin.Size = new System.Drawing.Size(287, 79);
            this.btnSignin.TabIndex = 4;
            this.btnSignin.Text = "Have an account?";
            this.btnSignin.UseTransparentBackground = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // FSignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::StartMenu.Properties.Resources.SignUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.tbxRepeatPass);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUsername);
            this.Name = "FSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbxUsername;
        private Guna.UI2.WinForms.Guna2TextBox tbxRepeatPass;
        private Guna.UI2.WinForms.Guna2TextBox tbxPass;
        private Guna.UI2.WinForms.Guna2Button btnSignup;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
    }
}