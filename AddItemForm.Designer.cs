namespace MessengerActivityMonitor
{
	partial class AddItemForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
			this.iconComboBox = new System.Windows.Forms.ComboBox();
			this.processNameLabel = new System.Windows.Forms.Label();
			this.personalMessageLabel = new System.Windows.Forms.Label();
			this.iconLabel = new System.Windows.Forms.Label();
			this.personalMessageTextBox = new System.Windows.Forms.TextBox();
			this.processNameTextBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.IconImageList = new System.Windows.Forms.ImageList(this.components);
			this.changeStatusRadioButton = new System.Windows.Forms.RadioButton();
			this.noopRadioButton = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusPanel = new System.Windows.Forms.Panel();
			this.iconPictureBox = new System.Windows.Forms.PictureBox();
			this.warningLabel = new System.Windows.Forms.Label();
			this.warningPictureBox = new System.Windows.Forms.PictureBox();
			this.statusPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.warningPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// iconComboBox
			// 
			this.iconComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.iconComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.iconComboBox.FormattingEnabled = true;
			this.iconComboBox.Location = new System.Drawing.Point(132, 23);
			this.iconComboBox.Name = "iconComboBox";
			this.iconComboBox.Size = new System.Drawing.Size(254, 21);
			this.iconComboBox.TabIndex = 1;
			this.iconComboBox.SelectedValueChanged += new System.EventHandler(this.iconComboBox_SelectedValueChanged);
			// 
			// processNameLabel
			// 
			this.processNameLabel.AutoSize = true;
			this.processNameLabel.Location = new System.Drawing.Point(13, 13);
			this.processNameLabel.Name = "processNameLabel";
			this.processNameLabel.Size = new System.Drawing.Size(79, 13);
			this.processNameLabel.TabIndex = 1;
			this.processNameLabel.Text = "Process Name:";
			// 
			// personalMessageLabel
			// 
			this.personalMessageLabel.AutoSize = true;
			this.personalMessageLabel.Location = new System.Drawing.Point(-2, 3);
			this.personalMessageLabel.Name = "personalMessageLabel";
			this.personalMessageLabel.Size = new System.Drawing.Size(97, 13);
			this.personalMessageLabel.TabIndex = 2;
			this.personalMessageLabel.Text = "Personal Message:";
			// 
			// iconLabel
			// 
			this.iconLabel.AutoSize = true;
			this.iconLabel.Location = new System.Drawing.Point(-2, 26);
			this.iconLabel.Name = "iconLabel";
			this.iconLabel.Size = new System.Drawing.Size(31, 13);
			this.iconLabel.TabIndex = 3;
			this.iconLabel.Text = "Icon:";
			// 
			// personalMessageTextBox
			// 
			this.personalMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.personalMessageTextBox.Location = new System.Drawing.Point(106, 0);
			this.personalMessageTextBox.Name = "personalMessageTextBox";
			this.personalMessageTextBox.Size = new System.Drawing.Size(280, 20);
			this.personalMessageTextBox.TabIndex = 0;
			this.personalMessageTextBox.TextChanged += new System.EventHandler(this.Control_Changed);
			// 
			// processNameTextBox
			// 
			this.processNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.processNameTextBox.Location = new System.Drawing.Point(116, 10);
			this.processNameTextBox.Name = "processNameTextBox";
			this.processNameTextBox.Size = new System.Drawing.Size(286, 20);
			this.processNameTextBox.TabIndex = 0;
			this.processNameTextBox.TextChanged += new System.EventHandler(this.Control_Changed);
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.addButton.Enabled = false;
			this.addButton.Location = new System.Drawing.Point(327, 170);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 4;
			this.addButton.Text = "&Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.Button_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(246, 170);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.Button_Click);
			// 
			// IconImageList
			// 
			this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
			this.IconImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.IconImageList.Images.SetKeyName(0, "music.png");
			this.IconImageList.Images.SetKeyName(1, "games.png");
			this.IconImageList.Images.SetKeyName(2, "office.png");
			// 
			// changeStatusRadioButton
			// 
			this.changeStatusRadioButton.AutoSize = true;
			this.changeStatusRadioButton.Checked = true;
			this.changeStatusRadioButton.Location = new System.Drawing.Point(16, 80);
			this.changeStatusRadioButton.Name = "changeStatusRadioButton";
			this.changeStatusRadioButton.Size = new System.Drawing.Size(109, 17);
			this.changeStatusRadioButton.TabIndex = 2;
			this.changeStatusRadioButton.TabStop = true;
			this.changeStatusRadioButton.Text = "Change my status";
			this.changeStatusRadioButton.UseVisualStyleBackColor = true;
			this.changeStatusRadioButton.CheckedChanged += new System.EventHandler(this.Control_Changed);
			// 
			// noopRadioButton
			// 
			this.noopRadioButton.AutoSize = true;
			this.noopRadioButton.Location = new System.Drawing.Point(16, 57);
			this.noopRadioButton.Name = "noopRadioButton";
			this.noopRadioButton.Size = new System.Drawing.Size(77, 17);
			this.noopRadioButton.TabIndex = 1;
			this.noopRadioButton.Text = "Do nothing";
			this.noopRadioButton.UseVisualStyleBackColor = true;
			this.noopRadioButton.CheckedChanged += new System.EventHandler(this.Control_Changed);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(420, 1);
			this.panel1.TabIndex = 11;
			// 
			// statusPanel
			// 
			this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.statusPanel.Controls.Add(this.personalMessageLabel);
			this.statusPanel.Controls.Add(this.personalMessageTextBox);
			this.statusPanel.Controls.Add(this.iconComboBox);
			this.statusPanel.Controls.Add(this.iconLabel);
			this.statusPanel.Controls.Add(this.iconPictureBox);
			this.statusPanel.Location = new System.Drawing.Point(16, 103);
			this.statusPanel.Name = "statusPanel";
			this.statusPanel.Size = new System.Drawing.Size(386, 44);
			this.statusPanel.TabIndex = 3;
			// 
			// iconPictureBox
			// 
			this.iconPictureBox.Location = new System.Drawing.Point(109, 25);
			this.iconPictureBox.Name = "iconPictureBox";
			this.iconPictureBox.Size = new System.Drawing.Size(16, 16);
			this.iconPictureBox.TabIndex = 8;
			this.iconPictureBox.TabStop = false;
			// 
			// warningLabel
			// 
			this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.warningLabel.AutoSize = true;
			this.warningLabel.Location = new System.Drawing.Point(36, 174);
			this.warningLabel.Name = "warningLabel";
			this.warningLabel.Size = new System.Drawing.Size(47, 13);
			this.warningLabel.TabIndex = 9;
			this.warningLabel.Text = "Warning";
			this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.warningLabel.Visible = false;
			// 
			// warningPictureBox
			// 
			this.warningPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.warningPictureBox.Image = global::MessengerActivityMonitor.Properties.Resources.warning;
			this.warningPictureBox.Location = new System.Drawing.Point(17, 173);
			this.warningPictureBox.Name = "warningPictureBox";
			this.warningPictureBox.Size = new System.Drawing.Size(16, 16);
			this.warningPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.warningPictureBox.TabIndex = 12;
			this.warningPictureBox.TabStop = false;
			this.warningPictureBox.Visible = false;
			// 
			// AddItemForm
			// 
			this.AcceptButton = this.addButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(414, 205);
			this.ControlBox = false;
			this.Controls.Add(this.warningPictureBox);
			this.Controls.Add(this.warningLabel);
			this.Controls.Add(this.statusPanel);
			this.Controls.Add(this.noopRadioButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.changeStatusRadioButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.processNameTextBox);
			this.Controls.Add(this.processNameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddItemForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Item";
			this.statusPanel.ResumeLayout(false);
			this.statusPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.warningPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox iconComboBox;
		private System.Windows.Forms.Label processNameLabel;
		private System.Windows.Forms.Label personalMessageLabel;
		private System.Windows.Forms.Label iconLabel;
		private System.Windows.Forms.TextBox personalMessageTextBox;
		private System.Windows.Forms.TextBox processNameTextBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.PictureBox iconPictureBox;
		private System.Windows.Forms.ImageList IconImageList;
		private System.Windows.Forms.RadioButton changeStatusRadioButton;
		private System.Windows.Forms.RadioButton noopRadioButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel statusPanel;
		private System.Windows.Forms.Label warningLabel;
		private System.Windows.Forms.PictureBox warningPictureBox;
	}
}