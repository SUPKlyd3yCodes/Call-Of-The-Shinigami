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
    public partial class frmTitleScreen : Form
    {
        public frmTitleScreen()
        {
            InitializeComponent();
        }

		//Exits the application
        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		//Goes to the game selection form
        private void cmdNewGame_Click(object sender, EventArgs e)
        {
			this.Hide();
			frmGameSelection GameSelection = new frmGameSelection();
			GameSelection.ShowDialog();
			this.Close();
		}

		//Overrides so that enter and space won't proceed to next form
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Enter || keyData == Keys.Space)
			{
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}

		private void cmdCredits_Click(object sender, EventArgs e)
		{
			frmCredits Credits = new frmCredits();
			Credits.ShowDialog();
		}
	}
}
