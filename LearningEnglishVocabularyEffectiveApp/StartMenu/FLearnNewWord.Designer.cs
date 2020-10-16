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
            this.btnLNWreturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnLNWuser = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btnLNWreturn
            // 
            this.btnLNWreturn.BackColor = System.Drawing.Color.Transparent;
            this.btnLNWreturn.BorderColor = System.Drawing.Color.Transparent;
            this.btnLNWreturn.CheckedState.Parent = this.btnLNWreturn;
            this.btnLNWreturn.CustomImages.Parent = this.btnLNWreturn;
            this.btnLNWreturn.FillColor = System.Drawing.Color.Transparent;
            this.btnLNWreturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLNWreturn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLNWreturn.HoverState.Parent = this.btnLNWreturn;
            this.btnLNWreturn.Location = new System.Drawing.Point(12, 22);
            this.btnLNWreturn.Name = "btnLNWreturn";
            this.btnLNWreturn.ShadowDecoration.Parent = this.btnLNWreturn;
            this.btnLNWreturn.Size = new System.Drawing.Size(73, 57);
            this.btnLNWreturn.TabIndex = 0;
            this.btnLNWreturn.Text = "guna2Button1";
            // 
            // btnLNWuser
            // 
            this.btnLNWuser.BackColor = System.Drawing.Color.Transparent;
            this.btnLNWuser.CheckedState.Parent = this.btnLNWuser;
            this.btnLNWuser.CustomImages.Parent = this.btnLNWuser;
            this.btnLNWuser.FillColor = System.Drawing.Color.Transparent;
            this.btnLNWuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLNWuser.ForeColor = System.Drawing.Color.Transparent;
            this.btnLNWuser.HoverState.Parent = this.btnLNWuser;
            this.btnLNWuser.Location = new System.Drawing.Point(864, 12);
            this.btnLNWuser.Name = "btnLNWuser";
            this.btnLNWuser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLNWuser.ShadowDecoration.Parent = this.btnLNWuser;
            this.btnLNWuser.Size = new System.Drawing.Size(50, 50);
            this.btnLNWuser.TabIndex = 1;
            this.btnLNWuser.Text = "guna2CircleButton1";
            // 
            // FLearnNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StartMenu.Properties.Resources.LearnNewWords;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btnLNWuser);
            this.Controls.Add(this.btnLNWreturn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FLearnNewWord";
            this.Text = "LEARN NEW WORDS";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLNWreturn;
        private Guna.UI2.WinForms.Guna2CircleButton btnLNWuser;
    }
}