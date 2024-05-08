using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallOfTheShinigami.frmGameVN;

namespace CallOfTheShinigami
{
	public partial class frmGameRPG : Form
	{
		private Player player;
		public frmGameRPG(Player player)
		{
			InitializeComponent();
			UpdateLocationLabel();
			this.player = player;
		}

		bool firstEnemyBeaten;
		bool secondEnemyBeaten;
		bool thirdEnemyBeaten;
		bool fourthEnemyBeaten;
		bool fifthEnemyBeaten;
		bool sixthEnemyBeaten;
		bool seventhEnemyBeaten;
		bool eighthEnemyBeaten;
		bool ninthEnemyBeaten;
		bool tenthEnemyBeaten;
		bool eleventhEnemyBeaten;
		bool bossBeaten;
		bool simpleSwordAcquired;
		bool demonSlayerAcquired;
		bool isGreenLocked = true;
		bool isBlueLocked = true;
		public static bool isAttacking = false;
		public static string enemy = "";


		private void tmrPlayerAnimate_Tick(object sender, EventArgs e)
		{

		}

		private int maxHealth;
		private int health;
		private int attackPower;
		private int weaponAttackPower;

		private void frmGameRPG_Load(object sender, EventArgs e)
		{
			picCharacterRPG.Image = Properties.Resources.MCFemaleBack;
			if (frmGameSelection.characterInformation.GenderOption == "Male")
			{
				picCharacterImage.Image = Properties.Resources.MCMaleHappy;
			}
			else
			{
				picCharacterImage.Image = Properties.Resources.MCFemaleHappy;
			}
			lblName.Text = frmGameSelection.characterInformation.Username;
			maxHealth = player.MaxHealth;
			health = player.Health;
			attackPower = player.AttackPower;
			lblAttackValue.Text = attackPower.ToString();
			lblHealthValue.Text = player.Health.ToString() + "/" + player.MaxHealth.ToString();
		}

		private int x = 0, y = 0;
		private int speed = 25;
		private void UpdateLocationLabel()
		{
			lblLocation.Text = x.ToString() + "," + y.ToString();
		}
		private string[] availableCoordinates =
		{
			"0,0",

			//"1,0","2,0","3,0","4,0","5,0","6,0",
			//"0,1","0,2","0,3","0,4"
			//forward path
			"0,1","0,2","-1,2","0,3","1,3","1,4","1,5","1,6","2,6","0,6","-1,6","-1,5","-1,4","1,7","1,8",

			//right path
			"1,0","2,0","3,0","4,0","5,0","5,1","5,2","5,3","4,2","3,2","2,2","3,3","3,4","3,5","4,5","5,5","5,6","5,7","4,7","3,7","6,7","6,8","6,9","6,10",
			//left path
			"-1,0","-2,0","-3,0","-4,0","-5,0","-3,1","-3,2","-3,3","-2,3","-3,4","-4,4","-5,4","-6,4","-6,3","-6,2","-6,5","-6,6","-6,7","-6,8","-4,5","-4,6","-4,7","-3,7","-2,7","-3,8","-3,9","-3,10","-4,10","-5,10","-5,9","-6,10","-2,10","-1,10","0,10","1,10"
		};
		private List<string> lockedCoordinates = new List<string> { "5,1", "-3,1" };

		private bool found;
		
		private void cmdQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void DrawAvailableSpots(int deltaX, int deltaY)
		{
			string leftSpot = (x-1).ToString() + "," + y.ToString();
			string rightSpot = (x + 1).ToString() + "," + y.ToString();
			string forwardSpot = x.ToString() + "," + (y+1).ToString();
			string backwardSpot = x.ToString() + "," + (y-1).ToString();

			foreach (Control control in this.Controls.OfType<Panel>().ToList())
			{
				this.Controls.Remove(control);
				control.Dispose();
			}

			if (availableCoordinates.Contains(leftSpot) == true)
			{
				if (leftSpot == "3,7" && secondEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X - speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.LittleGluttonyEnemy;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (leftSpot == "-1,2" && fourthEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X - speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.LittleGluttonyEnemy;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (leftSpot == "-4,10" && tenthEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X - speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.BiggerGluttonyDemon;
					panel.BackgroundImageLayout = ImageLayout.Stretch;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else
				{

					int posX = picCharacterRPG.Location.X - speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height); 
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackColor = Color.FromArgb(50, Color.Green);

					this.Controls.Add(panel);
					panel.BringToFront();
				}
			}
			if (availableCoordinates.Contains(rightSpot) == true)
			{
				if (rightSpot == "2,6" && fifthEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X + speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.LittleGluttonyEnemy;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (rightSpot == "-2,7" && eleventhEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X + speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.BiggerGluttonyDemon;
					panel.BackgroundImageLayout = ImageLayout.Stretch;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (rightSpot == "1,10" && bossBeaten == false)
				{
					int posX = picCharacterRPG.Location.X + speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.Beelzebub;
					panel.BackgroundImageLayout = ImageLayout.Stretch;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else
				{
					int posX = picCharacterRPG.Location.X + speed;
					int posY = picCharacterRPG.Location.Y;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width,	picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackColor = Color.FromArgb(50, Color.Green);

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				
				
			}
			if (availableCoordinates.Contains(forwardSpot) == true)
			{
				if (forwardSpot == "1,8" && simpleSwordAcquired == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.SimpleSword;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (forwardSpot == "5,1" && isGreenLocked == true)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.GreenLock;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (forwardSpot == "-3,1" && isBlueLocked == true)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.BlueLock;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (forwardSpot == "6,9" && thirdEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.BiggerGluttonyDemon;
					panel.BackgroundImageLayout = ImageLayout.Stretch;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (forwardSpot == "-6,8" && ninthEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.BiggerGluttonyDemon;
					panel.BackgroundImageLayout = ImageLayout.Stretch;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (forwardSpot == "5,3" && sixthEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.LittleGluttonyEnemy;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (forwardSpot == "-3,3" && seventhEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.LittleGluttonyEnemy;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (forwardSpot == "6,10" && isBlueLocked == true)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.BlueKey;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y - speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height); 
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackColor = Color.FromArgb(50, Color.Green);

					this.Controls.Add(panel);
					panel.BringToFront();
				}
			}
			if (availableCoordinates.Contains(backwardSpot) == true)
			{
				if (backwardSpot == "-1,5" && firstEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y + speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.LittleGluttonyEnemy;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (backwardSpot == "-5,9" && demonSlayerAcquired == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y + speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.DemonSlayer;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else if (backwardSpot == "-6,2" && eighthEnemyBeaten == false)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y + speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.BiggerGluttonyDemon;
					panel.BackgroundImageLayout = ImageLayout.Stretch;

					this.Controls.Add(panel);
					panel.BringToFront();


				}
				else if (backwardSpot == "-1,4" && isGreenLocked == true)
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y + speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackgroundImage = Properties.Resources.GreenKey;
					panel.BackgroundImageLayout = ImageLayout.Zoom;

					this.Controls.Add(panel);
					panel.BringToFront();
				}
				else
				{
					int posX = picCharacterRPG.Location.X;
					int posY = picCharacterRPG.Location.Y + speed;

					Rectangle rect = new Rectangle(posX, posY, picCharacterRPG.Width, picCharacterRPG.Height);
					Panel panel = new Panel();
					panel.Location = new Point(rect.X, rect.Y);
					panel.Size = new Size(rect.Width, rect.Height);
					panel.BackColor = Color.FromArgb(50, Color.Green);

					this.Controls.Add(panel);
					panel.BringToFront();
				}
			}
		}

		private bool canMove(int deltaX, int deltaY)
		{
			int newX = x + deltaX;
			int newY = y + deltaY;
			string newCoord = newX.ToString() + "," + newY.ToString();
			if (availableCoordinates.Contains(newCoord) && !lockedCoordinates.Contains(newCoord))
			{
				x = newX;
				y = newY;
				return true;
			}
			return false;
		}

		private void MoveCharacter(int deltaX, int deltaY)
		{
			if (canMove(deltaX, deltaY))
			{
				picCharacterRPG.Location = new Point(picCharacterRPG.Location.X + deltaX * speed, picCharacterRPG.Location.Y - deltaY * speed);
				UpdateLocationLabel();
				DrawAvailableSpots(deltaX, deltaY);
			}
		}

		private void cmdNorth_Click(object sender, EventArgs e)
		{
			MoveCharacter(0, 1);
			picCharacterRPG.Image = Properties.Resources.MCFemaleFront;
		}

		private void cmdEast_Click(object sender, EventArgs e)
		{
			MoveCharacter(1, 0);
			picCharacterRPG.Image = Properties.Resources.MCFemaleRight;
		}

		private void cmdMainMenu_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmTitleScreen Game = new frmTitleScreen();
			Game.ShowDialog();
			this.Close();
		}

		private void cmdSouth_Click(object sender, EventArgs e)
		{
			MoveCharacter(0, -1);
			picCharacterRPG.Image = Properties.Resources.MCFemaleBack;
		}

		private void cmdWest_Click(object sender, EventArgs e)
		{
			MoveCharacter(-1, 0);
			picCharacterRPG.Image = Properties.Resources.MCFemaleLeft;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			player.AddExperience(50);
			lblExp.Text = player.Experience.ToString() + "/" + player.ExperienceToNextLevel.ToString();
		}

		private void frmGameRPG_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
			{
				MoveCharacter(0, 1);
				picCharacterRPG.Image = Properties.Resources.MCFemaleFront;
			}
			else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
			{
				MoveCharacter(1, 0);
				picCharacterRPG.Image = Properties.Resources.MCFemaleRight;
			}
			else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
			{
				MoveCharacter(0, -1);
				picCharacterRPG.Image = Properties.Resources.MCFemaleBack;
			}
			else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
			{
				MoveCharacter(-1, 0);
				picCharacterRPG.Image = Properties.Resources.MCFemaleLeft;
			}
		}

		private frmAttacking attackPage;

		private void button3_Click(object sender, EventArgs e)
		{

			frmCredits Credits = new frmCredits();
			Credits.ShowDialog();
		}

		private void cmdCredits_Click(object sender, EventArgs e)
		{

			frmCredits Credits = new frmCredits();
			Credits.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmVisualNovel2 vn = new frmVisualNovel2();
			vn.ShowDialog();
			this.Close();                                                                
		}


		//MainControl
		private void tmrMessageTick_Tick(object sender, EventArgs e)
		{
			lblExp.Text = player.Experience.ToString() + "/" + player.ExperienceToNextLevel.ToString();
			prgExp.Maximum = player.ExperienceToNextLevel;
			prgExp.Value = player.Experience;
			lblLevel.Text = "Lvl: " + player.Level.ToString();
			lblAttackValue.Text = player.AttackPower.ToString()+"(+"+player.WeaponAttackPower+")";
			lblHealthValue.Text = player.Health.ToString() + "/" + player.MaxHealth.ToString();

			if (lblLocation.Text == "0,0")
			{
				txtMessage.Text = "What is this?";
			}
			else if (lblLocation.Text == "-1,6" && firstEnemyBeaten == false)
			{
				txtMessage.Text = "Who are you?"; 
			}
			else if (lblLocation.Text == "1,6" && secondEnemyBeaten == false)
			{
				txtMessage.Text = "";
			}
			else if(lblLocation .Text == "6,8" && thirdEnemyBeaten == false)
			{
				txtMessage.Text = "";

			}
			else if (lblLocation.Text == "0,2" && fourthEnemyBeaten == false)
			{
				txtMessage.Text = "A small one again";
			}
			else if (lblLocation.Text == "2,6" && fifthEnemyBeaten == false)
			{
				txtMessage.Text = "I am getting more experience!";
			}
			else if(lblLocation.Text == "5,2" && sixthEnemyBeaten == false)
			{
				txtMessage.Text = "Theres still more?";
			}
			else if( lblLocation.Text == "-3,2" && seventhEnemyBeaten == false)
			{
				txtMessage.Text = "I really wonder when this will end.";
			}
			else if(lblLocation.Text == "-6,3" && eighthEnemyBeaten == false)
			{
				txtMessage.Text = "AH ANOTHER BIG ONE!!";
			}
			else if (lblLocation.Text == "-6,7" && ninthEnemyBeaten==false)
			{
				txtMessage.Text = "The big ones are finally coming in.";
			}
			else if (lblLocation.Text == "-3,10" && tenthEnemyBeaten == false)
			{
				txtMessage.Text = "Am I getting closer?";
			}
			else if (lblLocation.Text == "-3,7" && eleventhEnemyBeaten == false)
			{
				txtMessage  .Text = "Just a little more push.";
			}  
			



			if (lblLocation.Text == "-1,5" && isAttacking == false && firstEnemyBeaten == false)
			{
				isAttacking = true;
				firstEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "3,7" && isAttacking == false && secondEnemyBeaten == false)
			{
				isAttacking = true;
				secondEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "6,9" && isAttacking == false && thirdEnemyBeaten == false)
			{
				isAttacking = true;
				thirdEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Bigger Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "-1,2" && isAttacking == false && fourthEnemyBeaten == false)
			{
				isAttacking = true;
				fourthEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "2,6" && isAttacking == false && fifthEnemyBeaten == false)
			{
				isAttacking = true;
				fifthEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "5,3" && isAttacking == false && sixthEnemyBeaten == false)
			{
				isAttacking = true;
				sixthEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "-3,3" && isAttacking == false && seventhEnemyBeaten == false)
			{
				isAttacking = true;
				seventhEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "-6,2" && isAttacking == false && eighthEnemyBeaten == false)
			{
				isAttacking = true;
				eighthEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Bigger Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "-6,8" && isAttacking == false && ninthEnemyBeaten == false)
			{
				isAttacking = true;
				ninthEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Bigger Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "-4,10" && isAttacking == false && tenthEnemyBeaten == false)
			{
				isAttacking = true;
				tenthEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Bigger Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "-2,7" && isAttacking == false && eleventhEnemyBeaten == false)
			{
				isAttacking = true;
				eleventhEnemyBeaten = true;
				this.Hide();

				using (attackPage = new frmAttacking(player, "Bigger Gluttony Minion", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "1,10" && isAttacking == false && bossBeaten == false)
			{
				isAttacking = true;
				bossBeaten = true;
				this.Close();

				using (attackPage = new frmAttacking(player, "Beelzebub", this))
				{

					attackPage.ShowDialog();
				}
			}

			if (lblLocation.Text == "-1,4" && isGreenLocked == true)
			{
				isGreenLocked = false;
				lockedCoordinates.Remove("5,1");
			}

			if (lblLocation.Text == "6,10" && isBlueLocked == true)
			{
				isBlueLocked = false;
				lockedCoordinates.Remove("-3,1");
			}

			if (lblLocation.Text == "1,8" && simpleSwordAcquired == false)
			{
				simpleSwordAcquired = true;
				cboWeapon.Items.Add("Simple Sword");
			}

			if (lblLocation.Text == "-5,9" && demonSlayerAcquired == false)
			{
				demonSlayerAcquired = true;
				cboWeapon.Items.Add("Demon Slayer");
			}

			if (cboWeapon.SelectedItem == null || cboWeapon.SelectedItem.ToString() == "None" )
			{
				player.WeaponAttackPower = 0;
			} else if (cboWeapon.SelectedItem.ToString() == "Simple Sword")
			{
				player.WeaponAttackPower = 2;
			} else if (cboWeapon.SelectedItem.ToString() == "Demon Slayer")
			{
				player.WeaponAttackPower = 8;
			}
		}
	}
}
