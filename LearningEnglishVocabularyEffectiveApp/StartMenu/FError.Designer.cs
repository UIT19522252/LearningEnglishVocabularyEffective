namespace StartMenu
{
	partial class FError
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
            this.pbxError = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxError)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxError
            // 
            this.pbxError.BackColor = System.Drawing.Color.Transparent;
            this.pbxError.Image = global::StartMenu.Properties.Resources.errorIcon;
            this.pbxError.Location = new System.Drawing.Point(16, 15);
            this.pbxError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxError.Name = "pbxError";
            this.pbxError.ShadowDecoration.Parent = this.pbxError;
            this.pbxError.Size = new System.Drawing.Size(137, 117);
            this.pbxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxError.TabIndex = 0;
            this.pbxError.TabStop = false;
            this.pbxError.UseTransparentBackground = true;
            // 
            // btnOK
            // 
            this.btnOK.AutoRoundedCorners = true;
            this.btnOK.BorderRadius = 15;
            this.btnOK.BorderThickness = 1;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.Transparent;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(381, 102);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(133, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AllowDrop = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Location = new System.Drawing.Point(160, 15);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(355, 84);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 150);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbxError);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbxError)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox pbxError;
		private Guna.UI2.WinForms.Guna2Button btnOK;
		private System.Windows.Forms.Label lblMessage;
	}
}