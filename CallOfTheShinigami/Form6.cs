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
	public partial class frmGameOver : Form
	{
		public frmGameOver()
		{
			InitializeComponent();
		}

		private void tmrKick_Tick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmGameOver_Load(object sender, EventArgs e)
		{
			tmrKick.Enabled = true;        
		}
	}
}
