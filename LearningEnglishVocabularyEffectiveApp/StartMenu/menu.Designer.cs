namespace StartMenu
{
    partial class menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.butIntroduce = new System.Windows.Forms.Button();
            this.butDIfficultWord = new System.Windows.Forms.Button();
            this.butYourWord = new System.Windows.Forms.Button();
            this.butFastPractice = new System.Windows.Forms.Button();
            this.butPractice = new System.Windows.Forms.Button();
            this.butLearnNewWord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butIntroduce);
            this.panel1.Controls.Add(this.butDIfficultWord);
            this.panel1.Controls.Add(this.butYourWord);
            this.panel1.Controls.Add(this.butFastPractice);
            this.panel1.Controls.Add(this.butPractice);
            this.panel1.Controls.Add(this.butLearnNewWord);
            this.panel1.Location = new System.Drawing.Point(150, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 326);
            this.panel1.TabIndex = 0;
            // 
            // butIntroduce
            // 
            this.butIntroduce.Location = new System.Drawing.Point(222, 296);
            this.butIntroduce.Name = "butIntroduce";
            this.butIntroduce.Size = new System.Drawing.Size(136, 29);
            this.butIntroduce.TabIndex = 5;
            this.butIntroduce.Text = "Giới thiệu";
            this.butIntroduce.UseVisualStyleBackColor = true;
            // 
            // butDIfficultWord
            // 
            this.butDIfficultWord.Location = new System.Drawing.Point(222, 245);
            this.butDIfficultWord.Name = "butDIfficultWord";
            this.butDIfficultWord.Size = new System.Drawing.Size(136, 29);
            this.butDIfficultWord.TabIndex = 4;
            this.butDIfficultWord.Text = "Từ khó";
            this.butDIfficultWord.UseVisualStyleBackColor = true;
            // 
            // butYourWord
            // 
            this.butYourWord.Location = new System.Drawing.Point(222, 196);
            this.butYourWord.Name = "butYourWord";
            this.butYourWord.Size = new System.Drawing.Size(136, 29);
            this.butYourWord.TabIndex = 3;
            this.butYourWord.Text = "Từ của bạn";
            this.butYourWord.UseVisualStyleBackColor = true;
            // 
            // butFastPractice
            // 
            this.butFastPractice.Location = new System.Drawing.Point(222, 143);
            this.butFastPractice.Name = "butFastPractice";
            this.butFastPractice.Size = new System.Drawing.Size(136, 29);
            this.butFastPractice.TabIndex = 2;
            this.butFastPractice.Text = "Ôn tập nhanh";
            this.butFastPractice.UseVisualStyleBackColor = true;
            // 
            // butPractice
            // 
            this.butPractice.Location = new System.Drawing.Point(222, 93);
            this.butPractice.Name = "butPractice";
            this.butPractice.Size = new System.Drawing.Size(136, 29);
            this.butPractice.TabIndex = 1;
            this.butPractice.Text = "Ôn tập";
            this.butPractice.UseVisualStyleBackColor = true;
            // 
            // butLearnNewWord
            // 
            this.butLearnNewWord.Location = new System.Drawing.Point(222, 41);
            this.butLearnNewWord.Name = "butLearnNewWord";
            this.butLearnNewWord.Size = new System.Drawing.Size(136, 29);
            this.butLearnNewWord.TabIndex = 0;
            this.butLearnNewWord.Text = "Học từ mới";
            this.butLearnNewWord.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 493);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học từ vựng Tiếng Anh hiệu quả";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butIntroduce;
        private System.Windows.Forms.Button butDIfficultWord;
        private System.Windows.Forms.Button butYourWord;
        private System.Windows.Forms.Button butFastPractice;
        private System.Windows.Forms.Button butPractice;
        private System.Windows.Forms.Button butLearnNewWord;
    }
}

