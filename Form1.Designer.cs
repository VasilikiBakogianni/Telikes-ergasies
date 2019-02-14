namespace ThirdErgasia
{
    partial class Form1
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
            this.panelProp = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Randomsong = new System.Windows.Forms.Button();
            this.Favored = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Stopb = new System.Windows.Forms.Button();
            this.Pauseb = new System.Windows.Forms.Button();
            this.Playb = new System.Windows.Forms.Button();
            this.nameofsong = new System.Windows.Forms.Label();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProp
            // 
            this.panelProp.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelProp.Controls.Add(this.listBox1);
            this.panelProp.Controls.Add(this.Randomsong);
            this.panelProp.Controls.Add(this.Favored);
            this.panelProp.Controls.Add(this.Delete);
            this.panelProp.Controls.Add(this.Edit);
            this.panelProp.Controls.Add(this.Add);
            this.panelProp.Location = new System.Drawing.Point(0, 36);
            this.panelProp.Name = "panelProp";
            this.panelProp.Size = new System.Drawing.Size(162, 686);
            this.panelProp.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Indigo;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBox1.ForeColor = System.Drawing.Color.Cyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(304, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(404, 340);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // Randomsong
            // 
            this.Randomsong.BackColor = System.Drawing.Color.Thistle;
            this.Randomsong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Randomsong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Randomsong.Location = new System.Drawing.Point(9, 536);
            this.Randomsong.Name = "Randomsong";
            this.Randomsong.Size = new System.Drawing.Size(147, 49);
            this.Randomsong.TabIndex = 4;
            this.Randomsong.Text = "Random";
            this.Randomsong.UseVisualStyleBackColor = false;
            this.Randomsong.Click += new System.EventHandler(this.Randomsong_Click);
            // 
            // Favored
            // 
            this.Favored.BackColor = System.Drawing.Color.Thistle;
            this.Favored.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Favored.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Favored.Location = new System.Drawing.Point(9, 432);
            this.Favored.Name = "Favored";
            this.Favored.Size = new System.Drawing.Size(147, 49);
            this.Favored.TabIndex = 3;
            this.Favored.Text = "Favored";
            this.Favored.UseVisualStyleBackColor = false;
            this.Favored.Click += new System.EventHandler(this.Favored_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Thistle;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Delete.Location = new System.Drawing.Point(9, 327);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(147, 49);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Thistle;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Edit.Location = new System.Drawing.Point(9, 217);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(147, 49);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Thistle;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Add.Location = new System.Drawing.Point(9, 111);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(147, 49);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Stopb
            // 
            this.Stopb.BackColor = System.Drawing.Color.Transparent;
            this.Stopb.BackgroundImage = global::ThirdErgasia.Properties.Resources.STOPc;
            this.Stopb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stopb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stopb.Location = new System.Drawing.Point(436, 782);
            this.Stopb.Name = "Stopb";
            this.Stopb.Size = new System.Drawing.Size(91, 56);
            this.Stopb.TabIndex = 6;
            this.Stopb.UseVisualStyleBackColor = false;
            this.Stopb.Click += new System.EventHandler(this.Stopb_Click);
            // 
            // Pauseb
            // 
            this.Pauseb.BackColor = System.Drawing.Color.Transparent;
            this.Pauseb.BackgroundImage = global::ThirdErgasia.Properties.Resources.PAUSEc;
            this.Pauseb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pauseb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pauseb.Location = new System.Drawing.Point(838, 782);
            this.Pauseb.Name = "Pauseb";
            this.Pauseb.Size = new System.Drawing.Size(91, 56);
            this.Pauseb.TabIndex = 5;
            this.Pauseb.UseVisualStyleBackColor = false;
            this.Pauseb.Click += new System.EventHandler(this.Pauseb_Click);
            // 
            // Playb
            // 
            this.Playb.BackColor = System.Drawing.Color.Transparent;
            this.Playb.BackgroundImage = global::ThirdErgasia.Properties.Resources.PLAYc;
            this.Playb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Playb.Location = new System.Drawing.Point(642, 782);
            this.Playb.Name = "Playb";
            this.Playb.Size = new System.Drawing.Size(91, 56);
            this.Playb.TabIndex = 3;
            this.Playb.UseVisualStyleBackColor = false;
            this.Playb.Click += new System.EventHandler(this.Playb_Click);
            // 
            // nameofsong
            // 
            this.nameofsong.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofsong.Location = new System.Drawing.Point(340, 736);
            this.nameofsong.Name = "nameofsong";
            this.nameofsong.Size = new System.Drawing.Size(684, 31);
            this.nameofsong.TabIndex = 7;
            this.nameofsong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flow1
            // 
            this.flow1.AutoScroll = true;
            this.flow1.BackColor = System.Drawing.Color.SlateGray;
            this.flow1.Location = new System.Drawing.Point(162, 37);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(1187, 685);
            this.flow1.TabIndex = 0;
            this.flow1.WrapContents = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.songStatusToolStripMenuItem,
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1405, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.favoredToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 29);
            this.toolStripMenuItem1.Text = "Song Management";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // favoredToolStripMenuItem
            // 
            this.favoredToolStripMenuItem.Name = "favoredToolStripMenuItem";
            this.favoredToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.favoredToolStripMenuItem.Text = "Favored";
            this.favoredToolStripMenuItem.Click += new System.EventHandler(this.favoredToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // songStatusToolStripMenuItem
            // 
            this.songStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.toolStripMenuItem2,
            this.stopToolStripMenuItem});
            this.songStatusToolStripMenuItem.Name = "songStatusToolStripMenuItem";
            this.songStatusToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.songStatusToolStripMenuItem.Text = "Song Status";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 30);
            this.toolStripMenuItem2.Text = "Pause";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.pauseStripMenuItem2_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1405, 846);
            this.Controls.Add(this.nameofsong);
            this.Controls.Add(this.Stopb);
            this.Controls.Add(this.Pauseb);
            this.Controls.Add(this.Playb);
            this.Controls.Add(this.panelProp);
            this.Controls.Add(this.flow1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Playlist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelProp.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelProp;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Favored;
        private System.Windows.Forms.Button Playb;
        private System.Windows.Forms.Button Pauseb;
        private System.Windows.Forms.Button Stopb;
        private System.Windows.Forms.Button Randomsong;
        public System.Windows.Forms.FlowLayoutPanel flow1;
        public System.Windows.Forms.Label nameofsong;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

