namespace CallOfTheShinigami
{
	partial class frmVisualNovel2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualNovel2));
			this.lblDialogue = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.picLust = new System.Windows.Forms.PictureBox();
			this.picFood = new System.Windows.Forms.PictureBox();
			this.picMotherHappy = new System.Windows.Forms.PictureBox();
			this.picMotherScared = new System.Windows.Forms.PictureBox();
			this.picMotherVeryHappy = new System.Windows.Forms.PictureBox();
			this.picDialogueBox = new System.Windows.Forms.PictureBox();
			this.picMC = new System.Windows.Forms.PictureBox();
			this.picDrawing = new System.Windows.Forms.PictureBox();
			this.picLetter = new System.Windows.Forms.PictureBox();
			this.cmdAccept = new System.Windows.Forms.Button();
			this.cmdReject = new System.Windows.Forms.Button();
			this.tmrTicker = new System.Windows.Forms.Timer(this.components);
			this.picLustJumpscare = new System.Windows.Forms.PictureBox();
			this.tmrDeath = new System.Windows.Forms.Timer(this.components);
			this.lblHints = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picLust)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherHappy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherScared)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherVeryHappy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDialogueBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDrawing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLetter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLustJumpscare)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDialogue
			// 
			this.lblDialogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.lblDialogue.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDialogue.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblDialogue.Location = new System.Drawing.Point(199, 403);
			this.lblDialogue.Name = "lblDialogue";
			this.lblDialogue.Size = new System.Drawing.Size(557, 64);
			this.lblDialogue.TabIndex = 7;
			this.lblDialogue.Text = "MC";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblName.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblName.Location = new System.Drawing.Point(176, 337);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(53, 33);
			this.lblName.TabIndex = 6;
			this.lblName.Text = "MC";
			// 
			// picLust
			// 
			this.picLust.BackColor = System.Drawing.Color.Transparent;
			this.picLust.Image = ((System.Drawing.Image)(resources.GetObject("picLust.Image")));
			this.picLust.Location = new System.Drawing.Point(327, 24);
			this.picLust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picLust.Name = "picLust";
			this.picLust.Size = new System.Drawing.Size(217, 298);
			this.picLust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLust.TabIndex = 13;
			this.picLust.TabStop = false;
			this.picLust.Visible = false;
			// 
			// picFood
			// 
			this.picFood.BackColor = System.Drawing.Color.Transparent;
			this.picFood.Image = global::CallOfTheShinigami.Properties.Resources.OmeletteRice;
			this.picFood.Location = new System.Drawing.Point(129, 136);
			this.picFood.Name = "picFood";
			this.picFood.Size = new System.Drawing.Size(228, 162);
			this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFood.TabIndex = 12;
			this.picFood.TabStop = false;
			this.picFood.Visible = false;
			// 
			// picMotherHappy
			// 
			this.picMotherHappy.BackColor = System.Drawing.Color.Transparent;
			this.picMotherHappy.Image = global::CallOfTheShinigami.Properties.Resources.MotherHappy;
			this.picMotherHappy.Location = new System.Drawing.Point(319, 24);
			this.picMotherHappy.Name = "picMotherHappy";
			this.picMotherHappy.Size = new System.Drawing.Size(234, 298);
			this.picMotherHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMotherHappy.TabIndex = 11;
			this.picMotherHappy.TabStop = false;
			this.picMotherHappy.Visible = false;
			// 
			// picMotherScared
			// 
			this.picMotherScared.BackColor = System.Drawing.Color.Transparent;
			this.picMotherScared.Image = global::CallOfTheShinigami.Properties.Resources.MotherScared;
			this.picMotherScared.Location = new System.Drawing.Point(319, 24);
			this.picMotherScared.Name = "picMotherScared";
			this.picMotherScared.Size = new System.Drawing.Size(234, 298);
			this.picMotherScared.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMotherScared.TabIndex = 10;
			this.picMotherScared.TabStop = false;
			this.picMotherScared.Visible = false;
			// 
			// picMotherVeryHappy
			// 
			this.picMotherVeryHappy.BackColor = System.Drawing.Color.Transparent;
			this.picMotherVeryHappy.Image = global::CallOfTheShinigami.Properties.Resources.MotherVeryHappy;
			this.picMotherVeryHappy.Location = new System.Drawing.Point(319, 24);
			this.picMotherVeryHappy.Name = "picMotherVeryHappy";
			this.picMotherVeryHappy.Size = new System.Drawing.Size(234, 298);
			this.picMotherVeryHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMotherVeryHappy.TabIndex = 9;
			this.picMotherVeryHappy.TabStop = false;
			this.picMotherVeryHappy.Visible = false;
			// 
			// picDialogueBox
			// 
			this.picDialogueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.picDialogueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDialogueBox.Location = new System.Drawing.Point(149, 321);
			this.picDialogueBox.Name = "picDialogueBox";
			this.picDialogueBox.Size = new System.Drawing.Size(643, 172);
			this.picDialogueBox.TabIndex = 5;
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
			this.picMC.Location = new System.Drawing.Point(-22, 216);
			this.picMC.Name = "picMC";
			this.picMC.Size = new System.Drawing.Size(190, 277);
			this.picMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMC.TabIndex = 8;
			this.picMC.TabStop = false;
			// 
			// picDrawing
			// 
			this.picDrawing.BackColor = System.Drawing.Color.Transparent;
			this.picDrawing.Image = global::CallOfTheShinigami.Properties.Resources.DrawingFemale;
			this.picDrawing.Location = new System.Drawing.Point(122, 61);
			this.picDrawing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picDrawing.Name = "picDrawing";
			this.picDrawing.Size = new System.Drawing.Size(228, 229);
			this.picDrawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picDrawing.TabIndex = 14;
			this.picDrawing.TabStop = false;
			this.picDrawing.Visible = false;
			// 
			// picLetter
			// 
			this.picLetter.BackColor = System.Drawing.Color.Transparent;
			this.picLetter.Image = global::CallOfTheShinigami.Properties.Resources.Letter;
			this.picLetter.Location = new System.Drawing.Point(149, 167);
			this.picLetter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picLetter.Name = "picLetter";
			this.picLetter.Size = new System.Drawing.Size(173, 132);
			this.picLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLetter.TabIndex = 15;
			this.picLetter.TabStop = false;
			this.picLetter.Visible = false;
			// 
			// cmdAccept
			// 
			this.cmdAccept.BackColor = System.Drawing.Color.DimGray;
			this.cmdAccept.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdAccept.Location = new System.Drawing.Point(172, 268);
			this.cmdAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmdAccept.Name = "cmdAccept";
			this.cmdAccept.Size = new System.Drawing.Size(121, 48);
			this.cmdAccept.TabIndex = 16;
			this.cmdAccept.Text = "I do too!";
			this.cmdAccept.UseVisualStyleBackColor = false;
			this.cmdAccept.Visible = false;
			this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
			// 
			// cmdReject
			// 
			this.cmdReject.BackColor = System.Drawing.Color.DimGray;
			this.cmdReject.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdReject.Location = new System.Drawing.Point(558, 268);
			this.cmdReject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmdReject.Name = "cmdReject";
			this.cmdReject.Size = new System.Drawing.Size(121, 48);
			this.cmdReject.TabIndex = 17;
			this.cmdReject.Text = "I\'m sorry";
			this.cmdReject.UseVisualStyleBackColor = false;
			this.cmdReject.Visible = false;
			this.cmdReject.Click += new System.EventHandler(this.cmdReject_Click);
			// 
			// tmrTicker
			// 
			this.tmrTicker.Interval = 700;
			this.tmrTicker.Tick += new System.EventHandler(this.tmrTicker_Tick);
			// 
			// picLustJumpscare
			// 
			this.picLustJumpscare.BackColor = System.Drawing.Color.Transparent;
			this.picLustJumpscare.Image = ((System.Drawing.Image)(resources.GetObject("picLustJumpscare.Image")));
			this.picLustJumpscare.Location = new System.Drawing.Point(558, -42);
			this.picLustJumpscare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picLustJumpscare.Name = "picLustJumpscare";
			this.picLustJumpscare.Size = new System.Drawing.Size(217, 298);
			this.picLustJumpscare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLustJumpscare.TabIndex = 18;
			this.picLustJumpscare.TabStop = false;
			this.picLustJumpscare.Visible = false;
			// 
			// tmrDeath
			// 
			this.tmrDeath.Interval = 4000;
			this.tmrDeath.Tick += new System.EventHandler(this.tmrDeath_Tick);
			// 
			// lblHints
			// 
			this.lblHints.AutoSize = true;
			this.lblHints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblHints.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold);
			this.lblHints.Location = new System.Drawing.Point(362, 325);
			this.lblHints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHints.Name = "lblHints";
			this.lblHints.Size = new System.Drawing.Size(182, 18);
			this.lblHints.TabIndex = 19;
			this.lblHints.Text = "Press space or enter to skip";
			// 
			// frmVisualNovel2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.Home;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(774, 490);
			this.Controls.Add(this.lblHints);
			this.Controls.Add(this.picLustJumpscare);
			this.Controls.Add(this.cmdReject);
			this.Controls.Add(this.cmdAccept);
			this.Controls.Add(this.picLetter);
			this.Controls.Add(this.picDrawing);
			this.Controls.Add(this.picLust);
			this.Controls.Add(this.picFood);
			this.Controls.Add(this.picMotherHappy);
			this.Controls.Add(this.picMotherScared);
			this.Controls.Add(this.picMotherVeryHappy);
			this.Controls.Add(this.lblDialogue);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.picDialogueBox);
			this.Controls.Add(this.picMC);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmVisualNovel2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Call of the Shinigami";
			this.Load += new System.EventHandler(this.frmVisualNovel2_Load);
			this.Click += new System.EventHandler(this.frmVisualNovel2_Click);
			((System.ComponentModel.ISupportInitialize)(this.picLust)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherHappy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherScared)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherVeryHappy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDialogueBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDrawing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLetter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLustJumpscare)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDialogue;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.PictureBox picDialogueBox;
		private System.Windows.Forms.PictureBox picMC;
		private System.Windows.Forms.PictureBox picMotherVeryHappy;
		private System.Windows.Forms.PictureBox picMotherScared;
		private System.Windows.Forms.PictureBox picMotherHappy;
		private System.Windows.Forms.PictureBox picFood;
		private System.Windows.Forms.PictureBox picLust;
		private System.Windows.Forms.PictureBox picDrawing;
		private System.Windows.Forms.PictureBox picLetter;
		private System.Windows.Forms.Button cmdAccept;
		private System.Windows.Forms.Button cmdReject;
		private System.Windows.Forms.Timer tmrTicker;
		private System.Windows.Forms.PictureBox picLustJumpscare;
		private System.Windows.Forms.Timer tmrDeath;
		private System.Windows.Forms.Label lblHints;
	}
}