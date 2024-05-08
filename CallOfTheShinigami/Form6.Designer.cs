namespace CallOfTheShinigami
{
	partial class frmGameOver
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
			this.lblTitle1 = new System.Windows.Forms.Label();
			this.lblTitle3 = new System.Windows.Forms.Label();
			this.tmrKick = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblTitle1
			// 
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle1.Font = new System.Drawing.Font("Niagara Solid", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblTitle1.Location = new System.Drawing.Point(327, 145);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new System.Drawing.Size(401, 128);
			this.lblTitle1.TabIndex = 4;
			this.lblTitle1.Text = "Your Soul is";
			// 
			// lblTitle3
			// 
			this.lblTitle3.AutoSize = true;
			this.lblTitle3.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle3.Font = new System.Drawing.Font("Niagara Solid", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle3.Location = new System.Drawing.Point(421, 273);
			this.lblTitle3.Name = "lblTitle3";
			this.lblTitle3.Size = new System.Drawing.Size(250, 128);
			this.lblTitle3.TabIndex = 3;
			this.lblTitle3.Text = "LOST...";
			// 
			// tmrKick
			// 
			this.tmrKick.Interval = 5000;
			this.tmrKick.Tick += new System.EventHandler(this.tmrKick_Tick);
			// 
			// frmGameOver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.GameOverBG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1032, 603);
			this.Controls.Add(this.lblTitle1);
			this.Controls.Add(this.lblTitle3);
			this.Name = "frmGameOver";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game Over";
			this.Load += new System.EventHandler(this.frmGameOver_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle1;
		private System.Windows.Forms.Label lblTitle3;
		private System.Windows.Forms.Timer tmrKick;
	}
}