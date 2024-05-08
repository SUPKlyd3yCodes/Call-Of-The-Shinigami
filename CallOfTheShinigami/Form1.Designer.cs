namespace CallOfTheShinigami
{
    partial class frmTitleScreen
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
			this.cmdNewGame = new System.Windows.Forms.Button();
			this.lblTitle1 = new System.Windows.Forms.Label();
			this.lblTitle2 = new System.Windows.Forms.Label();
			this.lblTitle3 = new System.Windows.Forms.Label();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.cmdCredits = new System.Windows.Forms.Button();
			this.cmdQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdNewGame
			// 
			this.cmdNewGame.BackColor = System.Drawing.Color.DimGray;
			this.cmdNewGame.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdNewGame.Location = new System.Drawing.Point(208, 482);
			this.cmdNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmdNewGame.Name = "cmdNewGame";
			this.cmdNewGame.Size = new System.Drawing.Size(161, 59);
			this.cmdNewGame.TabIndex = 0;
			this.cmdNewGame.Text = "New Game";
			this.cmdNewGame.UseVisualStyleBackColor = false;
			this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
			// 
			// lblTitle1
			// 
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle1.Font = new System.Drawing.Font("Niagara Solid", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle1.Location = new System.Drawing.Point(357, 64);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new System.Drawing.Size(162, 128);
			this.lblTitle1.TabIndex = 2;
			this.lblTitle1.Text = "Call";
			// 
			// lblTitle2
			// 
			this.lblTitle2.AutoSize = true;
			this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle2.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle2.Location = new System.Drawing.Point(495, 98);
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Size = new System.Drawing.Size(148, 85);
			this.lblTitle2.TabIndex = 3;
			this.lblTitle2.Text = "of the";
			// 
			// lblTitle3
			// 
			this.lblTitle3.AutoSize = true;
			this.lblTitle3.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle3.Font = new System.Drawing.Font("Niagara Solid", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle3.Location = new System.Drawing.Point(357, 174);
			this.lblTitle3.Name = "lblTitle3";
			this.lblTitle3.Size = new System.Drawing.Size(334, 128);
			this.lblTitle3.TabIndex = 1;
			this.lblTitle3.Text = "Shinigami";
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
			this.lblSubtitle.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.lblSubtitle.Location = new System.Drawing.Point(313, 300);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(367, 35);
			this.lblSubtitle.TabIndex = 4;
			this.lblSubtitle.Text = "Is it your soul you\'re really looking for?";
			// 
			// cmdCredits
			// 
			this.cmdCredits.BackColor = System.Drawing.Color.DimGray;
			this.cmdCredits.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdCredits.Location = new System.Drawing.Point(447, 482);
			this.cmdCredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmdCredits.Name = "cmdCredits";
			this.cmdCredits.Size = new System.Drawing.Size(161, 59);
			this.cmdCredits.TabIndex = 5;
			this.cmdCredits.Text = "Credits";
			this.cmdCredits.UseVisualStyleBackColor = false;
			this.cmdCredits.Click += new System.EventHandler(this.cmdCredits_Click);
			// 
			// cmdQuit
			// 
			this.cmdQuit.BackColor = System.Drawing.Color.DimGray;
			this.cmdQuit.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdQuit.Location = new System.Drawing.Point(683, 482);
			this.cmdQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmdQuit.Name = "cmdQuit";
			this.cmdQuit.Size = new System.Drawing.Size(161, 59);
			this.cmdQuit.TabIndex = 6;
			this.cmdQuit.Text = "Quit";
			this.cmdQuit.UseVisualStyleBackColor = false;
			this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
			// 
			// frmTitleScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CallOfTheShinigami.Properties.Resources.TitleBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1032, 603);
			this.Controls.Add(this.lblTitle2);
			this.Controls.Add(this.lblTitle1);
			this.Controls.Add(this.cmdQuit);
			this.Controls.Add(this.cmdCredits);
			this.Controls.Add(this.lblSubtitle);
			this.Controls.Add(this.lblTitle3);
			this.Controls.Add(this.cmdNewGame);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmTitleScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Call of the Shinigami";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button cmdCredits;
        private System.Windows.Forms.Button cmdQuit;
    }
}

