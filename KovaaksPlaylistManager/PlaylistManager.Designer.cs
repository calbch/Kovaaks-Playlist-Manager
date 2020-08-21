namespace KovaaksPlaylistManager
{
    partial class PlaylistManager
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistManager));
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.Label();
            this.setBtn = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // playlistListBox
            // 
            this.playlistListBox.AllowDrop = true;
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.Location = new System.Drawing.Point(12, 38);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(196, 160);
            this.playlistListBox.TabIndex = 0;
            this.playlistListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.playlistListBox_DragDrop);
            this.playlistListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.playlistListBox_DragEnter);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Location = new System.Drawing.Point(12, 239);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(195, 26);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete selected playlist";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.Location = new System.Drawing.Point(12, 9);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(151, 19);
            this.helpLabel.TabIndex = 2;
            this.helpLabel.Text = "Set Steam folder location";
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // setBtn
            // 
            this.setBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.setBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setBtn.Location = new System.Drawing.Point(152, 9);
            this.setBtn.Margin = new System.Windows.Forms.Padding(0);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(55, 19);
            this.setBtn.TabIndex = 3;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = false;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // PlaylistManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 280);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.playlistListBox);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlaylistManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kovaak\'s Playlist Manager";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button setBtn;

        private System.Windows.Forms.Label helpLabel;

        private System.Windows.Forms.Button deleteBtn;

        private System.Windows.Forms.ListBox playlistListBox;
        
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        
        #endregion
    }
}