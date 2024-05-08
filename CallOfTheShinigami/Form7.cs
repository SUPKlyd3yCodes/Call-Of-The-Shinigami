using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallOfTheShinigami.frmGameSelection;
using System.Xml.Linq;

namespace CallOfTheShinigami
{
	public partial class frmVisualNovel2 : Form
	{
		public frmVisualNovel2()
		{
			InitializeComponent();
		}
		int dialogueCount = 0;
		private string userName = frmGameSelection.characterInformation.Username;
		private string Gender = frmGameSelection.characterInformation.GenderOption;

		private void frmVisualNovel2_Load(object sender, EventArgs e)
		{
			if (Gender == "Female")
			{
				picMC.Image = Properties.Resources.MCFemaleHappy;
			}
			else
			{
				picMC.Image = Properties.Resources.MCMaleHappy;
			}
		}
		private void storyline()
		{
			switch (dialogueCount)
			{
				case 0:
					this.BackgroundImage = null;
					lblName.Text = "";
					lblDialogue.Text = "You see a bright flash";
					dialogueCount++;
					break;
				case 1:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Is this... Finally it?";
					dialogueCount++;

					break;
				case 2:
					lblName.Text = userName;
					lblDialogue.Text = "I got...";
					dialogueCount++;

					break;
				case 3:
					lblName.Text = userName;
					lblDialogue.Text = "...My soul back.";
					dialogueCount++;

					break;
				case 4:
					this.BackgroundImage = Properties.Resources.Home;
					lblName.Text = userName;
					lblDialogue.Text = "And I'm back home!";
					dialogueCount++;

					break;
				case 5:
					picMotherScared.Visible = false;
					picMotherHappy.Visible = true;
					lblName.Text = "Mother";
					lblDialogue.Text = "You look as white as a ghost. Go and drink some water and wash your face, it’ll help you feel better.";
					dialogueCount++;
					break;
				case 6:
					lblName.Text = userName;
					lblDialogue.Text = "Ok, mom.";
					dialogueCount++;
					break;
				case 7:
					this.BackgroundImage = Properties.Resources.ShowerBG;
					picMotherHappy.Visible = false;
					lblName.Text = "";
					lblDialogue.Text = userName + " gets up to wash his face and takes a shower";
					dialogueCount++;
					break;
				case 8:
					lblName.Text = "";
					lblDialogue.Text = "Showers";
					dialogueCount++;
					break;
				case 9:
					lblName.Text = userName;
					lblDialogue.Text = "And there's no more thuds";
					dialogueCount++;
					break;
				case 10:
					lblName.Text = userName;
					lblDialogue.Text = "No more my mind playing tricks on me again";
					dialogueCount++;
					break;
				case 11:
					lblName.Text = "";
					lblDialogue.Text = userName + " finishes showering";
					dialogueCount++;
					break;
				case 12:
					lblName.Text = "Mother";
					lblDialogue.Text = "Hey " + userName + ". Breakfast is ready.";
					dialogueCount++;
					break;
				case 13:
					lblName.Text = userName;
					lblDialogue.Text = "I’m coming, Mom!";
					dialogueCount++;
					break;
				case 14:
					this.BackgroundImage = Properties.Resources.DiningRoomBG;
					picFood.Visible = true;
					picMotherVeryHappy.Visible = true;
					lblName.Text = "";
					lblDialogue.Text = "A special omelet with bread on the side sits comfortably on the table, one of your favorite homemade dishes";
					dialogueCount++;
					break;
				case 15:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleVeryHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Woah, it’s my favorite again! Thanks, Mom!";
					dialogueCount++;
					break;
				case 16:
					lblName.Text = "Mother";
					lblDialogue.Text = "No problem.";
					dialogueCount++;
					break;
				case 17:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					picFood.Visible = false;
					lblName.Text = userName;
					lblDialogue.Text = userName + " eats the dish";
					dialogueCount++;
					break;
				case 18:
					picMotherHappy.Visible = true;
					picMotherVeryHappy.Visible = false;
					lblName.Text = "Mother";
					lblDialogue.Text = "By the way, don’t forget to take out the trash when you leave the house.";
					dialogueCount++;
					break;
				case 19:
					lblName.Text = userName;
					lblDialogue.Text = "I won’t forget. Bye Mom, love you!";
					dialogueCount++;
					break;
				case 20:
					lblName.Text = "Mother";
					lblDialogue.Text = "Oh and be careful out there-";
					dialogueCount++;
					break;
				case 21:
					picMotherHappy.Visible = false;
					lblName.Text = "";
					lblDialogue.Text = userName + " closes the door";
					dialogueCount++;
					break;
				case 22:

					lblName.Text = "Mother";
					lblDialogue.Text = "There… I love you too.";
					dialogueCount++;
					break;
				case 23:
					lblName.Text = "";
					lblDialogue.Text = userName + " takes out the trash and goes on his way";
					dialogueCount++;
					break;
				case 24:
					picLust.Visible = true;
					if (Gender == "Male")
					{
						picLust.Image = Properties.Resources.LustFemale1;
					}
					else
					{
						picLust.Image = Properties.Resources.LustMale1;
					}

					this.BackgroundImage = Properties.Resources.StreetBG;
					lblName.Text = "Friend";
					lblDialogue.Text = "Hey!!";
					dialogueCount++;
					break;
				case 25:

					lblName.Text = userName;
					lblDialogue.Text = "Look who woke up all nice";
					dialogueCount++;
					break;
				case 26:
					lblName.Text = "Friend";
					lblDialogue.Text = "I just had my favorite meal";
					dialogueCount++;
					break;
				case 27:
					lblName.Text = userName;
					lblDialogue.Text = "Favorite? Omelettes?";
					dialogueCount++;
					break;
				case 28:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = "Friend";
					lblDialogue.Text = "Wait, how’d you know that?";
					dialogueCount++;
					break;
				case 29:
					lblName.Text = userName;
					lblDialogue.Text = "You always eat it in school dummy";
					dialogueCount++;
					break;
				case 30:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = "Friend";
					lblDialogue.Text = "Oh right";
					dialogueCount++;
					break;
				case 31:
					lblName.Text = userName;
					lblDialogue.Text = "You’re so funny, " + userName;
					dialogueCount++;
					break;
				case 32:
					lblName.Text = "Friend";
					lblDialogue.Text = "You should come by sometime, my mom makes enough for an army.";
					dialogueCount++;
					break;
				case 33:
					lblName.Text = userName;
					lblDialogue.Text = "I might just take you up on that offer";
					dialogueCount++;
					break;
				case 34:
					lblName.Text = "Friend";
					lblDialogue.Text = "Anytime! Anyways, want to walk to school together?";
					dialogueCount++;
					break;
				case 35:
					lblName.Text = userName;
					lblDialogue.Text = "Sure, that sounds nice.";
					dialogueCount++;
					break;
				case 36:
					lblName.Text = "Friend";
					lblDialogue.Text = "Soo, how’s your morning?";
					dialogueCount++;
					break;
				case 37:
					lblName.Text = userName;
					lblDialogue.Text = "It was fine, I just received this letter though";
					dialogueCount++;
					break;
				case 38:
					lblName.Text = "Friend";
					lblDialogue.Text = "With the looks on your face, it doesn’t look good?";
					dialogueCount++;
					break;
				case 39:
					lblName.Text = userName;
					lblDialogue.Text = "Come take a look!";
					dialogueCount++;
					break;
				case 40:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleVeryHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = "Friend";
					lblDialogue.Text = "Woah! Congrats! You finally did it";
					dialogueCount++;
					break;
				case 41:
					lblName.Text = userName;
					lblDialogue.Text = "I know right! I’ve been dreaming to get accepted to this university and now I finally got in!";
					dialogueCount++;
					break;
				case 42:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = "Friend";
					lblDialogue.Text = "Good job you. I guess I’m not the only one getting a good morning.";
					dialogueCount++;
					break;
				case 43:
					lblName.Text = userName;
					lblDialogue.Text = "What are you planning to do when you graduate?";
					dialogueCount++;
					break;
				case 44:
					lblName.Text = "Friend";
					lblDialogue.Text = "I don’t know actually. I usually just go with the flow";
					dialogueCount++;
					break;
				case 45:
					lblName.Text = userName;
					lblDialogue.Text = "Eh. That’s what they all say.";
					dialogueCount++;
					break;
				case 46:
					lblName.Text = "Friend";
					lblDialogue.Text = "All I’m saying is true. It doesn’t really matter";
					dialogueCount++;
					break;
				case 47:
					lblName.Text = userName;
					lblDialogue.Text = "It does! Well, what do you usually like?";
					dialogueCount++;
					break;
				case 48:
					lblName.Text = "Friend";
					lblDialogue.Text = "Nothing much, maybe music?";
					dialogueCount++;
					break;
				case 49:
					lblName.Text = userName;
					lblDialogue.Text = "Then be a musician!";
					dialogueCount++;
					break;
				case 50:
					lblName.Text = "Friend";
					lblDialogue.Text = "Don’t they have bad pay?";
					dialogueCount++;
					break;
				case 51:
					lblName.Text = userName;
					lblDialogue.Text = "Not really, at least I can make you play all the music my heart is content to";
					dialogueCount++;
					break;
				case 52:
					lblName.Text = "Friend";
					lblDialogue.Text = "Maybe, I’ll prolly do that.";
					dialogueCount++;
					break;
				case 53:
					lblName.Text = userName;
					lblDialogue.Text = "Hey, how about you? Have any passions or dreams?";
					dialogueCount++;
					break;
				case 54:
					lblName.Text = "Friend";
					lblDialogue.Text = "I- Hmm";
					dialogueCount++;
					break;
				case 55:
					lblName.Text = userName;
					lblDialogue.Text = "Thinking real hard about it huh Ms. Scholarship";
					dialogueCount++;
					break;
				case 56:
					lblName.Text = "Friend";
					lblDialogue.Text = "Oh stop it! HHAHAHAH, I want to be a computer scientist!";
					dialogueCount++;
					break;
				case 57:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Oh? Aren’t jobs for that get lesser and lesser";
					dialogueCount++;
					break;
				case 58:
					lblName.Text = "Friend";
					lblDialogue.Text = "But who cares you know? A job is still a job, a course is still a course.";
					dialogueCount++;
					break;
				case 59:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = userName;
					lblDialogue.Text = "Well, whatever floats your boat I guess.";
					dialogueCount++;
					break;
				case 60:
					lblName.Text = "Friend";
					lblDialogue.Text = "Hey, it’s still a fun job!";
					dialogueCount++;
					break;
				case 61:
					lblName.Text = userName;
					lblDialogue.Text = "Yeah, yeah, whatever suits you. You’ll do your best at it either way";
					dialogueCount++;
					break;
				case 62:
					this.BackgroundImage = Properties.Resources.School;
					lblName.Text = "Friend";
					lblDialogue.Text = "Well, here we are. Thanks for walking with me.";
					dialogueCount++;
					break;
				case 63:
					lblName.Text = userName;
					lblDialogue.Text = "No problem. See you in class!";
					dialogueCount++;
					break;
				case 64:
					this.BackgroundImage = Properties.Resources.ClassroomBG;
					lblName.Text = "";
					lblDialogue.Text = "Gets into school and class";
					dialogueCount++;
					break;
				case 65:
					lblName.Text = "Friend";
					lblDialogue.Text = "Psstt. Do you know what the answers are?";
					dialogueCount++;
					break;
				case 66:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = "The day just started.";
					dialogueCount++;
					break;
				case 67:
					lblName.Text = "Friend";
					lblDialogue.Text = "Yeah I know but you do realize how harsh sir Klason is.";
					dialogueCount++;
					break;
				case 68:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleHappy;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleHappy;
					}
					lblName.Text = userName;
					lblDialogue.Text = "I guess that's true. Here.";
					dialogueCount++;
					break;
				case 69:
					lblName.Text = "Friend";
					lblDialogue.Text = "Thank you!";
					dialogueCount++;
					break;
				case 70:
					// Give notes
					lblName.Text = userName;
					lblDialogue.Text = "After the class";
					dialogueCount++;
					break;
				case 71:
					if (Gender == "Male")
					{
						picDrawing.Image = Properties.Resources.DrawingMale;
					}
					else
					{
						picDrawing.Image = Properties.Resources.DrawingFemale;
					}
					picDrawing.Visible = true;

					lblName.Text = "Friend";
					lblDialogue.Text = "Hey, thanks once again. I put a little something there.";
					dialogueCount++;
					break;
				case 72:
					lblName.Text = userName;
					lblDialogue.Text = "Aww, is that me?";
					dialogueCount++;
					break;
				case 73:
					lblName.Text = "Friend";
					lblDialogue.Text = "Yeah, I got kinda bored in class so I decided to draw you.";
					dialogueCount++;
					break;
				case 74:
					lblName.Text = userName;
					lblDialogue.Text = "Yeah, I love it, it's nice. I wish I could draw you too.";
					dialogueCount++;
					break;
				case 75:
					lblName.Text = "Friend";
					lblDialogue.Text = "Really?";
					dialogueCount++;
					break;
				case 76:
					lblName.Text = userName;
					lblDialogue.Text = "Yeah, I draw sometimes too, but this, this is perfect.";
					dialogueCount++;
					break;
				case 77:
					lblName.Text = "Friend";
					lblDialogue.Text = "Really? The eyes are a bit off though.";
					dialogueCount++;
					break;
				case 78:
					lblName.Text = userName;
					lblDialogue.Text = "I didn’t even notice it. Oh I didn't realize its time. Come with me, let’s have lunch together.";
					dialogueCount++;
					break;
				case 79:
					lblName.Text = "Friend";
					lblDialogue.Text = "Sure!";
					dialogueCount++;
					break;
				case 80:
					picDrawing.Visible = false;
					this.BackgroundImage = Properties.Resources.CafeteriaBG;
					lblName.Text = "";
					lblDialogue.Text = "Went to cafeteria";
					dialogueCount++;
					break;
				case 81:
					lblName.Text = userName;
					lblDialogue.Text = "Wait, I just remembered. You know my favorite food but I never knew yours.";
					dialogueCount++;
					break;
				case 82:
					lblName.Text = "Friend";
					lblDialogue.Text = "Oh, I don’t really have one.";
					dialogueCount++;
					break;
				case 83:
					lblName.Text = userName;
					lblDialogue.Text = "Nahh, I know you like one, you can tell me!";
					dialogueCount++;
					break;
				case 84:
					lblName.Text = "Friend";
					lblDialogue.Text = "Sure! It’s just salmon.";
					dialogueCount++;
					break;
				case 85:
					lblName.Text = userName;
					lblDialogue.Text = "Alright, one salmon coming up!";
					dialogueCount++;
					break;
				case 86:
					lblName.Text = "Friend";
					lblDialogue.Text = "Hey, I didn’t ask you to give me that.";
					dialogueCount++;
					break;
				case 87:
					lblName.Text = userName;
					lblDialogue.Text = "Too late!";
					dialogueCount++;
					break;
				case 88:
					lblName.Text = "Friend";
					lblDialogue.Text = "*blushes*";
					dialogueCount++;
					break;
				case 89:
					lblName.Text = userName;
					lblDialogue.Text = "And, here we are. Eat well!";
					dialogueCount++;
					break;
				case 90:
					lblName.Text = "Friend";
					lblDialogue.Text = "You too!";
					dialogueCount++;
					break;
				case 91:
					this.BackgroundImage = Properties.Resources.ClassroomBG;
					lblName.Text = userName;
					lblDialogue.Text = "They ate lunch together and then finished classes.";
					dialogueCount++;
					break;
				case 92:
					lblName.Text = "Friend";
					lblDialogue.Text = "Hey, do you mind coming with me?";
					dialogueCount++;
					break;
				case 93:
					lblName.Text = userName;
					lblDialogue.Text = "Oh sure!";
					dialogueCount++;
					break;
				case 94:
					picLetter.Visible = true;
					lblName.Text = "Friend";
					lblDialogue.Text = "I just wanted to give you this letter. I think I want you to take it!";
					dialogueCount++;
					break;
				case 95:
					lblName.Text = userName;
					lblDialogue.Text = "Oh? You’re being weird.";
					dialogueCount++;
					break;
				case 96:
					lblName.Text = "Friend";
					lblDialogue.Text = "Hehe";
					dialogueCount++;
					break;
				case 97:
					lblName.Text = userName;
					lblDialogue.Text = "Woah, so, after all this time, you…";
					dialogueCount++;
					break;
				case 98:
					lblName.Text = userName;
					lblDialogue.Text = "You liked me?";
					dialogueCount++;
					break;
				case 99:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleStressed;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleStressed;
					}
					lblName.Text = "Friend";
					lblDialogue.Text = "Yeah, and I still do!";
					picLetter.Visible = false;
					cmdAccept.Visible = true;
					cmdReject.Visible = true;
					dialogueCount++;
					break;
				case 109:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					lblName.Text = "Lust Demon";
					lblDialogue.Text = "Ugh. I concede, I can't tempt you.";
					dialogueCount++;
					break;
				case 110:
					lblName.Text = "Lust Demon";
					lblDialogue.Text = "Don't let him tempt you too. I'll show you the way to the artifact now.";
					dialogueCount++;
					break;
				case 111:
					this.Hide();
					frmVNFinale Finale = new frmVNFinale();
					Finale.ShowDialog();
					this.Close();
					break;
				default:
					break;
			}
		}
		private void frmVisualNovel2_Click(object sender, EventArgs e)
		{
			storyline();
		}

		private void cmdAccept_Click(object sender, EventArgs e)
		{
			if (Gender == "Male")
			{
				picLust.Image = Properties.Resources.LustFemale10;
				lblDialogue.Text = "You've fallen into my trap.";
				lblName.Text = "Lust.";
				tmrDeath.Enabled = true;
			}
			else
			{
				picLust.Image = Properties.Resources.LustMale10;
				lblDialogue.Text = "You've fallen into my trap.";
				lblName.Text = "Lust.";
				tmrDeath.Enabled = true;
			}
		}

		private void cmdReject_Click(object sender, EventArgs e)
		{
			if (Gender == "Female")
			{
				switch (dialogueCount)
				{
					case 100:
						picLust.Image = Properties.Resources.LustMale2;
						lblDialogue.Text = "You don't mean that, right?";
						dialogueCount++;
						break;
					case 101:
						picLust.Image = Properties.Resources.LustMale3;
						lblDialogue.Text = "What. Don't change your mind now.";
						dialogueCount++;
						break;
					case 102:
						picLust.Image = Properties.Resources.LustMale4;
						lblDialogue.Text = "You're supposed to say yes";
						dialogueCount++;
						break;
					case 103:
						picLust.Image = Properties.Resources.LustMale5;
						lblDialogue.Text = "Stop it.";
						dialogueCount++;
						break;
					case 104:
						picLust.Image = Properties.Resources.LustMale6;
						lblDialogue.Text = "I can give you everything. Body, love, beauty. Choose me.";
						dialogueCount++;
						break;
					case 105:
						picLust.Image = Properties.Resources.LustMale7;
						lblDialogue.Text = "Don't you want to have fun?";
						dialogueCount++;
						break;
					case 106:
						picLust.Image = Properties.Resources.LustMale8;
						lblDialogue.Text = "You're hurting me.";
						dialogueCount++;
						break;
					case 107:
						picLust.Image = Properties.Resources.LustMale9;
						lblDialogue.Text = "It hurts.";
						dialogueCount++;
						break;
					case 108:
						picLust.Image = Properties.Resources.LustMale10;
						picLust.Visible = false;
						picLustJumpscare.Visible = true;
						this.WindowState = FormWindowState.Maximized;
						picLustJumpscare.Size = new Size(777, 940);
						picLustJumpscare.Location = new Point((this.Width / 2) - (picLustJumpscare.Width / 2), (this.Height / 2) - (picLustJumpscare.Height / 2));
						picMC.Visible = false;
						lblDialogue.Visible = false;
						lblName.Visible = false;
						cmdAccept.Visible = false;
						cmdReject.Visible = false;
						picDialogueBox.Visible = false;
						lblDialogue.Text = "...";
						tmrTicker.Enabled = true;
						dialogueCount++;
						break;
					default:
						break;
				}
			}
			else
			{
				switch (dialogueCount)
				{
					case 100:
						picLust.Image = Properties.Resources.LustFemale2;
						lblDialogue.Text = "You don't mean that, right?";
						dialogueCount++;
						break;
					case 101:
						picLust.Image = Properties.Resources.LustFemale3;
						lblDialogue.Text = "What. Don't change your mind now.";
						dialogueCount++;
						break;
					case 102:
						picLust.Image = Properties.Resources.LustFemale4;
						lblDialogue.Text = "You're supposed to say yes";
						dialogueCount++;
						break;
					case 103:
						picLust.Image = Properties.Resources.LustFemale5;
						lblDialogue.Text = "Stop it.";
						dialogueCount++;
						break;
					case 104:
						picLust.Image = Properties.Resources.LustFemale6;
						
						lblDialogue.Text = "I can give you everything. Body, love, beauty. Choose me.";
						dialogueCount++;
						break;
					case 105:
						picLust.Image = Properties.Resources.LustFemale7;
						lblDialogue.Text = "Don't you want to have fun?";
						dialogueCount++;
						break;
					case 106:
						picLust.Image = Properties.Resources.LustFemale8;
						lblDialogue.Text = "You're hurting me.";
						dialogueCount++;
						break;
					case 107:
						picLust.Image = Properties.Resources.LustFemale9;
						lblDialogue.Text = "It hurts.";
						dialogueCount++;
						break;
					case 108:
						picLust.Image = Properties.Resources.LustFemale10;
						picLust.Visible = false;
						picLustJumpscare.Visible = true;
						this.WindowState = FormWindowState.Maximized;
						picLustJumpscare.Size = new Size(777, 940);
						picLustJumpscare.Location = new Point((this.Width / 2) - (picLustJumpscare.Width / 2), (this.Height / 2) - (picLustJumpscare.Height / 2));
						picMC.Visible = false;
						lblDialogue.Visible = false;
						lblName.Visible = false;
						cmdAccept.Visible = false;
						cmdReject.Visible = false;
						picDialogueBox.Visible = false;
						lblDialogue.Text = "...";
						tmrTicker.Enabled = true;
						dialogueCount++;
						break;
					default:
						break;
				}
			}
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

		private void tmrTicker_Tick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.CenterToScreen(); 
			picLustJumpscare.Visible = false;
			picLust.Visible = true;
			picMC.Visible = true;
			lblDialogue.Visible = true;
			lblName.Visible = true;
			picDialogueBox.Visible = true;
			lblDialogue.Text = "...";
			lblName.Text = "Lust";
			tmrTicker.Enabled = false;
		}

		private void tmrDeath_Tick(object sender, EventArgs e)
		{         
		}
	}
}
