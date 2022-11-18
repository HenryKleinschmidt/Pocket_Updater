namespace Pocket_Updater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createzipArchiveOnSDCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAppUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v138ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Pocket = new System.Windows.Forms.Button();
            this.Button_Cores = new System.Windows.Forms.Button();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.Button_Organize = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createzipArchiveOnSDCardToolStripMenuItem,
            this.checkForAppUpdatesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createzipArchiveOnSDCardToolStripMenuItem
            // 
            this.createzipArchiveOnSDCardToolStripMenuItem.Name = "createzipArchiveOnSDCardToolStripMenuItem";
            this.createzipArchiveOnSDCardToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.createzipArchiveOnSDCardToolStripMenuItem.Text = "Create .zip archive on SD Card";
            this.createzipArchiveOnSDCardToolStripMenuItem.Click += new System.EventHandler(this.createzipArchiveOnSDCardToolStripMenuItem_Click);
            // 
            // checkForAppUpdatesToolStripMenuItem
            // 
            this.checkForAppUpdatesToolStripMenuItem.Name = "checkForAppUpdatesToolStripMenuItem";
            this.checkForAppUpdatesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.checkForAppUpdatesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.checkForAppUpdatesToolStripMenuItem.Text = "Check for App Updates";
            this.checkForAppUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForAppUpdatesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogFileToolStripMenuItem,
            this.clearLogFileToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // viewLogFileToolStripMenuItem
            // 
            this.viewLogFileToolStripMenuItem.Name = "viewLogFileToolStripMenuItem";
            this.viewLogFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.viewLogFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewLogFileToolStripMenuItem.Text = "View Log File";
            this.viewLogFileToolStripMenuItem.Click += new System.EventHandler(this.viewLogFileToolStripMenuItem_Click);
            // 
            // clearLogFileToolStripMenuItem
            // 
            this.clearLogFileToolStripMenuItem.Name = "clearLogFileToolStripMenuItem";
            this.clearLogFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearLogFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.clearLogFileToolStripMenuItem.Text = "Clear Log File";
            this.clearLogFileToolStripMenuItem.Click += new System.EventHandler(this.clearLogFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v138ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // v138ToolStripMenuItem
            // 
            this.v138ToolStripMenuItem.Name = "v138ToolStripMenuItem";
            this.v138ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.v138ToolStripMenuItem.Text = "v1.3.8";
            this.v138ToolStripMenuItem.Click += new System.EventHandler(this.v138ToolStripMenuItem_Click);
            // 
            // Button_Pocket
            // 
            this.Button_Pocket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Pocket.BackColor = System.Drawing.Color.Transparent;
            this.Button_Pocket.BackgroundImage = global::Pocket_Updater.Properties.Resources.updater_to_pocket;
            this.Button_Pocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Pocket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Pocket.FlatAppearance.BorderSize = 0;
            this.Button_Pocket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Pocket.Location = new System.Drawing.Point(39, 21);
            this.Button_Pocket.Margin = new System.Windows.Forms.Padding(20);
            this.Button_Pocket.Name = "Button_Pocket";
            this.Button_Pocket.Size = new System.Drawing.Size(60, 60);
            this.Button_Pocket.TabIndex = 2;
            this.Button_Pocket.UseVisualStyleBackColor = false;
            this.Button_Pocket.Click += new System.EventHandler(this.Button_Pocket_Click);
            // 
            // Button_Cores
            // 
            this.Button_Cores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Cores.BackColor = System.Drawing.Color.Transparent;
            this.Button_Cores.BackgroundImage = global::Pocket_Updater.Properties.Resources.settings;
            this.Button_Cores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Cores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cores.FlatAppearance.BorderSize = 0;
            this.Button_Cores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cores.Location = new System.Drawing.Point(39, 123);
            this.Button_Cores.Margin = new System.Windows.Forms.Padding(20);
            this.Button_Cores.Name = "Button_Cores";
            this.Button_Cores.Size = new System.Drawing.Size(60, 60);
            this.Button_Cores.TabIndex = 13;
            this.Button_Cores.UseVisualStyleBackColor = false;
            this.Button_Cores.Click += new System.EventHandler(this.Button_Cores_Click);
            // 
            // Button_Settings
            // 
            this.Button_Settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Button_Settings.BackgroundImage = global::Pocket_Updater.Properties.Resources.gear_solid;
            this.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Settings.FlatAppearance.BorderSize = 0;
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Settings.Location = new System.Drawing.Point(39, 327);
            this.Button_Settings.Margin = new System.Windows.Forms.Padding(20);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(60, 60);
            this.Button_Settings.TabIndex = 15;
            this.Button_Settings.UseVisualStyleBackColor = false;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(142, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 19);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Update Pocket";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(142, 143);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(105, 19);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Manage Cores";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(142, 347);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(62, 19);
            this.linkLabel3.TabIndex = 19;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Settings";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(142, 245);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(112, 19);
            this.linkLabel4.TabIndex = 21;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Organize Cores";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // Button_Organize
            // 
            this.Button_Organize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Organize.BackColor = System.Drawing.Color.Transparent;
            this.Button_Organize.BackgroundImage = global::Pocket_Updater.Properties.Resources.organize;
            this.Button_Organize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Organize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Organize.FlatAppearance.BorderSize = 0;
            this.Button_Organize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Organize.Location = new System.Drawing.Point(39, 225);
            this.Button_Organize.Margin = new System.Windows.Forms.Padding(20);
            this.Button_Organize.Name = "Button_Organize";
            this.Button_Organize.Size = new System.Drawing.Size(60, 60);
            this.Button_Organize.TabIndex = 20;
            this.Button_Organize.UseVisualStyleBackColor = false;
            this.Button_Organize.Click += new System.EventHandler(this.Button_Organize_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Button_Pocket, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_Settings, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_Organize, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_Cores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 408);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(278, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hyper\'s Updater";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Button_Pocket;
        private Button Button_Cores;
        private Button Button_Settings;
        private ToolStripMenuItem checkForAppUpdatesToolStripMenuItem;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem viewLogFileToolStripMenuItem;
        private ToolStripMenuItem clearLogFileToolStripMenuItem;
        private LinkLabel linkLabel4;
        private Button Button_Organize;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem v138ToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem createzipArchiveOnSDCardToolStripMenuItem;
    }
}
