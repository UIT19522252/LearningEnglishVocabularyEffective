namespace StartMenu
{
    partial class FListingVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListingVideo));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnList = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.lbNameClip = new System.Windows.Forms.Label();
            this.pnMedia = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.pnList.SuspendLayout();
            this.pnMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(834, 443);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.treeView);
            this.pnList.Location = new System.Drawing.Point(848, 13);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(322, 531);
            this.pnList.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(4, 4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(315, 524);
            this.treeView.TabIndex = 0;
            // 
            // lbNameClip
            // 
            this.lbNameClip.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameClip.Location = new System.Drawing.Point(14, 485);
            this.lbNameClip.Name = "lbNameClip";
            this.lbNameClip.Size = new System.Drawing.Size(828, 38);
            this.lbNameClip.TabIndex = 4;
            this.lbNameClip.Text = "Chose the clip from list";
            // 
            // pnMedia
            // 
            this.pnMedia.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnMedia.Location = new System.Drawing.Point(12, 12);
            this.pnMedia.Name = "pnMedia";
            this.pnMedia.Size = new System.Drawing.Size(830, 454);
            this.pnMedia.TabIndex = 5;
            // 
            // FListingVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 556);
            this.Controls.Add(this.lbNameClip);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnMedia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FListingVideo";
            this.Text = "FListingVideo";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.pnList.ResumeLayout(false);
            this.pnMedia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label lbNameClip;
        private System.Windows.Forms.Panel pnMedia;
    }
}