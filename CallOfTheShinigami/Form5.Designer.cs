namespace CallOfTheShinigami
{
	partial class frmAttacking
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
			this.prgCharacter = new System.Windows.Forms.ProgressBar();
			this.prgEnemy = new System.Windows.Forms.ProgressBar();
			this.lblEnemyName = new System.Windows.Forms.Label();
			this.cmdAttack = new System.Windows.Forms.Button();
			this.lblCharacterHealth = new System.Windows.Forms.Label();
			this.lblEnemyHealth = new System.Windows.Forms.Label();
			this.picEnemy = new System.Windows.Forms.PictureBox();
			this.cmdDefend = new System.Windows.Forms.Button();
			this.cmdHeal = new System.Windows.Forms.Button();
			this.txtComment = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
			this.SuspendLayout();
			// 
			// prgCharacter
			// 
			this.prgCharacter.Location = new System.Drawing.Point(33, 374);
			this.prgCharacter.Margin = new System.Windows.Forms.Padding(4);
			this.prgCharacter.Name = "prgCharacter";
			this.prgCharacter.Size = new System.Drawing.Size(336, 39);
			this.prgCharacter.TabIndex = 0;
			// 
			// prgEnemy
			// 
			this.prgEnemy.Location = new System.Drawing.Point(659, 34);
			this.prgEnemy.Margin = new System.Windows.Forms.Padding(4);
			this.prgEnemy.Name = "prgEnemy";
			this.prgEnemy.Size = new System.Drawing.Size(336, 39);
			this.prgEnemy.TabIndex = 1;
			// 
			// lblEnemyName
			// 
			this.lblEnemyName.AutoSize = true;
			this.lblEnemyName.BackColor = System.Drawing.Color.Transparent;
			this.lblEnemyName.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold);
			this.lblEnemyName.ForeColor = System.Drawing.Color.White;
			this.lblEnemyName.Location = new System.Drawing.Point(27, 34);
			this.lblEnemyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEnemyName.Name = "lblEnemyName";
			this.lblEnemyName.Size = new System.Drawing.Size(123, 34);
			this.lblEnemyName.TabIndex = 2;
			this.lblEnemyName.Text = "Turn: ";
			// 
			// cmdAttack
			// 
			this.cmdAttack.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.cmdAttack.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAttack.Location = new System.Drawing.Point(212, 538);
			this.cmdAttack.Margin = new System.Windows.Forms.Padding(4);
			this.cmdAttack.Name = "cmdAttack";
			this.cmdAttack.Size = new System.Drawing.Size(128, 52);
			this.cmdAttack.TabIndex = 3;
			this.cmdAttack.Text = "Attack";
			this.cmdAttack.UseVisualStyleBackColor = false;
			this.cmdAttack.Click += new System.EventHandler(this.cmdAttack_Click);
			// 
			// lblCharacterHealth
			// 
			this.lblCharacterHealth.AutoSize = true;
			this.lblCharacterHealth.BackColor = System.Drawing.Color.Transparent;
			this.lblCharacterHealth.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCharacterHealth.ForeColor = System.Drawing.Color.White;
			this.lblCharacterHealth.Location = new System.Drawing.Point(28, 417);
			this.lblCharacterHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCharacterHealth.Name = "lblCharacterHealth";
			this.lblCharacterHealth.Size = new System.Drawing.Size(102, 27);
			this.lblCharacterHealth.TabIndex = 4;
			this.lblCharacterHealth.Text = "Turn: ";
			// 
			// lblEnemyHealth
			// 
			this.lblEnemyHealth.AutoSize = true;
			this.lblEnemyHealth.BackColor = System.Drawing.Color.Transparent;
			this.lblEnemyHealth.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnemyHealth.ForeColor = System.Drawing.Color.White;
			this.lblEnemyHealth.Location = new System.Drawing.Point(653, 78);
			this.lblEnemyHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEnemyHealth.Name = "lblEnemyHealth";
			this.lblEnemyHealth.Size = new System.Drawing.Size(102, 27);
			this.lblEnemyHealth.TabIndex = 5;
			this.lblEnemyHealth.Text = "Turn: ";
			// 
			// picEnemy
			// 
			this.picEnemy.BackColor = System.Drawing.Color.Transparent;
			this.picEnemy.Location = new System.Drawing.Point(404, 163);
			this.picEnemy.Name = "picEnemy";
			this.picEnemy.Size = new System.Drawing.Size(250, 250);
			this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picEnemy.TabIndex = 6;
			this.picEnemy.TabStop = false;
			// 
			// cmdDefend
			// 
			this.cmdDefend.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.cmdDefend.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDefend.Location = new System.Drawing.Point(459, 538);
			this.cmdDefend.Margin = new System.Windows.Forms.Padding(4);
			this.cmdDefend.Name = "cmdDefend";
			this.cmdDefend.Size = new System.Drawing.Size(128, 52);
			this.cmdDefend.TabIndex = 7;
			this.cmdDefend.Text = "Defend";
			this.cmdDefend.UseVisualStyleBackColor = false;
			this.cmdDefend.Click += new System.EventHandler(this.cmdDefend_Click);
			// 
			// cmdHeal
			// 
			this.cmdHeal.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.cmdHeal.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdHeal.Location = new System.Drawing.Point(708, 538);
			this.cmdHeal.Margin = new System.Windows.Forms.Padding(4);
			this.cmdHeal.Name = "cmdHeal";
			this.cmdHeal.Size = new System.Drawing.Size(128, 52);
			this.cmdHeal.TabIndex = 8;
			this.cmdHeal.Text = "Heal";
			this.cmdHeal.UseVisualStyleBackColor = false;
			this.cmdHeal.Click += new System.EventHandler(this.cmdHeal_Click);
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(329, 439);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.ReadOnly = true;
			this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtComment.Size = new System.Drawing.Size(383, 74);
			this.txtComment.TabIndex = 9;
			// 
			// frmAttacking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.StomachBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1032, 603);
			this.Controls.Add(this.txtComment);
			this.Controls.Add(this.cmdHeal);
			this.Controls.Add(this.cmdDefend);
			this.Controls.Add(this.lblEnemyHealth);
			this.Controls.Add(this.lblCharacterHealth);
			this.Controls.Add(this.cmdAttack);
			this.Controls.Add(this.lblEnemyName);
			this.Controls.Add(this.prgEnemy);
			this.Controls.Add(this.prgCharacter);
			this.Controls.Add(this.picEnemy);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmAttacking";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attacking";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAttacking_FormClosed);
			this.Load += new System.EventHandler(this.frmAttacking_Load);
			((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar prgCharacter;
		private System.Windows.Forms.ProgressBar prgEnemy;
		private System.Windows.Forms.Label lblEnemyName;
		private System.Windows.Forms.Button cmdAttack;
		private System.Windows.Forms.Label lblCharacterHealth;
		private System.Windows.Forms.Label lblEnemyHealth;
		private System.Windows.Forms.PictureBox picEnemy;
		private System.Windows.Forms.Button cmdDefend;
		private System.Windows.Forms.Button cmdHeal;
		private System.Windows.Forms.TextBox txtComment;
	}
}