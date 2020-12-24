namespace StartMenu
{
    partial class FListingMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListingMusic));
            this.treeView = new System.Windows.Forms.TreeView();
            this.lbNameSong = new System.Windows.Forms.Label();
            this.pnList = new System.Windows.Forms.Panel();
            this.pnMedia = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnList.SuspendLayout();
            this.pnMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(8, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(316, 532);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lbNameSong
            // 
            this.lbNameSong.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSong.Location = new System.Drawing.Point(12, 437);
            this.lbNameSong.Name = "lbNameSong";
            this.lbNameSong.Size = new System.Drawing.Size(828, 38);
            this.lbNameSong.TabIndex = 3;
            this.lbNameSong.Text = "Chose the Song from list";
            this.lbNameSong.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.treeView);
            this.pnList.Location = new System.Drawing.Point(846, 12);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(324, 535);
            this.pnList.TabIndex = 4;
            // 
            // pnMedia
            // 
            this.pnMedia.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnMedia.Location = new System.Drawing.Point(19, 15);
            this.pnMedia.Name = "pnMedia";
            this.pnMedia.Size = new System.Drawing.Size(821, 402);
            this.pnMedia.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, -3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(821, 401);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // FListingMusic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 556);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.lbNameSong);
            this.Controls.Add(this.pnMedia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FListingMusic";
            this.Text = "FListingMusic";
            this.pnList.ResumeLayout(false);
            this.pnMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label lbNameSong;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Panel pnMedia;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}