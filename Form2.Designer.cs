namespace ThirdErgasia
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Backb = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Previousb = new System.Windows.Forms.Button();
            this.Nextb = new System.Windows.Forms.Button();
            this.Stopb = new System.Windows.Forms.Button();
            this.Pauseb = new System.Windows.Forms.Button();
            this.Playb = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playlistManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(414, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 405);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 262);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(333, 143);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 265);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(296, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 29);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Backb
            // 
            this.Backb.BackColor = System.Drawing.Color.RoyalBlue;
            this.Backb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backb.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.Backb.Location = new System.Drawing.Point(9, 548);
            this.Backb.Name = "Backb";
            this.Backb.Size = new System.Drawing.Size(103, 60);
            this.Backb.TabIndex = 10;
            this.Backb.Text = "BACK";
            this.Backb.UseVisualStyleBackColor = false;
            this.Backb.Click += new System.EventHandler(this.Backb_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Turquoise;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(12, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 400);
            this.listBox1.TabIndex = 11;
            // 
            // Previousb
            // 
            this.Previousb.BackColor = System.Drawing.Color.Transparent;
            this.Previousb.BackgroundImage = global::ThirdErgasia.Properties.Resources.PREVIOUSc;
            this.Previousb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Previousb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Previousb.Location = new System.Drawing.Point(271, 538);
            this.Previousb.Name = "Previousb";
            this.Previousb.Size = new System.Drawing.Size(91, 56);
            this.Previousb.TabIndex = 13;
            this.Previousb.UseVisualStyleBackColor = false;
            this.Previousb.Click += new System.EventHandler(this.Previousb_Click);
            // 
            // Nextb
            // 
            this.Nextb.BackColor = System.Drawing.Color.Transparent;
            this.Nextb.BackgroundImage = global::ThirdErgasia.Properties.Resources.NEXTc;
            this.Nextb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nextb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nextb.Location = new System.Drawing.Point(802, 538);
            this.Nextb.Name = "Nextb";
            this.Nextb.Size = new System.Drawing.Size(91, 56);
            this.Nextb.TabIndex = 12;
            this.Nextb.UseVisualStyleBackColor = false;
            this.Nextb.Click += new System.EventHandler(this.Nextb_Click);
            // 
            // Stopb
            // 
            this.Stopb.BackColor = System.Drawing.Color.Transparent;
            this.Stopb.BackgroundImage = global::ThirdErgasia.Properties.Resources.STOPc;
            this.Stopb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stopb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stopb.Location = new System.Drawing.Point(402, 538);
            this.Stopb.Name = "Stopb";
            this.Stopb.Size = new System.Drawing.Size(91, 56);
            this.Stopb.TabIndex = 9;
            this.Stopb.UseVisualStyleBackColor = false;
            this.Stopb.Click += new System.EventHandler(this.Stopb_Click);
            // 
            // Pauseb
            // 
            this.Pauseb.BackColor = System.Drawing.Color.Transparent;
            this.Pauseb.BackgroundImage = global::ThirdErgasia.Properties.Resources.PAUSEc;
            this.Pauseb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pauseb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pauseb.Location = new System.Drawing.Point(670, 538);
            this.Pauseb.Name = "Pauseb";
            this.Pauseb.Size = new System.Drawing.Size(91, 56);
            this.Pauseb.TabIndex = 8;
            this.Pauseb.UseVisualStyleBackColor = false;
            this.Pauseb.Click += new System.EventHandler(this.Pauseb_Click);
            // 
            // Playb
            // 
            this.Playb.BackColor = System.Drawing.Color.Transparent;
            this.Playb.BackgroundImage = global::ThirdErgasia.Properties.Resources.PLAYc;
            this.Playb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Playb.Location = new System.Drawing.Point(539, 538);
            this.Playb.Name = "Playb";
            this.Playb.Size = new System.Drawing.Size(91, 56);
            this.Playb.TabIndex = 7;
            this.Playb.UseVisualStyleBackColor = false;
            this.Playb.Click += new System.EventHandler(this.Playb_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistManagmentToolStripMenuItem,
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playlistManagmentToolStripMenuItem
            // 
            this.playlistManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem});
            this.playlistManagmentToolStripMenuItem.Name = "playlistManagmentToolStripMenuItem";
            this.playlistManagmentToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.playlistManagmentToolStripMenuItem.Text = "Playlist Management";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1180, 617);
            this.Controls.Add(this.Previousb);
            this.Controls.Add(this.Nextb);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Backb);
            this.Controls.Add(this.Stopb);
            this.Controls.Add(this.Pauseb);
            this.Controls.Add(this.Playb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stopb;
        private System.Windows.Forms.Button Pauseb;
        private System.Windows.Forms.Button Playb;
        private System.Windows.Forms.Button Backb;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Nextb;
        private System.Windows.Forms.Button Previousb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playlistManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}