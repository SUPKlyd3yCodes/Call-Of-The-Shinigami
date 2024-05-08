namespace CallOfTheShinigami
{
    partial class frmGameVN
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameVN));
			this.picDialogueBox = new System.Windows.Forms.PictureBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblDialogue = new System.Windows.Forms.Label();
			this.picScare = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.picMC = new System.Windows.Forms.PictureBox();
			this.picMotherHappy = new System.Windows.Forms.PictureBox();
			this.picMotherScared = new System.Windows.Forms.PictureBox();
			this.picMotherVeryHappy = new System.Windows.Forms.PictureBox();
			this.picPortal = new System.Windows.Forms.PictureBox();
			this.picShinigami = new System.Windows.Forms.PictureBox();
			this.picFood = new System.Windows.Forms.PictureBox();
			this.picRubyEyes = new System.Windows.Forms.PictureBox();
			this.picArtifact = new System.Windows.Forms.PictureBox();
			this.lblHints = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picDialogueBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picScare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherHappy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherScared)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherVeryHappy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPortal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picShinigami)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRubyEyes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picArtifact)).BeginInit();
			this.SuspendLayout();
			// 
			// picDialogueBox
			// 
			this.picDialogueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.picDialogueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDialogueBox.Location = new System.Drawing.Point(133, 321);
			this.picDialogueBox.Name = "picDialogueBox";
			this.picDialogueBox.Size = new System.Drawing.Size(643, 172);
			this.picDialogueBox.TabIndex = 0;
			this.picDialogueBox.TabStop = false;
			this.picDialogueBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picDialogueBox_Paint);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblName.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblName.Location = new System.Drawing.Point(160, 337);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(53, 33);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "MC";
			// 
			// lblDialogue
			// 
			this.lblDialogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.lblDialogue.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold);
			this.lblDialogue.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblDialogue.Location = new System.Drawing.Point(182, 403);
			this.lblDialogue.Name = "lblDialogue";
			this.lblDialogue.Size = new System.Drawing.Size(557, 64);
			this.lblDialogue.TabIndex = 2;
			this.lblDialogue.Text = "MC";
			// 
			// picScare
			// 
			this.picScare.BackColor = System.Drawing.Color.Transparent;
			this.picScare.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.HangedWoman;
			this.picScare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picScare.Location = new System.Drawing.Point(-39, -30);
			this.picScare.Name = "picScare";
			this.picScare.Size = new System.Drawing.Size(170, 194);
			this.picScare.TabIndex = 3;
			this.picScare.TabStop = false;
			this.picScare.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// picMC
			// 
			this.picMC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picMC.BackColor = System.Drawing.Color.Transparent;
			this.picMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picMC.Image = global::CallOfTheShinigami.Properties.Resources.MCMaleHappy;
			this.picMC.Location = new System.Drawing.Point(-39, 216);
			this.picMC.Name = "picMC";
			this.picMC.Size = new System.Drawing.Size(190, 277);
			this.picMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMC.TabIndex = 4;
			this.picMC.TabStop = false;
			// 
			// picMotherHappy
			// 
			this.picMotherHappy.BackColor = System.Drawing.Color.Transparent;
			this.picMotherHappy.Image = global::CallOfTheShinigami.Properties.Resources.MotherHappy;
			this.picMotherHappy.Location = new System.Drawing.Point(300, 23);
			this.picMotherHappy.Name = "picMotherHappy";
			this.picMotherHappy.Size = new System.Drawing.Size(234, 298);
			this.picMotherHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMotherHappy.TabIndex = 6;
			this.picMotherHappy.TabStop = false;
			this.picMotherHappy.Visible = false;
			// 
			// picMotherScared
			// 
			this.picMotherScared.BackColor = System.Drawing.Color.Transparent;
			this.picMotherScared.Image = global::CallOfTheShinigami.Properties.Resources.MotherScared;
			this.picMotherScared.Location = new System.Drawing.Point(300, 23);
			this.picMotherScared.Name = "picMotherScared";
			this.picMotherScared.Size = new System.Drawing.Size(234, 298);
			this.picMotherScared.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMotherScared.TabIndex = 7;
			this.picMotherScared.TabStop = false;
			this.picMotherScared.Visible = false;
			// 
			// picMotherVeryHappy
			// 
			this.picMotherVeryHappy.BackColor = System.Drawing.Color.Transparent;
			this.picMotherVeryHappy.Image = global::CallOfTheShinigami.Properties.Resources.MotherVeryHappy;
			this.picMotherVeryHappy.Location = new System.Drawing.Point(300, 23);
			this.picMotherVeryHappy.Name = "picMotherVeryHappy";
			this.picMotherVeryHappy.Size = new System.Drawing.Size(234, 298);
			this.picMotherVeryHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMotherVeryHappy.TabIndex = 8;
			this.picMotherVeryHappy.TabStop = false;
			this.picMotherVeryHappy.Visible = false;
			// 
			// picPortal
			// 
			this.picPortal.BackColor = System.Drawing.Color.Transparent;
			this.picPortal.Image = global::CallOfTheShinigami.Properties.Resources.Portal;
			this.picPortal.Location = new System.Drawing.Point(107, 17);
			this.picPortal.Name = "picPortal";
			this.picPortal.Size = new System.Drawing.Size(289, 304);
			this.picPortal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPortal.TabIndex = 9;
			this.picPortal.TabStop = false;
			this.picPortal.Visible = false;
			// 
			// picShinigami
			// 
			this.picShinigami.BackColor = System.Drawing.Color.Transparent;
			this.picShinigami.Image = ((System.Drawing.Image)(resources.GetObject("picShinigami.Image")));
			this.picShinigami.Location = new System.Drawing.Point(402, 17);
			this.picShinigami.Name = "picShinigami";
			this.picShinigami.Size = new System.Drawing.Size(230, 304);
			this.picShinigami.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picShinigami.TabIndex = 10;
			this.picShinigami.TabStop = false;
			this.picShinigami.Visible = false;
			// 
			// picFood
			// 
			this.picFood.BackColor = System.Drawing.Color.Transparent;
			this.picFood.Image = global::CallOfTheShinigami.Properties.Resources.OmeletteRice;
			this.picFood.Location = new System.Drawing.Point(115, 158);
			this.picFood.Name = "picFood";
			this.picFood.Size = new System.Drawing.Size(228, 162);
			this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFood.TabIndex = 11;
			this.picFood.TabStop = false;
			this.picFood.Visible = false;
			// 
			// picRubyEyes
			// 
			this.picRubyEyes.BackColor = System.Drawing.Color.Transparent;
			this.picRubyEyes.Image = global::CallOfTheShinigami.Properties.Resources.RubyEyes;
			this.picRubyEyes.Location = new System.Drawing.Point(232, 32);
			this.picRubyEyes.Name = "picRubyEyes";
			this.picRubyEyes.Size = new System.Drawing.Size(336, 259);
			this.picRubyEyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picRubyEyes.TabIndex = 13;
			this.picRubyEyes.TabStop = false;
			this.picRubyEyes.Visible = false;
			// 
			// picArtifact
			// 
			this.picArtifact.BackColor = System.Drawing.Color.Transparent;
			this.picArtifact.Image = global::CallOfTheShinigami.Properties.Resources.Artifact;
			this.picArtifact.Location = new System.Drawing.Point(99, 47);
			this.picArtifact.Name = "picArtifact";
			this.picArtifact.Size = new System.Drawing.Size(336, 259);
			this.picArtifact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picArtifact.TabIndex = 14;
			this.picArtifact.TabStop = false;
			this.picArtifact.Visible = false;
			// 
			// lblHints
			// 
			this.lblHints.AutoSize = true;
			this.lblHints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblHints.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold);
			this.lblHints.Location = new System.Drawing.Point(352, 324);
			this.lblHints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHints.Name = "lblHints";
			this.lblHints.Size = new System.Drawing.Size(182, 18);
			this.lblHints.TabIndex = 15;
			this.lblHints.Text = "Press space or enter to skip";
			// 
			// frmGameVN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.Home;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(774, 490);
			this.Controls.Add(this.picScare);
			this.Controls.Add(this.lblHints);
			this.Controls.Add(this.picArtifact);
			this.Controls.Add(this.picRubyEyes);
			this.Controls.Add(this.picFood);
			this.Controls.Add(this.picShinigami);
			this.Controls.Add(this.picPortal);
			this.Controls.Add(this.picMotherVeryHappy);
			this.Controls.Add(this.picMotherScared);
			this.Controls.Add(this.picMotherHappy);
			this.Controls.Add(this.lblDialogue);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.picDialogueBox);
			this.Controls.Add(this.picMC);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmGameVN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Call of the Shinigami";
			this.Load += new System.EventHandler(this.frmGameVN_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameVN_KeyDown);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmGameVN_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.picDialogueBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picScare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherHappy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherScared)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherVeryHappy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPortal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picShinigami)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRubyEyes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picArtifact)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.PictureBox picDialogueBox;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblDialogue;
		private System.Windows.Forms.PictureBox picScare;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox picMC;
		private System.Windows.Forms.PictureBox picMotherHappy;
		private System.Windows.Forms.PictureBox picMotherScared;
		private System.Windows.Forms.PictureBox picMotherVeryHappy;
		private System.Windows.Forms.PictureBox picPortal;
		private System.Windows.Forms.PictureBox picShinigami;
		private System.Windows.Forms.PictureBox picFood;
		private System.Windows.Forms.PictureBox picRubyEyes;
		private System.Windows.Forms.PictureBox picArtifact;
		private System.Windows.Forms.Label lblHints;
	}
}