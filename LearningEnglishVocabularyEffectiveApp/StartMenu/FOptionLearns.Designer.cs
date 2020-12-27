namespace StartMenu
{
    partial class FOptionLearns
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
            this.btnMultipleChoices = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMultipleChoices
            // 
            this.btnMultipleChoices.BackColor = System.Drawing.Color.Transparent;
            this.btnMultipleChoices.BorderRadius = 25;
            this.btnMultipleChoices.CheckedState.Parent = this.btnMultipleChoices;
            this.btnMultipleChoices.CustomImages.Parent = this.btnMultipleChoices;
            this.btnMultipleChoices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.btnMultipleChoices.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Bold);
            this.btnMultipleChoices.ForeColor = System.Drawing.Color.White;
            this.btnMultipleChoices.HoverState.Parent = this.btnMultipleChoices;
            this.btnMultipleChoices.Location = new System.Drawing.Point(194, 335);
            this.btnMultipleChoices.Name = "btnMultipleChoices";
            this.btnMultipleChoices.ShadowDecoration.Parent = this.btnMultipleChoices;
            this.btnMultipleChoices.Size = new System.Drawing.Size(367, 181);
            this.btnMultipleChoices.TabIndex = 0;
            this.btnMultipleChoices.Text = "Multiple Choices";
            this.btnMultipleChoices.UseTransparentBackground = true;
            this.btnMultipleChoices.Click += new System.EventHandler(this.btnMultipleChoices_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.BorderRadius = 25;
            this.btnCategory.CheckedState.Parent = this.btnCategory;
            this.btnCategory.CustomImages.Parent = this.btnCategory;
            this.btnCategory.FillColor = System.Drawing.Color.Maroon;
            this.btnCategory.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.HoverState.Parent = this.btnCategory;
            this.btnCategory.Location = new System.Drawing.Point(655, 335);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.ShadowDecoration.Parent = this.btnCategory;
            this.btnCategory.Size = new System.Drawing.Size(367, 181);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "From Category";
            this.btnCategory.UseTransparentBackground = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // pnlLoad
            // 
            this.pnlLoad.Location = new System.Drawing.Point(12, 12);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(200, 100);
            this.pnlLoad.TabIndex = 2;
            this.pnlLoad.Visible = false;
            this.pnlLoad.EnabledChanged += new System.EventHandler(this.pnlLoad_EnabledChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(293, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 123);
            this.label1.TabIndex = 3;
            this.label1.Text = "Let make your choice!";
            // 
            // FOptionLearns
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1162, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnMultipleChoices);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOptionLearns";
            this.Text = "FOptionLearns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMultipleChoices;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.Label label1;
    }
}