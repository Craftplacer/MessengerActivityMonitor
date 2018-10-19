namespace MessengerActivityMonitor
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.titleLabel = new System.Windows.Forms.Label();
			this.listView = new System.Windows.Forms.ListView();
			this.processNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.personalMessageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.IconImageList = new System.Windows.Forms.ImageList(this.components);
			this.hideButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.updateIntervalLabel = new System.Windows.Forms.Label();
			this.updateTimer = new System.Windows.Forms.Timer(this.components);
			this.updateIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ManageItemContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.startupCheckBox = new System.Windows.Forms.CheckBox();
			this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.updateIntervalNumericUpDown)).BeginInit();
			this.ManageItemContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
			this.titleLabel.Location = new System.Drawing.Point(15, 50);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.titleLabel.Size = new System.Drawing.Size(261, 31);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "Messenger Activity Monitor Settings";
			// 
			// listView
			// 
			this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processNameColumnHeader,
            this.personalMessageColumnHeader});
			this.listView.Cursor = System.Windows.Forms.Cursors.Default;
			this.listView.FullRowSelect = true;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView.HideSelection = false;
			this.listView.LabelWrap = false;
			this.listView.Location = new System.Drawing.Point(19, 84);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.ShowGroups = false;
			this.listView.Size = new System.Drawing.Size(522, 217);
			this.listView.SmallImageList = this.IconImageList;
			this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView.TabIndex = 17;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			// 
			// processNameColumnHeader
			// 
			this.processNameColumnHeader.Text = "Process Name";
			this.processNameColumnHeader.Width = 150;
			// 
			// personalMessageColumnHeader
			// 
			this.personalMessageColumnHeader.Text = "Personal Message";
			this.personalMessageColumnHeader.Width = 337;
			// 
			// IconImageList
			// 
			this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
			this.IconImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.IconImageList.Images.SetKeyName(0, "music.png");
			this.IconImageList.Images.SetKeyName(1, "games.png");
			this.IconImageList.Images.SetKeyName(2, "office.png");
			// 
			// hideButton
			// 
			this.hideButton.Location = new System.Drawing.Point(466, 339);
			this.hideButton.Name = "hideButton";
			this.hideButton.Size = new System.Drawing.Size(75, 23);
			this.hideButton.TabIndex = 18;
			this.hideButton.Text = "&Hide";
			this.hideButton.UseVisualStyleBackColor = true;
			this.hideButton.Click += new System.EventHandler(this.HideButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(385, 339);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 19;
			this.exitButton.Text = "&Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(467, 51);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(74, 23);
			this.addButton.TabIndex = 20;
			this.addButton.Text = "&Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// updateIntervalLabel
			// 
			this.updateIntervalLabel.AutoSize = true;
			this.updateIntervalLabel.BackColor = System.Drawing.Color.Transparent;
			this.updateIntervalLabel.Location = new System.Drawing.Point(16, 344);
			this.updateIntervalLabel.Name = "updateIntervalLabel";
			this.updateIntervalLabel.Size = new System.Drawing.Size(137, 13);
			this.updateIntervalLabel.TabIndex = 22;
			this.updateIntervalLabel.Text = "Update Interval (seconds)";
			// 
			// updateTimer
			// 
			this.updateTimer.Enabled = true;
			this.updateTimer.Interval = 1000;
			this.updateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
			// 
			// updateIntervalNumericUpDown
			// 
			this.updateIntervalNumericUpDown.Location = new System.Drawing.Point(159, 340);
			this.updateIntervalNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.updateIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.updateIntervalNumericUpDown.Name = "updateIntervalNumericUpDown";
			this.updateIntervalNumericUpDown.Size = new System.Drawing.Size(56, 22);
			this.updateIntervalNumericUpDown.TabIndex = 23;
			this.updateIntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.updateIntervalNumericUpDown.ValueChanged += new System.EventHandler(this.UpdateIntervalNumericUpDown_ValueChanged);
			// 
			// ManageItemContextMenuStrip
			// 
			this.ManageItemContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMenuItem,
            this.editMenuItem});
			this.ManageItemContextMenuStrip.Name = "ManageItemContextMenuStrip";
			this.ManageItemContextMenuStrip.ShowImageMargin = false;
			this.ManageItemContextMenuStrip.ShowItemToolTips = false;
			this.ManageItemContextMenuStrip.Size = new System.Drawing.Size(89, 48);
			// 
			// removeMenuItem
			// 
			this.removeMenuItem.Name = "removeMenuItem";
			this.removeMenuItem.Size = new System.Drawing.Size(88, 22);
			this.removeMenuItem.Text = "&Remove";
			this.removeMenuItem.Click += new System.EventHandler(this.RemoveMenuItem_Click);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "Messenger Activity Monitor";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
			// 
			// startupCheckBox
			// 
			this.startupCheckBox.AutoSize = true;
			this.startupCheckBox.BackColor = System.Drawing.Color.Transparent;
			this.startupCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.startupCheckBox.Location = new System.Drawing.Point(19, 314);
			this.startupCheckBox.Name = "startupCheckBox";
			this.startupCheckBox.Size = new System.Drawing.Size(128, 17);
			this.startupCheckBox.TabIndex = 24;
			this.startupCheckBox.Text = "Start with Windows";
			this.startupCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.startupCheckBox.UseVisualStyleBackColor = false;
			this.startupCheckBox.Click += new System.EventHandler(this.StartupCheckBox_Click);
			// 
			// editMenuItem
			// 
			this.editMenuItem.Name = "editMenuItem";
			this.editMenuItem.Size = new System.Drawing.Size(88, 22);
			this.editMenuItem.Text = "&Edit";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::MessengerActivityMonitor.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(559, 380);
			this.Controls.Add(this.startupCheckBox);
			this.Controls.Add(this.updateIntervalNumericUpDown);
			this.Controls.Add(this.updateIntervalLabel);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.hideButton);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.titleLabel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(15, 50, 15, 15);
			this.Text = "Messenger Activity Monitor";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			((System.ComponentModel.ISupportInitialize)(this.updateIntervalNumericUpDown)).EndInit();
			this.ManageItemContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader processNameColumnHeader;
		private System.Windows.Forms.ColumnHeader personalMessageColumnHeader;
		private System.Windows.Forms.Button hideButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Label updateIntervalLabel;
		private System.Windows.Forms.Timer updateTimer;
		private System.Windows.Forms.NumericUpDown updateIntervalNumericUpDown;
		private System.Windows.Forms.ContextMenuStrip ManageItemContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
		private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        public System.Windows.Forms.CheckBox startupCheckBox;
		private System.Windows.Forms.ToolStripMenuItem editMenuItem;
	}
}

