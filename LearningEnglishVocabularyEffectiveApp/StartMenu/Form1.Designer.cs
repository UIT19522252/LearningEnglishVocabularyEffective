namespace StartMenu
{
	partial class StartMenu
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
			this.butLearnNewWord = new System.Windows.Forms.Button();
			this.butPractice = new System.Windows.Forms.Button();
			this.butQuickPractice = new System.Windows.Forms.Button();
			this.butYourWord = new System.Windows.Forms.Button();
			this.butDifficultWord = new System.Windows.Forms.Button();
			this.butIntroduce = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// butLearnNewWord
			// 
			this.butLearnNewWord.Location = new System.Drawing.Point(265, 135);
			this.butLearnNewWord.Name = "butLearnNewWord";
			this.butLearnNewWord.Size = new System.Drawing.Size(180, 31);
			this.butLearnNewWord.TabIndex = 0;
			this.butLearnNewWord.Text = "Học từ mới";
			this.butLearnNewWord.UseVisualStyleBackColor = true;
			// 
			// butPractice
			// 
			this.butPractice.Location = new System.Drawing.Point(265, 182);
			this.butPractice.Name = "butPractice";
			this.butPractice.Size = new System.Drawing.Size(180, 31);
			this.butPractice.TabIndex = 0;
			this.butPractice.Text = "Ôn tập";
			this.butPractice.UseVisualStyleBackColor = true;
			// 
			// butQuickPractice
			// 
			this.butQuickPractice.Location = new System.Drawing.Point(265, 233);
			this.butQuickPractice.Name = "butQuickPractice";
			this.butQuickPractice.Size = new System.Drawing.Size(180, 31);
			this.butQuickPractice.TabIndex = 0;
			this.butQuickPractice.Text = "Ôn tập nhanh";
			this.butQuickPractice.UseVisualStyleBackColor = true;
			// 
			// butYourWord
			// 
			this.butYourWord.Location = new System.Drawing.Point(265, 280);
			this.butYourWord.Name = "butYourWord";
			this.butYourWord.Size = new System.Drawing.Size(180, 31);
			this.butYourWord.TabIndex = 0;
			this.butYourWord.Text = "Từ của bạn";
			this.butYourWord.UseVisualStyleBackColor = true;
			// 
			// butDifficultWord
			// 
			this.butDifficultWord.Location = new System.Drawing.Point(265, 329);
			this.butDifficultWord.Name = "butDifficultWord";
			this.butDifficultWord.Size = new System.Drawing.Size(180, 31);
			this.butDifficultWord.TabIndex = 0;
			this.butDifficultWord.Text = "Từ khó";
			this.butDifficultWord.UseVisualStyleBackColor = true;
			// 
			// butIntroduce
			// 
			this.butIntroduce.AllowDrop = true;
			this.butIntroduce.Location = new System.Drawing.Point(265, 380);
			this.butIntroduce.Name = "butIntroduce";
			this.butIntroduce.Size = new System.Drawing.Size(180, 31);
			this.butIntroduce.TabIndex = 0;
			this.butIntroduce.Text = "Giới thiệu";
			this.butIntroduce.UseVisualStyleBackColor = true;
			// 
			// StartMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 441);
			this.Controls.Add(this.butLearnNewWord);
			this.Controls.Add(this.butPractice);
			this.Controls.Add(this.butQuickPractice);
			this.Controls.Add(this.butYourWord);
			this.Controls.Add(this.butDifficultWord);
			this.Controls.Add(this.butIntroduce);
			this.Name = "StartMenu";
			this.Text = "StartMenu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button butLearnNewWord;
		private System.Windows.Forms.Button butPractice;
		private System.Windows.Forms.Button butQuickPractice;
		private System.Windows.Forms.Button butYourWord;
		private System.Windows.Forms.Button butDifficultWord;
		private System.Windows.Forms.Button butIntroduce;
	}
}

