namespace CallOfTheShinigami
{
    partial class frmGameSelection
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
			this.cmdCreate = new System.Windows.Forms.Button();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.picAvatar = new System.Windows.Forms.PictureBox();
			this.lblReminderName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdCreate
			// 
			this.cmdCreate.Location = new System.Drawing.Point(469, 503);
			this.cmdCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmdCreate.Name = "cmdCreate";
			this.cmdCreate.Size = new System.Drawing.Size(141, 39);
			this.cmdCreate.TabIndex = 0;
			this.cmdCreate.Text = "Create Character";
			this.cmdCreate.UseVisualStyleBackColor = true;
			this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.BackColor = System.Drawing.Color.Transparent;
			this.lblGender.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold);
			this.lblGender.Location = new System.Drawing.Point(121, 310);
			this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(123, 34);
			this.lblGender.TabIndex = 1;
			this.lblGender.Text = "Gender";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(121, 197);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(87, 34);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold);
			this.txtName.Location = new System.Drawing.Point(332, 193);
			this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(160, 46);
			this.txtName.TabIndex = 3;
			// 
			// cboGender
			// 
			this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGender.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cboGender.Location = new System.Drawing.Point(332, 308);
			this.cboGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(160, 41);
			this.cboGender.TabIndex = 4;
			this.cboGender.SelectedValueChanged += new System.EventHandler(this.cboGender_SelectedValueChanged);
			// 
			// picAvatar
			// 
			this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picAvatar.Location = new System.Drawing.Point(624, 96);
			this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picAvatar.Name = "picAvatar";
			this.picAvatar.Size = new System.Drawing.Size(248, 308);
			this.picAvatar.TabIndex = 5;
			this.picAvatar.TabStop = false;
			// 
			// lblReminderName
			// 
			this.lblReminderName.BackColor = System.Drawing.Color.Transparent;
			this.lblReminderName.Font = new System.Drawing.Font("NSimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReminderName.Location = new System.Drawing.Point(326, 243);
			this.lblReminderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblReminderName.Name = "lblReminderName";
			this.lblReminderName.Size = new System.Drawing.Size(189, 18);
			this.lblReminderName.TabIndex = 6;
			this.lblReminderName.Text = "(Default: John)";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("NSimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(326, 353);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 28);
			this.label1.TabIndex = 7;
			this.label1.Text = "(Default: Male)";
			// 
			// frmGameSelection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.CharacterSelectionBg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1032, 603);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblReminderName);
			this.Controls.Add(this.picAvatar);
			this.Controls.Add(this.cboGender);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.cmdCreate);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmGameSelection";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game Selection";
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCreate;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox cboGender;
		private System.Windows.Forms.PictureBox picAvatar;
		private System.Windows.Forms.Label lblReminderName;
		private System.Windows.Forms.Label label1;
	}
}