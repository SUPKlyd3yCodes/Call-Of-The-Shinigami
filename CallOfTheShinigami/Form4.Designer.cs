namespace CallOfTheShinigami
{
	partial class frmGameRPG
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameRPG));
			this.cmdQuit = new System.Windows.Forms.Button();
			this.cmdCredits = new System.Windows.Forms.Button();
			this.cmdMainMenu = new System.Windows.Forms.Button();
			this.cboArmor = new System.Windows.Forms.ComboBox();
			this.cboWeapon = new System.Windows.Forms.ComboBox();
			this.lblStaminaValue = new System.Windows.Forms.Label();
			this.lblHealthValue = new System.Windows.Forms.Label();
			this.lblAttackValue = new System.Windows.Forms.Label();
			this.lblArmor = new System.Windows.Forms.Label();
			this.lblWeapon = new System.Windows.Forms.Label();
			this.lblStamina = new System.Windows.Forms.Label();
			this.lblAttack = new System.Windows.Forms.Label();
			this.lblHealth = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblTitle3 = new System.Windows.Forms.Label();
			this.lblTitle2 = new System.Windows.Forms.Label();
			this.lblTitle1 = new System.Windows.Forms.Label();
			this.cmdWest = new System.Windows.Forms.Button();
			this.cmdSouth = new System.Windows.Forms.Button();
			this.cmdEast = new System.Windows.Forms.Button();
			this.cmdNorth = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.lblLocation = new System.Windows.Forms.Label();
			this.tmrMessageTick = new System.Windows.Forms.Timer(this.components);
			this.lblLevel = new System.Windows.Forms.Label();
			this.prgExp = new System.Windows.Forms.ProgressBar();
			this.lblExp = new System.Windows.Forms.Label();
			this.tmrPlayerAnimate = new System.Windows.Forms.Timer(this.components);
			this.picCharacterRPG = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.picCharacterImage = new System.Windows.Forms.PictureBox();
			this.picBackgroundRightMenu = new System.Windows.Forms.PictureBox();
			this.picBackgroundLeftMenu = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picCharacterRPG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCharacterImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackgroundRightMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackgroundLeftMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdQuit
			// 
			this.cmdQuit.ForeColor = System.Drawing.Color.Maroon;
			this.cmdQuit.Location = new System.Drawing.Point(823, 528);
			this.cmdQuit.Margin = new System.Windows.Forms.Padding(4);
			this.cmdQuit.Name = "cmdQuit";
			this.cmdQuit.Size = new System.Drawing.Size(169, 28);
			this.cmdQuit.TabIndex = 45;
			this.cmdQuit.Text = "Quit to Desktop";
			this.cmdQuit.UseVisualStyleBackColor = true;
			this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
			// 
			// cmdCredits
			// 
			this.cmdCredits.Location = new System.Drawing.Point(811, 98);
			this.cmdCredits.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCredits.Name = "cmdCredits";
			this.cmdCredits.Size = new System.Drawing.Size(169, 28);
			this.cmdCredits.TabIndex = 44;
			this.cmdCredits.Text = "Credits";
			this.cmdCredits.UseVisualStyleBackColor = true;
			this.cmdCredits.Click += new System.EventHandler(this.cmdCredits_Click);
			// 
			// cmdMainMenu
			// 
			this.cmdMainMenu.Location = new System.Drawing.Point(811, 43);
			this.cmdMainMenu.Margin = new System.Windows.Forms.Padding(4);
			this.cmdMainMenu.Name = "cmdMainMenu";
			this.cmdMainMenu.Size = new System.Drawing.Size(169, 28);
			this.cmdMainMenu.TabIndex = 43;
			this.cmdMainMenu.Text = "Main Menu";
			this.cmdMainMenu.UseVisualStyleBackColor = true;
			this.cmdMainMenu.Click += new System.EventHandler(this.cmdMainMenu_Click);
			// 
			// cboArmor
			// 
			this.cboArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboArmor.FormattingEnabled = true;
			this.cboArmor.Location = new System.Drawing.Point(165, 512);
			this.cboArmor.Margin = new System.Windows.Forms.Padding(4);
			this.cboArmor.Name = "cboArmor";
			this.cboArmor.Size = new System.Drawing.Size(92, 24);
			this.cboArmor.TabIndex = 41;
			// 
			// cboWeapon
			// 
			this.cboWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboWeapon.FormattingEnabled = true;
			this.cboWeapon.Items.AddRange(new object[] {
            "None"});
			this.cboWeapon.Location = new System.Drawing.Point(165, 481);
			this.cboWeapon.Margin = new System.Windows.Forms.Padding(4);
			this.cboWeapon.Name = "cboWeapon";
			this.cboWeapon.Size = new System.Drawing.Size(92, 24);
			this.cboWeapon.TabIndex = 40;
			// 
			// lblStaminaValue
			// 
			this.lblStaminaValue.AutoSize = true;
			this.lblStaminaValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblStaminaValue.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStaminaValue.Location = new System.Drawing.Point(161, 450);
			this.lblStaminaValue.Name = "lblStaminaValue";
			this.lblStaminaValue.Size = new System.Drawing.Size(46, 23);
			this.lblStaminaValue.TabIndex = 39;
			this.lblStaminaValue.Text = "1000";
			// 
			// lblHealthValue
			// 
			this.lblHealthValue.AutoSize = true;
			this.lblHealthValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblHealthValue.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHealthValue.Location = new System.Drawing.Point(161, 389);
			this.lblHealthValue.Name = "lblHealthValue";
			this.lblHealthValue.Size = new System.Drawing.Size(46, 23);
			this.lblHealthValue.TabIndex = 38;
			this.lblHealthValue.Text = "1000";
			// 
			// lblAttackValue
			// 
			this.lblAttackValue.AutoSize = true;
			this.lblAttackValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblAttackValue.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAttackValue.Location = new System.Drawing.Point(161, 420);
			this.lblAttackValue.Name = "lblAttackValue";
			this.lblAttackValue.Size = new System.Drawing.Size(46, 23);
			this.lblAttackValue.TabIndex = 37;
			this.lblAttackValue.Text = "1000";
			// 
			// lblArmor
			// 
			this.lblArmor.AutoSize = true;
			this.lblArmor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblArmor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArmor.Location = new System.Drawing.Point(17, 512);
			this.lblArmor.Name = "lblArmor";
			this.lblArmor.Size = new System.Drawing.Size(61, 23);
			this.lblArmor.TabIndex = 36;
			this.lblArmor.Text = "Armor";
			// 
			// lblWeapon
			// 
			this.lblWeapon.AutoSize = true;
			this.lblWeapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblWeapon.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWeapon.Location = new System.Drawing.Point(15, 481);
			this.lblWeapon.Name = "lblWeapon";
			this.lblWeapon.Size = new System.Drawing.Size(72, 23);
			this.lblWeapon.TabIndex = 35;
			this.lblWeapon.Text = "Weapon";
			// 
			// lblStamina
			// 
			this.lblStamina.AutoSize = true;
			this.lblStamina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblStamina.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStamina.Location = new System.Drawing.Point(17, 450);
			this.lblStamina.Name = "lblStamina";
			this.lblStamina.Size = new System.Drawing.Size(74, 23);
			this.lblStamina.TabIndex = 34;
			this.lblStamina.Text = "Stamina";
			// 
			// lblAttack
			// 
			this.lblAttack.AutoSize = true;
			this.lblAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblAttack.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAttack.Location = new System.Drawing.Point(17, 420);
			this.lblAttack.Name = "lblAttack";
			this.lblAttack.Size = new System.Drawing.Size(111, 23);
			this.lblAttack.TabIndex = 33;
			this.lblAttack.Text = "Attack Power";
			// 
			// lblHealth
			// 
			this.lblHealth.AutoSize = true;
			this.lblHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblHealth.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHealth.Location = new System.Drawing.Point(17, 389);
			this.lblHealth.Name = "lblHealth";
			this.lblHealth.Size = new System.Drawing.Size(62, 23);
			this.lblHealth.TabIndex = 32;
			this.lblHealth.Text = "Health";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblName.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(15, 293);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(123, 35);
			this.lblName.TabIndex = 31;
			this.lblName.Text = "Player Name";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
			this.lblVersion.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.Location = new System.Drawing.Point(851, 471);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(83, 16);
			this.lblVersion.TabIndex = 30;
			this.lblVersion.Text = "Version 0.6";
			// 
			// lblTitle3
			// 
			this.lblTitle3.AutoSize = true;
			this.lblTitle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
			this.lblTitle3.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle3.Location = new System.Drawing.Point(811, 407);
			this.lblTitle3.Name = "lblTitle3";
			this.lblTitle3.Size = new System.Drawing.Size(169, 64);
			this.lblTitle3.TabIndex = 29;
			this.lblTitle3.Text = "Shinigami";
			// 
			// lblTitle2
			// 
			this.lblTitle2.AutoSize = true;
			this.lblTitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
			this.lblTitle2.Font = new System.Drawing.Font("Niagara Solid", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle2.Location = new System.Drawing.Point(877, 373);
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Size = new System.Drawing.Size(62, 33);
			this.lblTitle2.TabIndex = 28;
			this.lblTitle2.Text = "of the";
			// 
			// lblTitle1
			// 
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
			this.lblTitle1.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle1.Location = new System.Drawing.Point(811, 348);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new System.Drawing.Size(83, 64);
			this.lblTitle1.TabIndex = 27;
			this.lblTitle1.Text = "Call";
			// 
			// cmdWest
			// 
			this.cmdWest.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
			this.cmdWest.Location = new System.Drawing.Point(271, 523);
			this.cmdWest.Margin = new System.Windows.Forms.Padding(4);
			this.cmdWest.Name = "cmdWest";
			this.cmdWest.Size = new System.Drawing.Size(147, 37);
			this.cmdWest.TabIndex = 46;
			this.cmdWest.Text = "Go West";
			this.cmdWest.UseVisualStyleBackColor = true;
			this.cmdWest.Click += new System.EventHandler(this.cmdWest_Click);
			// 
			// cmdSouth
			// 
			this.cmdSouth.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
			this.cmdSouth.Location = new System.Drawing.Point(433, 523);
			this.cmdSouth.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSouth.Name = "cmdSouth";
			this.cmdSouth.Size = new System.Drawing.Size(147, 37);
			this.cmdSouth.TabIndex = 47;
			this.cmdSouth.Text = "Go South";
			this.cmdSouth.UseVisualStyleBackColor = true;
			this.cmdSouth.Click += new System.EventHandler(this.cmdSouth_Click);
			// 
			// cmdEast
			// 
			this.cmdEast.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
			this.cmdEast.Location = new System.Drawing.Point(595, 523);
			this.cmdEast.Margin = new System.Windows.Forms.Padding(4);
			this.cmdEast.Name = "cmdEast";
			this.cmdEast.Size = new System.Drawing.Size(147, 37);
			this.cmdEast.TabIndex = 48;
			this.cmdEast.Text = "Go East";
			this.cmdEast.UseVisualStyleBackColor = true;
			this.cmdEast.Click += new System.EventHandler(this.cmdEast_Click);
			// 
			// cmdNorth
			// 
			this.cmdNorth.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
			this.cmdNorth.Location = new System.Drawing.Point(433, 471);
			this.cmdNorth.Margin = new System.Windows.Forms.Padding(4);
			this.cmdNorth.Name = "cmdNorth";
			this.cmdNorth.Size = new System.Drawing.Size(147, 37);
			this.cmdNorth.TabIndex = 49;
			this.cmdNorth.Text = "Go North";
			this.cmdNorth.UseVisualStyleBackColor = true;
			this.cmdNorth.Click += new System.EventHandler(this.cmdNorth_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
			this.txtMessage.Location = new System.Drawing.Point(271, 369);
			this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ReadOnly = true;
			this.txtMessage.Size = new System.Drawing.Size(469, 94);
			this.txtMessage.TabIndex = 50;
			this.txtMessage.Text = resources.GetString("txtMessage.Text");
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblLocation.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocation.Location = new System.Drawing.Point(269, 570);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(49, 23);
			this.lblLocation.TabIndex = 51;
			this.lblLocation.Text = "Place";
			// 
			// tmrMessageTick
			// 
			this.tmrMessageTick.Enabled = true;
			this.tmrMessageTick.Interval = 50;
			this.tmrMessageTick.Tick += new System.EventHandler(this.tmrMessageTick_Tick);
			// 
			// lblLevel
			// 
			this.lblLevel.AutoSize = true;
			this.lblLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblLevel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLevel.Location = new System.Drawing.Point(15, 330);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(50, 23);
			this.lblLevel.TabIndex = 54;
			this.lblLevel.Text = "Lvl: 1";
			// 
			// prgExp
			// 
			this.prgExp.Location = new System.Drawing.Point(89, 332);
			this.prgExp.Margin = new System.Windows.Forms.Padding(4);
			this.prgExp.Name = "prgExp";
			this.prgExp.Size = new System.Drawing.Size(169, 20);
			this.prgExp.TabIndex = 55;
			// 
			// lblExp
			// 
			this.lblExp.AutoSize = true;
			this.lblExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.lblExp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExp.Location = new System.Drawing.Point(155, 356);
			this.lblExp.Name = "lblExp";
			this.lblExp.Size = new System.Drawing.Size(42, 23);
			this.lblExp.TabIndex = 56;
			this.lblExp.Text = "/100";
			// 
			// tmrPlayerAnimate
			// 
			this.tmrPlayerAnimate.Enabled = true;
			this.tmrPlayerAnimate.Tick += new System.EventHandler(this.tmrPlayerAnimate_Tick);
			// 
			// picCharacterRPG
			// 
			this.picCharacterRPG.BackColor = System.Drawing.Color.Transparent;
			this.picCharacterRPG.Location = new System.Drawing.Point(485, 332);
			this.picCharacterRPG.Margin = new System.Windows.Forms.Padding(4);
			this.picCharacterRPG.Name = "picCharacterRPG";
			this.picCharacterRPG.Size = new System.Drawing.Size(32, 30);
			this.picCharacterRPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCharacterRPG.TabIndex = 53;
			this.picCharacterRPG.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
			this.pictureBox2.Location = new System.Drawing.Point(271, 15);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(469, 348);
			this.pictureBox2.TabIndex = 52;
			this.pictureBox2.TabStop = false;
			// 
			// picCharacterImage
			// 
			this.picCharacterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picCharacterImage.Image = global::CallOfTheShinigami.Properties.Resources.CharacterSample;
			this.picCharacterImage.Location = new System.Drawing.Point(19, 25);
			this.picCharacterImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picCharacterImage.Name = "picCharacterImage";
			this.picCharacterImage.Size = new System.Drawing.Size(225, 267);
			this.picCharacterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCharacterImage.TabIndex = 26;
			this.picCharacterImage.TabStop = false;
			// 
			// picBackgroundRightMenu
			// 
			this.picBackgroundRightMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
			this.picBackgroundRightMenu.Location = new System.Drawing.Point(747, -4);
			this.picBackgroundRightMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picBackgroundRightMenu.Name = "picBackgroundRightMenu";
			this.picBackgroundRightMenu.Size = new System.Drawing.Size(288, 610);
			this.picBackgroundRightMenu.TabIndex = 25;
			this.picBackgroundRightMenu.TabStop = false;
			// 
			// picBackgroundLeftMenu
			// 
			this.picBackgroundLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.picBackgroundLeftMenu.Location = new System.Drawing.Point(-1, -4);
			this.picBackgroundLeftMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picBackgroundLeftMenu.Name = "picBackgroundLeftMenu";
			this.picBackgroundLeftMenu.Size = new System.Drawing.Size(265, 610);
			this.picBackgroundLeftMenu.TabIndex = 24;
			this.picBackgroundLeftMenu.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(835, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 57;
			this.button1.Text = "Temporary";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmGameRPG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(1032, 603);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblExp);
			this.Controls.Add(this.prgExp);
			this.Controls.Add(this.lblLevel);
			this.Controls.Add(this.picCharacterRPG);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblLocation);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.cmdNorth);
			this.Controls.Add(this.cmdEast);
			this.Controls.Add(this.cmdSouth);
			this.Controls.Add(this.cmdWest);
			this.Controls.Add(this.cmdQuit);
			this.Controls.Add(this.cmdCredits);
			this.Controls.Add(this.cmdMainMenu);
			this.Controls.Add(this.cboArmor);
			this.Controls.Add(this.cboWeapon);
			this.Controls.Add(this.lblStaminaValue);
			this.Controls.Add(this.lblHealthValue);
			this.Controls.Add(this.lblAttackValue);
			this.Controls.Add(this.lblArmor);
			this.Controls.Add(this.lblWeapon);
			this.Controls.Add(this.lblStamina);
			this.Controls.Add(this.lblAttack);
			this.Controls.Add(this.lblHealth);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblTitle3);
			this.Controls.Add(this.lblTitle2);
			this.Controls.Add(this.lblTitle1);
			this.Controls.Add(this.picCharacterImage);
			this.Controls.Add(this.picBackgroundRightMenu);
			this.Controls.Add(this.picBackgroundLeftMenu);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmGameRPG";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Call of the Shinigami";
			this.Load += new System.EventHandler(this.frmGameRPG_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameRPG_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.picCharacterRPG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCharacterImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackgroundRightMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackgroundLeftMenu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdQuit;
		private System.Windows.Forms.Button cmdCredits;
		private System.Windows.Forms.Button cmdMainMenu;
		private System.Windows.Forms.ComboBox cboArmor;
		private System.Windows.Forms.ComboBox cboWeapon;
		private System.Windows.Forms.Label lblStaminaValue;
		private System.Windows.Forms.Label lblHealthValue;
		private System.Windows.Forms.Label lblAttackValue;
		private System.Windows.Forms.Label lblArmor;
		private System.Windows.Forms.Label lblWeapon;
		private System.Windows.Forms.Label lblStamina;
		private System.Windows.Forms.Label lblAttack;
		private System.Windows.Forms.Label lblHealth;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblTitle3;
		private System.Windows.Forms.Label lblTitle2;
		private System.Windows.Forms.Label lblTitle1;
		private System.Windows.Forms.PictureBox picCharacterImage;
		private System.Windows.Forms.PictureBox picBackgroundRightMenu;
		private System.Windows.Forms.PictureBox picBackgroundLeftMenu;
		private System.Windows.Forms.Button cmdWest;
		private System.Windows.Forms.Button cmdSouth;
		private System.Windows.Forms.Button cmdEast;
		private System.Windows.Forms.Button cmdNorth;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox picCharacterRPG;
		private System.Windows.Forms.Timer tmrMessageTick;
		private System.Windows.Forms.Label lblLevel;
		private System.Windows.Forms.ProgressBar prgExp;
		private System.Windows.Forms.Label lblExp;
		private System.Windows.Forms.Timer tmrPlayerAnimate;
		private System.Windows.Forms.Button button1;
	}
}