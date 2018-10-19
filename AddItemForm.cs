using System;
using System.Windows.Forms;
using MessengerDotNet;

namespace MessengerActivityMonitor
{
	public partial class AddItemForm : Form
	{
		public string ProcessName => this.processNameTextBox.Text;
		public string PersonalMessge => this.personalMessageTextBox.Text;
		public MessengerActivityType ActivityType => (MessengerActivityType)this.iconComboBox.SelectedItem;
		public bool NoOperation => this.noopRadioButton.Checked;


		public AddItemForm()
		{
			InitializeComponent();
			AddItemsToComboBox();
		}

		private void AddItemsToComboBox()
		{
			iconComboBox.Items.Clear();
			foreach (var item in Enum.GetValues(typeof(MessengerActivityType)))
			{
				iconComboBox.Items.Add(item);
			}
			iconComboBox.SelectedIndex = 0;
		}

		private void Button_Click(object sender, EventArgs e) => this.Close();

		private void iconComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			if (iconComboBox.SelectedItem is MessengerActivityType)
			{
				var activity = (MessengerActivityType)iconComboBox.SelectedItem;
				var index = (int)activity;
				var icon = IconImageList.Images[index];
				iconPictureBox.Image = icon;
			}
		}

		public void ValidateForm()
		{
			string reason = "";

			if (string.IsNullOrWhiteSpace(processNameTextBox.Text))
			{
				reason = "Process name is empty";
			}
			else if (processNameTextBox.Text.ToLower().Contains(".exe"))
			{
				reason = "File extensions are not supported";
			}
			else if (!noopRadioButton.Checked && changeStatusRadioButton.Checked)
			{
				if (string.IsNullOrWhiteSpace(personalMessageTextBox.Text))
				{
					reason = "Personal message is empty";
				}
			}
			statusPanel.Enabled = changeStatusRadioButton.Checked;

			bool inputValid = string.IsNullOrWhiteSpace(reason);

			addButton.Enabled = inputValid;
			warningLabel.Visible = !inputValid;
			warningPictureBox.Visible = !inputValid;
			if (!inputValid)
			{
				warningLabel.Text = reason;
			}
		}

		private void Control_Changed(object sender, EventArgs e) => ValidateForm();
	}
}
