namespace CallOfTheShinigami
{
	partial class frmVNFinale
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
			this.cmdReject = new System.Windows.Forms.Button();
			this.cmdAccept = new System.Windows.Forms.Button();
			this.lblDialogue = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.picDialogueBox = new System.Windows.Forms.PictureBox();
			this.picMC = new System.Windows.Forms.PictureBox();
			this.picArtifact = new System.Windows.Forms.PictureBox();
			this.picShinigami = new System.Windows.Forms.PictureBox();
			this.lblHints = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picDialogueBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picArtifact)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picShinigami)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdReject
			// 
			this.cmdReject.BackColor = System.Drawing.Color.DimGray;
			this.cmdReject.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdReject.Location = new System.Drawing.Point(554, 267);
			this.cmdReject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmdReject.Name = "cmdReject";
			this.cmdReject.Size = new System.Drawing.Size(121, 48);
			this.cmdReject.TabIndex = 23;
			this.cmdReject.Text = "Don\'t";
			this.cmdReject.UseVisualStyleBackColor = false;
			this.cmdReject.Visible = false;
			this.cmdReject.Click += new System.EventHandler(this.cmdReject_Click);
			// 
			// cmdAccept
			// 
			this.cmdAccept.BackColor = System.Drawing.Color.DimGray;
			this.cmdAccept.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdAccept.Location = new System.Drawing.Point(169, 267);
			this.cmdAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmdAccept.Name = "cmdAccept";
			this.cmdAccept.Size = new System.Drawing.Size(121, 48);
			this.cmdAccept.TabIndex = 22;
			this.cmdAccept.Text = "Activate";
			this.cmdAccept.UseVisualStyleBackColor = false;
			this.cmdAccept.Visible = false;
			this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
			// 
			// lblDialogue
			// 
			this.lblDialogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.lblDialogue.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDialogue.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblDialogue.Location = new System.Drawing.Point(195, 402);
			this.lblDialogue.Name = "lblDialogue";
			this.lblDialogue.Size = new System.Drawing.Size(557, 80);
			this.lblDialogue.TabIndex = 20;
			this.lblDialogue.Text = "MC";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblName.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblName.Location = new System.Drawing.Point(172, 336);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(53, 33);
			this.lblName.TabIndex = 19;
			this.lblName.Text = "MC";
			// 
			// picDialogueBox
			// 
			this.picDialogueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.picDialogueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDialogueBox.Location = new System.Drawing.Point(146, 320);
			this.picDialogueBox.Name = "picDialogueBox";
			this.picDialogueBox.Size = new System.Drawing.Size(643, 172);
			this.picDialogueBox.TabIndex = 18;
			this.picDialogueBox.TabStop = false;
			// 
			// picMC
			// 
			this.picMC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picMC.BackColor = System.Drawing.Color.Transparent;
			this.picMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picMC.Image = global::CallOfTheShinigami.Properties.Resources.MCMaleHappy;
			this.picMC.Location = new System.Drawing.Point(-26, 215);
			this.picMC.Name = "picMC";
			this.picMC.Size = new System.Drawing.Size(190, 277);
			this.picMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMC.TabIndex = 21;
			this.picMC.TabStop = false;
			// 
			// picArtifact
			// 
			this.picArtifact.BackColor = System.Drawing.Color.Transparent;
			this.picArtifact.Image = global::CallOfTheShinigami.Properties.Resources.Artifact;
			this.picArtifact.Location = new System.Drawing.Point(294, 106);
			this.picArtifact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picArtifact.Name = "picArtifact";
			this.picArtifact.Size = new System.Drawing.Size(241, 188);
			this.picArtifact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picArtifact.TabIndex = 24;
			this.picArtifact.TabStop = false;
			this.picArtifact.Visible = false;
			// 
			// picShinigami
			// 
			this.picShinigami.BackColor = System.Drawing.Color.Transparent;
			this.picShinigami.Image = global::CallOfTheShinigami.Properties.Resources.Shinigami;
			this.picShinigami.Location = new System.Drawing.Point(344, 55);
			this.picShinigami.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picShinigami.Name = "picShinigami";
			this.picShinigami.Size = new System.Drawing.Size(167, 266);
			this.picShinigami.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picShinigami.TabIndex = 25;
			this.picShinigami.TabStop = false;
			this.picShinigami.Visible = false;
			// 
			// lblHints
			// 
			this.lblHints.AutoSize = true;
			this.lblHints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblHints.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold);
			this.lblHints.Location = new System.Drawing.Point(353, 323);
			this.lblHints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHints.Name = "lblHints";
			this.lblHints.Size = new System.Drawing.Size(182, 18);
			this.lblHints.TabIndex = 26;
			this.lblHints.Text = "Press space or enter to skip";
			// 
			// frmVNFinale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.NightmareBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(774, 490);
			this.Controls.Add(this.lblHints);
			this.Controls.Add(this.picShinigami);
			this.Controls.Add(this.picArtifact);
			this.Controls.Add(this.cmdReject);
			this.Controls.Add(this.cmdAccept);
			this.Controls.Add(this.lblDialogue);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.picDialogueBox);
			this.Controls.Add(this.picMC);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmVNFinale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Call of the Shinigami";
			this.Load += new System.EventHandler(this.frmVNFinale_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmVNFinale_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.picDialogueBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picArtifact)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picShinigami)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdReject;
		private System.Windows.Forms.Button cmdAccept;
		private System.Windows.Forms.Label lblDialogue;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.PictureBox picDialogueBox;
		private System.Windows.Forms.PictureBox picMC;
		private System.Windows.Forms.PictureBox picArtifact;
		private System.Windows.Forms.PictureBox picShinigami;
		private System.Windows.Forms.Label lblHints;
	}
}