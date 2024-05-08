using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallOfTheShinigami
{
    public partial class frmGameSelection : Form
    {
        public frmGameSelection()
        {
            InitializeComponent();
        }

		//creates a class of the character's info
		public static class characterInformation
		{
			public static string Username { get; set; }
			public static string GenderOption { get; set; }
		}

		//changes image based on gender
		private void cboGender_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cboGender.SelectedItem.ToString() == "Male")
			{
				characterInformation.GenderOption = "Male";
				picAvatar.BackgroundImage = Properties.Resources.MCMaleHappy;
			} else if (cboGender.SelectedItem.ToString() == "Female")
			{
				characterInformation.GenderOption = "Female";
				picAvatar.BackgroundImage = Properties.Resources.MCFemaleHappy;
			} else if (cboGender.SelectedItem == null) 
			{
				characterInformation.GenderOption = "Male";
				picAvatar.BackgroundImage = Properties.Resources.MCMaleHappy;
			}
		}

		//creates a character with the inputted values and puts default values
		private void cmdCreate_Click(object sender, EventArgs e)
        {
			this.Hide();
			frmGameVN Game = new frmGameVN();
			if (txtName.Text.Length == 0)
			{
				characterInformation.Username = "John";
			}
			else
			{
				characterInformation.Username = txtName.Text;
			}

			if (cboGender.SelectedItem == null)
			{
				characterInformation.GenderOption = "Male";
				picAvatar.BackgroundImage = Properties.Resources.MCMaleHappy;
			}
			Game.ShowDialog();
			this.Close();
		}

		//done so space and enter doesn't go to the next form
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Enter || keyData == Keys.Space)
			{
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}
	}
}
