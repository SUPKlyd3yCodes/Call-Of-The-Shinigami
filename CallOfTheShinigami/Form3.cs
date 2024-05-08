using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static CallOfTheShinigami.frmGameVN;

namespace CallOfTheShinigami
{
	public partial class frmGameVN : Form
	{
		//initializing variables
		int dialogueCount = 0;
		private int currentIndex = 0;
		private string userName = frmGameSelection.characterInformation.Username;
		private string Gender = frmGameSelection.characterInformation.GenderOption;

		//creates a public class called player with all its stats
		public class Player
		{
			public int MaxHealth { get; set; }
			public int Health { get; set; }
			public int AttackPower { get; set; }
			public int Level { get; set; }
			public int Experience { get; set; }
			public int ExperienceToNextLevel {  get; set; }
			public int WeaponAttackPower { get; set; }

			//default values
			public Player()
			{
				Level = 1;
				Experience = 0;
				ExperienceToNextLevel = 100; // Set the initial experience required to level up
				MaxHealth = 100;
				Health = 100;
				AttackPower = 1;
				WeaponAttackPower = 0;
			}
			
			//method to change health
			public void ChangeHealth(int amount)
			{
				Health = amount;
			}

			//method to add exp
			public void AddExperience(int amount)
			{
				Experience += amount;
				if (Experience >= ExperienceToNextLevel)
				{
					LevelUp();
				}
			}

			//method to level up
			private void LevelUp()
			{
				Level++;
				Experience -= ExperienceToNextLevel;
				ExperienceToNextLevel = CalculateExperienceForNextLevel();
				MaxHealth *= 2;
				Health = MaxHealth;
				AttackPower *= 2;
			}

			//method to calculate the experience needed for the next level
			private int CalculateExperienceForNextLevel()
			{
				return Level * 100;
			}
		}


		public frmGameVN()
		{
			InitializeComponent();
		}

		//sets the values for the name and character image
		private void frmGameVN_Load(object sender, EventArgs e)
		{
			
			if (Gender == "Female")
			{
				picMC.Image = Properties.Resources.MCFemaleScared;
			} else
			{
				picMC.Image = Properties.Resources.MCMaleScared
					;
			}
			userName = frmGameSelection.characterInformation.Username;
			this.BackgroundImage = Properties.Resources.NightmareBackground;
			lblName.Text = "Dream";
			lblDialogue.Text = "Choose. Choose. Choose. Pick me. It will give you what you need if you choose me.";
			dialogueCount++;
		}

		//quits the application
		private void cmdQuit_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		//paints the dialogue box a gradient color of 2 shades of gray
		private void picDialogueBox_Paint(object sender, PaintEventArgs e)
		{
			Color top = Color.FromArgb(200, 30, 30, 30);
			Color bottom = Color.FromArgb(200, 120, 120, 120);
			LinearGradientMode direction = LinearGradientMode.ForwardDiagonal;
			LinearGradientBrush brush = new LinearGradientBrush(picDialogueBox.ClientRectangle, top, bottom, direction);

			e.Graphics.FillRectangle(brush, picDialogueBox.ClientRectangle);
		}


		//array variables
		private Point[] locations = new Point[]
		{
			new Point(35, 23),
			new Point(526, 283),
			new Point(394, -9),
			new Point(154, 164),
			new Point(512, -54),
			new Point(130, 38),
			new Point(-1, -110),
			new Point(264, -90),
			new Point(-1, -32)
		};

		private Size[] sizes = new Size[]
		{
			new Size(189, 260),
			new Size(189, 260),
			new Size(189, 260),
			new Size(189, 260),
			new Size(238, 324),
			new Size(335, 440),
			new Size(419, 568),
			new Size(575, 744),
			new Size(777, 940)
		};

		//for each time the timer ticks. It is used for the jumpscare
		private void timer1_Tick_1(object sender, EventArgs e)
		{

			if (currentIndex < locations.Length && currentIndex < sizes.Length)
			{
				picScare.Location = locations[currentIndex];
				picScare.Size = sizes[currentIndex];
				currentIndex++;
			} else
			{
				timer1.Stop();
				Thread.Sleep(500);
				picScare.Visible = false;
			}
		}

		//a method with the whole storyline of the game containing text and images
		private void storyline()
		{
			switch (dialogueCount)
			{
				case 0:

					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					this.BackgroundImage = Properties.Resources.NightmareBackground;
					lblName.Text = "Dream";
					lblDialogue.Text = "Choose. Choose. Choose. Choose. Pick me. It will give you what you need if you choose me.";
					dialogueCount++;
					break;
				case 1:
					lblName.Text = "Dream";
					lblDialogue.Text = "ACTIVATE ME NO-";
					dialogueCount++;

					break;
				case 2:

					this.BackgroundImage = null;
					lblName.Text = "Mother";
					lblDialogue.Text = userName + ", " + userName + ", it’s time to wake up!";
					dialogueCount++;
					break;
				case 3:
					this.BackgroundImage = Properties.Resources.Home;
					picMotherHappy.Visible = true;
					lblName.Text = userName;
					lblDialogue.Text = "I CAN’T CHOOSE!";
					dialogueCount++;
					break;
				case 4:
					picMotherHappy.Visible = false;
					picMotherScared.Visible = true;
					lblName.Text = "Mother";
					lblDialogue.Text = "Oh, honey, did you have a nightmare?";
					dialogueCount++;
					break;
				case 5:
					lblName.Text = userName;
					lblDialogue.Text = "*breathing heavily* Yeah, I don’t know what I saw — I don’t know. What was that… What choose. Why does that girl look - familiar…";
					dialogueCount++;
					break;
				case 6:
					lblName.Text = "Mother";
					lblDialogue.Text = "You’ve been having those nightmares for quite a while now, do I need to take you to the doctor?";
					dialogueCount++;
					break;
				case 7:

					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = userName;
					lblDialogue.Text = "It’s fine… I’m fine… I just – I don’t even remember what happened. If only I could say that I actually want to get this out of my head for once.";
					dialogueCount++;
					break;
				case 8:
					picMotherScared.Visible = false;
					picMotherHappy.Visible = true;
					lblName.Text = "Mother";
					lblDialogue.Text = "You look as white as a ghost. Go and drink some water and wash your face, it’ll help you feel better.";
					dialogueCount++;
					break;
				case 9:
					lblName.Text = userName;
					lblDialogue.Text = "Ok, mom.";
					dialogueCount++;
					break;
				case 10:
					this.BackgroundImage = Properties.Resources.ShowerBG;
					picMotherHappy.Visible = false;
					lblName.Text = "";
					lblDialogue.Text = userName + " gets up to wash his face and takes a shower";
					dialogueCount++;
					break;
				case 11:
					lblName.Text = "";
					lblDialogue.Text = "Thud, thud, thud";
					dialogueCount++;
					break;
				case 12:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Who’s there?";
					dialogueCount++;
					break;
				case 13:
					lblName.Text = userName;
					lblDialogue.Text = "It’s just my mind playing tricks on me again…";
					dialogueCount++;
					break;
				case 14:
					lblName.Text = "";
					lblDialogue.Text = userName + " finishes showering";
					dialogueCount++;
					break;
				case 15:
					lblName.Text = "Mother";
					lblDialogue.Text = "Hey " + userName + ". Breakfast is ready.";
					dialogueCount++;
					break;
				case 16:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = userName;
					lblDialogue.Text = "I’m coming, Mom!";
					dialogueCount++;
					break;
				case 17:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleVeryHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					this.BackgroundImage = Properties.Resources.DiningRoomBG;
					picFood.Visible = true;
					picMotherVeryHappy.Visible = true;
					lblName.Text = "";
					lblDialogue.Text = "A special omelet with bread on the side sits comfortably on the table, one of your favorite homemade dishes";
					dialogueCount++;
					break;
				case 18:
					lblName.Text = userName;
					lblDialogue.Text = "Woah, it’s my favorite again! Thanks, Mom!";
					dialogueCount++;
					break;
				case 19:
					lblName.Text = "Mother";
					lblDialogue.Text = "No problem.";
					dialogueCount++;
					break;
				case 20:
					picFood.Visible = false;
					lblName.Text = userName;
					lblDialogue.Text = userName + " eats the dish";
					dialogueCount++;
					break;
				case 21:
					picMotherHappy.Visible = true;
					picMotherVeryHappy.Visible = false;
					lblName.Text = "Mother";
					lblDialogue.Text = "By the way, don’t forget to take out the trash when you leave the house.";
					dialogueCount++;
					break;
				case 22:
					lblName.Text = userName;
					lblDialogue.Text = "I won’t forget. Bye Mom, love you!";
					dialogueCount++;
					break;
				case 23:
					lblName.Text = "Mother";
					lblDialogue.Text = "Oh and be careful out there-";
					dialogueCount++;
					break;
				case 24:
					picMotherHappy.Visible = false;
					lblName.Text = "";
					lblDialogue.Text = userName + " closes the door";
					dialogueCount++;
					break;
				case 25:

					lblName.Text = "Mother";
					lblDialogue.Text = "There… I love you too.";
					dialogueCount++;
					break;
				case 26:

					lblName.Text = "";
					lblDialogue.Text = userName + " takes out the trash and goes on his way";
					dialogueCount++;
					break;
				case 27:
					this.BackgroundImage = Properties.Resources.CarsCrashBG;
					lblName.Text = "";
					lblDialogue.Text = "Cars crash in front of " + userName;
					dialogueCount++;
					break;
				case 28:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					lblName.Text = userName;
					lblDialogue.Text = userName + " jolts back from shock.";
					dialogueCount++;
					break;
				case 29:
					lblName.Text = "";
					lblDialogue.Text = "What just happened?";
					dialogueCount++;
					break;
				case 30:
					lblName.Text = "Unknown";
					lblDialogue.Text = "Hey. Someone call the ambulance!";
					dialogueCount++;
					break;
				case 31:
					lblName.Text = userName;
					lblDialogue.Text = "I don’t want to be part of this. I hope they get the help they need but I – I have to go.";
					dialogueCount++;
					break;
				case 32:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleStressed;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleStressed ;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Wait, that’s the only direction to school. I have to take the detour quick.";
					dialogueCount++;
					break;
				case 33:
					this.BackgroundImage = Properties.Resources.AlleywayBG;
					lblName.Text = "";
					lblDialogue.Text = userName + " walks through a secluded alley as the sound of the ambulance gets quieter.";
					dialogueCount++;
					break;
				case 34:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					lblName.Text = userName;
					lblDialogue.Text = "I feel someone watching me.";
					dialogueCount++;
					break;
				case 35:
					lblName.Text = userName;
					lblDialogue.Text = "I should quicken up the pace. This is why I hate going through here.";
					dialogueCount++;
					break;
				case 36:
					lblName.Text = userName;
					lblDialogue.Text = "I feel something at my back...";
					dialogueCount++;
					break;
				case 37:
					lblName.Text = userName;
					lblDialogue.Text = "Or maybe - Someone...";
					dialogueCount++;
					break;
				case 38:
					lblName.Text = "";
					lblDialogue.Text = userName + " turns back..";
					dialogueCount++;
					break;
				case 39:
					lblName.Text = userName;
					lblDialogue.Text = "Who’s there?";
					picScare.Visible = true;
					timer1.Interval = 25;
					timer1.Start();
					dialogueCount++;
					break;
				case 40:
					lblName.Text = userName;
					lblDialogue.Text = "No no no, not again.";
					dialogueCount++;
					break;
				case 41:
					lblName.Text = "";
					lblDialogue.Text = "A pair of hands surround " + userName + "’s face. Everything turns black.";
					this.BackgroundImage = null;
					this.BackColor = Color.Black;
					dialogueCount++;
					break;
				case 42:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Where am I?";
					dialogueCount++;
					break;
				case 43:
					lblName.Text = userName;
					lblDialogue.Text = "I can't see anything";
					dialogueCount++;
					break;
				case 44:
					lblName.Text = userName;
					lblDialogue.Text = "Am I dead?";
					dialogueCount++;
					break;
				case 45:
					lblName.Text = "Unknown";
					lblDialogue.Text = "Indeed, you are";
					dialogueCount++;
					this.BackgroundImage = Properties.Resources.BlackWithRedSmokeBG;
					break;
				case 46:
					lblName.Text = userName;
					lblDialogue.Text = "Who are you?";
					dialogueCount++;
					break;
				case 47:
					lblName.Text = "Unknown";
					lblDialogue.Text = "I go by many names. Grim reaper, Death, Shinigami";
					dialogueCount++;
					break;
				case 48:
					lblName.Text = userName;
					lblDialogue.Text = "What – Happened?";
					dialogueCount++;
					break;
				case 49:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You died but of an unknown cause.";
					dialogueCount++;
					break;
				case 50:
					lblName.Text = userName;
					lblDialogue.Text = "What unknown cause, aren’t you supposed to know this?";
					dialogueCount++;
					break;
				case 51:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "I am not as I was back then, you died due to a supernatural being.";
					dialogueCount++;
					break;
				case 52:
					lblName.Text = userName;
					lblDialogue.Text = "What supernatural being? Who? Why? What?";
					dialogueCount++;
					break;
				case 53:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Too many questions.";
					dialogueCount++;
					break;
				case 54:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleStressed;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleStressed;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Well, at least answer me this, what happens now?";
					dialogueCount++;
					break;
				case 55:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Let me see.";
					dialogueCount++;
					break;
				case 56:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					picShinigami.Visible = true;
					lblName.Text = "";
					lblDialogue.Text = userName + " can now see the Shinigami";
					dialogueCount++;
					break;
				case 57:
					lblName.Text = userName;
					lblDialogue.Text = "AHH";
					dialogueCount++;
					break;
				case 58:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "As from who you are, I can’t deem you as someone good nor bad.";
					dialogueCount++;
					break;
				case 59:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Where am I?";
					dialogueCount++;
					break;
				case 60:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Limbo, where I live";
					dialogueCount++;
					break;
				case 61:
					lblName.Text = userName;
					lblDialogue.Text = "Where am I going to go?";
					dialogueCount++;
					break;
				case 62:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Seeing as you, my child, are neither good nor evil. You have to take back your soul from hell.";
					dialogueCount++;
					break;
				case 63:
					lblName.Text = userName;
					lblDialogue.Text = "What? Why is my soul in hell?";
					dialogueCount++;
					break;
				case 64:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "People in limbo like you have their souls randomly placed into either of the two extremes.";
					dialogueCount++;
					break;
				case 65:
					lblName.Text = userName;
					lblDialogue.Text = "So I just need to get to my soul?";
					dialogueCount++;
					break;
				case 66:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You have to find an artifact, like this.";
					dialogueCount++;
					break;
				case 67:
					picArtifact.Visible = true;
					lblName.Text = "";
					lblDialogue.Text = "Shinigami shows artifact";
					dialogueCount++;
					break;
				case 68:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "In order to get your soul, you have to activate it by chanting the phrase: nevigila, mors deus, three times.";
					dialogueCount++;
					break;
				case 69:
					picArtifact.Visible = false;
					lblName.Text = userName;
					lblDialogue.Text = "What does it mean?";
					dialogueCount++;
					break;
				case 70:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Cease your curiosity, child. Doing this will activate the artifact and give you the soul that you so desperately need.";
					dialogueCount++;
					break;
				case 71:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = userName;
					lblDialogue.Text = "If I get my soul, do I go to heaven?";
					dialogueCount++;
					break;
				case 72:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "It’s your soul, your choice.";
					dialogueCount++;
					break;
				case 73:
					lblName.Text = userName;
					lblDialogue.Text = "Okay, I am ready.";
					dialogueCount++;
					break;
				case 74:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Not just yet, you have forgotten to take this.";
					dialogueCount++;
					break;
				case 75:
					lblName.Text = "";
					lblDialogue.Text = "Gives an orb to " + userName + " and a ghost killer";
					dialogueCount++;
					break;
				case 76:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "That should last you for a while.";
					dialogueCount++;
					break;
				case 77:
					lblName.Text = userName;
					lblDialogue.Text = "uh..What do I do with these?";
					dialogueCount++;
					break;
				case 78:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Don't worry, you'll find out sooner or later.";
					dialogueCount++;
					break;
				case 79:
					picPortal.Visible = true;
					lblName.Text = "";
					lblDialogue.Text = "Portal opens";
					dialogueCount++;
					break;
				case 80:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					lblName.Text = userName;
					lblDialogue.Text = "WHAT IS THAT?";
					dialogueCount++;
					break;
				case 81:
					lblName.Text = "";
					lblDialogue.Text = "Shinigami pushes " + userName + " into the portal";
					dialogueCount++;
					break;
				case 82:
					lblName.Text = userName;
					lblDialogue.Text = "AHHHHH";
					dialogueCount++;
					break;
				case 83:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Goodluck";
					dialogueCount++;
					break;
				case 84:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You'll need it.";
					dialogueCount++;
					break;
				case 85:
					this.BackgroundImage = null;
					this.BackColor = Color.Black;
					picPortal.Visible = false;
					picShinigami.Visible = false;
					lblName.Text = "";
					lblDialogue.Text = userName + " kept falling until everything was black…";
					dialogueCount++;
					break;
				case 86:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleStressed;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleStressed;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Where am I..";
					dialogueCount++;
					break;
				case 87:
					lblName.Text = "";
					lblDialogue.Text = userName + " slowly opened their eyes and found themself in the depths of hell, but it wasn't what they expected it to be";
					dialogueCount++;
					break;
				case 88:
					lblName.Text = userName;
					lblDialogue.Text = "That's right, the portal and the shinigami..";
					dialogueCount++;
					break;
				case 89:
					lblName.Text = "";
					lblDialogue.Text = userName + " looked around , it was dark and creepy, it had an eerie feeling to it";
					dialogueCount++;
					break;
				case 90:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Is this… really hell?";
					dialogueCount++;
					break;
				case 91:
					lblName.Text = userName;
					lblDialogue.Text = "I don't even know where to start";
					dialogueCount++;
					break;
				case 92:
					lblName.Text = "";
					lblDialogue.Text = userName + " walked around the area a bit and felt what feels to be a door?";
					dialogueCount++;
					break;
				case 93:
					lblName.Text = userName;
					lblDialogue.Text = "Well that's weird… there's nothing else here, just a door in the middle of nowhere…";
					dialogueCount++;
					break;
				case 94:
					lblName.Text = "Mind";
					lblDialogue.Text = "I decided to open it, I mean what could go wrong when I am already dead. Right?";
					dialogueCount++;
					break;
				case 95:
					lblName.Text = "";
					lblDialogue.Text = userName + " opened the door, thinking nothing would be there but there was a room. " + userName + " had a lot of questions but suddenly they got pushed in and the door slammed shut. They turned around to open it but the door wasn't there…\r\n";
					dialogueCount++;
					break;
				case 96:
					lblName.Text = userName;
					lblDialogue.Text = "H-hello? Is anyone there?";
					dialogueCount++;
					break;
				case 97:
					lblName.Text = "";
					picRubyEyes.Visible = true;
					lblDialogue.Text = "The room was dark and MC couldn't see anything until they saw 2 pair of ruby eyes";
					dialogueCount++;
					break;
				case 98:
					lblName.Text = userName;
					lblDialogue.Text = "hello?";
					dialogueCount++;
					break;
				case 99:
					lblName.Text = "";
					lblDialogue.Text = userName + " walked towards the ruby eyes and got unconscious";
					dialogueCount++;
					break;
				case 100:
					lblName.Text = "";
					picRubyEyes.Visible = false;      
					this.BackgroundImage = Properties.Resources.StomachBackground;
					lblDialogue.Text = userName + " woke up with their head hurting";
					dialogueCount++;
					break;
				case 101:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleStressed;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleStressed;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Bad things always happen to be, this must be a dream";
					dialogueCount++;
					break;
				case 102:
					lblName.Text = userName;
					lblDialogue.Text = "A dream that I want to wake up from so bad...";
					dialogueCount++;
					break;
				case 103:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = "";
					lblDialogue.Text = "They looked around to what seemed like something he had seen in a game.";
					dialogueCount++;
					break;
				case 104:
					lblName.Text = userName;
					lblDialogue.Text = "Gluttony?";
					dialogueCount++;
					break;
				case 105:
					lblName.Text = "";
					lblDialogue.Text = "There was a piece of paper on the wall, instructions maybe?";
					dialogueCount++;
					break;
				case 106:
					lblName.Text = "Paper";
					lblDialogue.Text = "Find keys, fight monsters. Don't listen to what they say.";
					dialogueCount++;
					break;
				case 107:
					lblName.Text = userName;
					lblDialogue.Text = "Im guessing thats what these are for";
					dialogueCount++;
					break;
				case 108:
					lblName.Text = "";
					lblDialogue.Text = "They bring out the things that the shinigami gave them";
					dialogueCount++;
					break;
				case 109:
					lblName.Text = userName;
					lblDialogue.Text = "This is gonna be so disgusting...";
					dialogueCount++;
					break;
				case 110:
					dialogueCount = 0;
					this.Hide();
					player = new Player();
					player.MaxHealth = 100;
					player.Health = 100;
					player.AttackPower = 1;
					player.Level = 1;
					player.Experience = 0;
					player.ExperienceToNextLevel = 100;
					player.WeaponAttackPower = 0;

					using (frmGameRPG Game = new frmGameRPG(player))
					{
						Game.ShowDialog();
					}
					this.Close();
					break;
				default:

					break;
			}
		}

		//
		private void frmGameVN_MouseClick(object sender, MouseEventArgs e)
		{
			storyline();
		}

		private Player player;
		private void cmdTemp_Click(object sender, EventArgs e)
		{
			this.Hide();
			player = new Player();
			player.MaxHealth = 100;
			player.Health = 100;
			player.AttackPower = 1;
			player.Level = 1;
			player.Experience = 0;
			player.ExperienceToNextLevel = 100;
			player.WeaponAttackPower = 0;

			using (frmGameRPG Game = new frmGameRPG(player))
			{
				Game.ShowDialog();
			}
			this.Close();
		}

		private void frmGameVN_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				storyline();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmVisualNovel2 VN2 = new frmVisualNovel2();
			VN2.ShowDialog();
			this.Close();
		}
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Enter || keyData == Keys.Space)
			{
				storyline();
				return true; 
			}
			return base.ProcessDialogKey(keyData);
		}
	}
}
