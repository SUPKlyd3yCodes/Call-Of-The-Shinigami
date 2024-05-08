using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallOfTheShinigami
{
	public partial class frmVNFinale : Form
	{
		public frmVNFinale()
		{
			InitializeComponent();
		}
		int dialogueCount = 0;
		int dialogueCountActivate = 0;
		int dialogueCountNotActivate = 0;
		private string userName = frmGameSelection.characterInformation.Username;
		private string Gender = frmGameSelection.characterInformation.GenderOption;

		private void frmVNFinale_Load(object sender, EventArgs e)
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
					lblName.Text = userName;
					lblDialogue.Text = "So bright again...";
					dialogueCount++;
					break;
				case 1:
					this.BackgroundImage = Properties.Resources.NightmareBackground;
					lblName.Text = userName;
					lblDialogue.Text = "This...";
					dialogueCount++;
					break;
				case 2:
					lblName.Text = userName;
					lblDialogue.Text = "This feels oddly familiar.";
					dialogueCount++;
					break;
				case 3:
					lblName.Text = userName;
					lblDialogue.Text = "I see it. The artifact!";
					dialogueCount++;
					break;
				case 4:
					picArtifact.Visible = true;
					lblName.Text = userName;
					lblDialogue.Text = "It's so beautiful, and my soul is contained in that.";
					dialogueCount++;
					break;
				case 5:
					lblName.Text = "Artifact";
					lblDialogue.Text = "Choose. Choose. Choose. Choose. Pick me. It will give you what you need if you choose me.";
					dialogueCount++;
					break;
				case 6:
					picArtifact.Visible = true;
					lblName.Text = userName;
					lblDialogue.Text = "Wh-";
					dialogueCount++;
					break;
				case 7:
					cmdAccept.Visible = true;
					cmdReject.Visible = true;
					lblName.Text = "Artifact";
					lblDialogue.Text = "ACTIVATE ME NOW.";
					dialogueCount++;
					break;
				default:
					break;
			}

			switch(dialogueCountActivate)
			{
				case 1:
					lblName.Text = userName;
					lblDialogue.Text = "What was it again? Oh right. Nevigila, mors deus. Nevigila, mors deus. Nevigila, mors deus.";
					dialogueCountActivate++;
					break;
				case 2:
					lblName.Text = "Artifact";
					lblDialogue.Text = "ACTIVATED";
					dialogueCountActivate++;
					break;
				case 3:
					lblName.Text = userName;
					picArtifact.Visible = false;
					lblDialogue.Text = "And alas, I – I am free.";
					dialogueCountActivate++;
					break;
				case 4:
					lblName.Text = "";
					lblDialogue.Text = "Creak creak.";
					dialogueCountActivate++;
					break;
				case 5:
					lblName.Text = userName;
					lblDialogue.Text = "Shinigami, I activated the artifact, and now I’m free.";
					dialogueCountActivate++;
					break;
				case 6:
					lblName.Text = "";
					lblDialogue.Text = "Silence envelops the world.";
					dialogueCountActivate++;
					break;
				case 7:
					lblName.Text = userName;
					lblDialogue.Text = "Shinigami? Where are you? I did it, didn’t I?";
					dialogueCountActivate++;
					break;
				case 8:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Turn around.";
					dialogueCountActivate++;
					break;
				case 9:
					lblName.Text = "";
					lblDialogue.Text = userName + " turns around.";
					dialogueCountActivate++;
					break;
				case 10:
					picShinigami.Image = Properties.Resources.HangedWomanWorst;
					picShinigami.Visible = true;
					lblName.Text = userName;
					lblDialogue.Text = "You’re – you’re…";
					dialogueCountActivate++;
					break;
				case 11:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "The woman in your nightmares?";
					dialogueCountActivate++;
					break;
				case 12:
					lblName.Text = userName;
					lblDialogue.Text = "WHY ARE YOU HERE? WHERE’S SHINIGAMI?";
					dialogueCountActivate++;
					break;
				case 13:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "I’ve always been here, throughout your whole entire journey.";
					dialogueCountActivate++;
					break;
				case 14:
					lblName.Text = userName;
					lblDialogue.Text = "What are you talking about…";
					dialogueCountActivate++;
					break;
				case 15:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "And you never noticed? All of this. A part of the nightmares you experienced and you never took note of it.";
					dialogueCountActivate++;
					break;
				case 16:
					lblName.Text = userName;
					lblDialogue.Text = "I – I thought they were just dreams.";
					dialogueCountActivate++;
					break;
				case 17:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "The woman in your dreams was me, and I am the woman in your dreams. It’s that simple really.";
					dialogueCountActivate++;
					break;
				case 18:
					lblName.Text = userName;
					lblDialogue.Text = "Then where is my soul back?";
					dialogueCountActivate++;
					break;
				case 19:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Your soul? It was never here, to begin with.";
					dialogueCountActivate++;
					break;
				case 20:
					lblName.Text = userName;
					lblDialogue.Text = "You lied to me.";
					dialogueCountActivate++;
					break;
				case 21:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Doesn’t everyone – lie? Doesn’t every human being, lie?";
					dialogueCountActivate++;
					break;
				case 22:
					lblName.Text = userName;
					lblDialogue.Text = "Then where is it, what did you do to it?";
					dialogueCountActivate++;
					break;
				case 23:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "It’s here.";
					dialogueCountActivate++;
					break;
				case 24:
					lblName.Text = userName;
					lblDialogue.Text = "Where?";
					dialogueCountActivate++;
					break;
				case 25:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "It is within you and you didn’t even notice it? You didn’t notice how weird it was for a person who’s neither good nor bad to be in hell? You didn’t notice how you are your soul? How foolish are you to not acknowledge the fact that without a soul, you — you are nothing.";
					dialogueCountActivate++;
					break;
				case 26:
					lblName.Text = userName;
					lblDialogue.Text = "But, I thought I could trust–";
					dialogueCountActivate++;
					break;
				case 27:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "HAHAHA. Trust me? You – you mindless little creature thought that you could trust me? A God of death.";
					dialogueCountActivate++;
					break;
				case 28:
					lblName.Text = "MC's thoughts";
					lblDialogue.Text = "No no no, this isn’t happening.";
					dialogueCountActivate++;
					break;
				case 29:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Have you not realized that I can hear even your thoughts? This IS my domain. Nothing here is merely thoughts. Everything you see, feel, and even dream, is real.";
					dialogueCountActivate++;
					break;
				case 30:
					lblName.Text = "";
					picShinigami.Image = Properties.Resources.MotherVeryHappy;
					dialogueCountActivate++;
					break;
				case 31:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Even this – this mere human being that you thought was your mother a while back in lust's stage?";
					dialogueCountActivate++;
					break;
				case 32:
					lblName.Text = userName;
					lblDialogue.Text = "DON’T TALK TO HER LIKE THAT.";
					dialogueCountActivate++;
					break;
				case 33:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "How ironic, when you yourself thought that your own mother would be in hell.";
					dialogueCountActivate++;
					break;
				case 34:
					lblName.Text = userName;
					lblDialogue.Text = "HOW WOULD I KNOW IF SHE WASN’T REAL?";
					dialogueCountActivate++;
					break;
				case 35:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You did know, you just chose not to believe in it yourself.";
					dialogueCountActivate++;
					break;
				case 36:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "And this artifact you just activated?";
					dialogueCountActivate++;
					break;
				case 37:
					lblName.Text = "";
					lblDialogue.Text = "Shapeshifts into normal form.";
					picShinigami.Image = Properties.Resources.Shinigami;
					dialogueCountActivate++;
					break;
				case 38:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You were just a guinea pig for what I actually needed to do.";
					dialogueCountActivate++;
					break;
				case 39:
					lblName.Text = userName;
					lblDialogue.Text = "What – What do you mean?";
					dialogueCountActivate++;
					break;
				case 40:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Tell me, what do you think is power?";
					dialogueCountActivate++;
					break;
				case 41:
					lblName.Text = userName;
					lblDialogue.Text = "I’m not playing games. What. are. you. talking. About.";
					dialogueCountActivate++;
					break;
				case 42:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "C’mon now, what do you think is power?";
					dialogueCountActivate++;
					break;
				case 43:
					lblName.Text = userName;
					lblDialogue.Text = "STO-";
					dialogueCountActivate++;
					break;
				case 44:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "ANSWER. MY. QUESTION.";
					dialogueCountActivate++;
					break;
				case 45:
					lblName.Text = userName;
					lblDialogue.Text = "Strength.";
					dialogueCountActivate++;
					break;
				case 46:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You worthless fool. No, I’ve already been strong by myself. Power is determined by how much you control fate, the world, and everything in it. What you activated just now, is my source of power.";
					dialogueCountActivate++;
					break;
				case 47:
					lblName.Text = userName;
					lblDialogue.Text = "No…";
					dialogueCountActivate++;
					break;
				case 48:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Now that I have no need for you, I shall erase you in order for me to flourish, you will die knowing that you made my existence onto Earth possible. You will think of the havoc created by me, across the 7 continents and the 7 seas, knowing that you, you made that happen.";
					dialogueCountActivate++;
					break;
				case 49:
					lblName.Text = userName;
					lblDialogue.Text = "No. No. NO.";
					dialogueCountActivate++;
					break;
				case 50:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You will cease to exist, forgotten by the people around you, and become not even a mere memory.";
					dialogueCountActivate++;
					break;
				case 51:
					lblName.Text = userName;
					lblDialogue.Text = "I–";
					dialogueCountActivate++;
					break;
				case 52:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "EVANESCERE";
					dialogueCountActivate++;
					break;
				case 53:
					lblName.Text = "Game";
					lblDialogue.Text = "Thanks for playing. Find out other choices by restarting. Stay tuned for the next versions";
					dialogueCountActivate++;
					break;
				case 54:
					Thread.Sleep(1000);
					this.Hide();
					frmGameOver gameOver = new frmGameOver();
					gameOver.ShowDialog();
					this.Close();
					break;
				default:
					break;
			}

			switch (dialogueCountNotActivate)
			{
				case 1:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = userName + " What was it again? Oh right. Nevigila, mors deus. Nevigila, mors- Wait.";
					dialogueCountNotActivate++;
					break;
				case 2:
					lblName.Text = "Artifact";
					lblDialogue.Text = "DESTROYED.";
					dialogueCountNotActivate++;
					break;
				case 3:
					picArtifact.Visible = false;  
					lblName.Text = userName;
					lblDialogue.Text = "I don’t think I trust this.";
					dialogueCountNotActivate++;
					break;
				case 4:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					lblName.Text = "";
					lblDialogue.Text = "Creak creak.";
					dialogueCountNotActivate++;
					break;
				case 5:
					lblName.Text = userName;
					lblDialogue.Text = "Who’s there?";
					dialogueCountNotActivate++;
					break;
				case 6:
					picShinigami.Visible = true;
					lblName.Text = "Shinigami";
					lblDialogue.Text = "You imbecile! What did you do?";
					dialogueCountNotActivate++;
					break;
				case 7:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleConfused;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleConfused;
					}
					lblName.Text = userName;
					lblDialogue.Text = "What?";
					dialogueCountNotActivate++;   
					break;
				case 8:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "My only chance to leave this accursed place and you ruined it.";
					dialogueCountNotActivate++;
					break;
				case 9:
					lblName.Text = userName;
					lblDialogue.Text = "So I was right not to trust it?";
					dialogueCountNotActivate++;
					break;
				case 10:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Humanity’s ability to be naive amazes me.";
					dialogueCountNotActivate++;
					break;
				case 11:
					lblName.Text = userName;
					lblDialogue.Text = "Where’s my soul?";
					dialogueCountNotActivate++;
					break;
				case 12:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "After all that I’ve done, and it’ll just end like this? And now you’re asking for your measly soul that’s been within you this entire time.";
					dialogueCountNotActivate++;
					break;
				case 13:
					lblName.Text = userName;
					lblDialogue.Text = "Why didn’t you tell me?";
					dialogueCountNotActivate++;
					break;
				case 14:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "Did you really think I would say anything to a measly human?";
					dialogueCountNotActivate++;
					break;
				case 15:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleStressed;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleStressed;
					}
					lblName.Text = userName;
					lblDialogue.Text = "...";
					dialogueCountNotActivate++;
					break;
				case 16:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "I hate you, your whole existence. You are useless and worthless. You ruined all of my plans to go back to Earth, now you ruined your chances too.";
					dialogueCountNotActivate++;
					break;
				case 17:
					lblName.Text = userName;
					lblDialogue.Text = "I–";
					dialogueCountNotActivate++;
					break;
				case 18:
					lblName.Text = "Shinigami";
					lblDialogue.Text = "It’s only right for you to stay here and wander the depths of hell by yourself.";
					dialogueCountNotActivate++;
					break;
				case 19:
					if (Gender == "Female")
					{
						picMC.Image = Properties.Resources.MCFemaleScared;
					}
					else
					{
						picMC.Image = Properties.Resources.MCMaleScared;
					}
					lblName.Text = userName;
					lblDialogue.Text = "WAIT NO! TAKE ME BA-";
					dialogueCountNotActivate++;
					break;
				case 20:
					lblName.Text = "";
					lblDialogue.Text = "Shinigami disappears.";
					dialogueCountNotActivate++;
					break;
				case 21:
					lblName.Text = userName;
					lblDialogue.Text = "No, no, no, NOOO!";
					dialogueCountNotActivate++;
					break;
				case 22:
					lblName.Text = "";
					lblDialogue.Text = "TO BE CONTINUED IN THE NEXT VERSION";
					dialogueCountNotActivate++;
					break;
				case 23:
					lblName.Text = "";
					lblDialogue.Text = "UPCOMING: ALL OTHER DEADLY SINS";
					dialogueCountNotActivate++;
					break;
				case 24:
					lblName.Text = "";
					lblDialogue.Text = "Thank you for playing!";
					dialogueCountNotActivate++;
					break;
				case 25:
					Thread.Sleep(1000);
					this.Hide();
					frmGameOver gameOver = new frmGameOver();
					gameOver.ShowDialog();
					this.Close();
					break;
				default:
					break;
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

		private void cmdAccept_Click(object sender, EventArgs e)
		{
			cmdAccept.Visible = false;
			cmdReject.Visible = false;
			dialogueCountActivate++;
			storyline();
		}

		private void cmdReject_Click(object sender, EventArgs e)
		{
			cmdReject.Visible = false;
			cmdAccept.Visible = false;
			dialogueCountNotActivate++;
			storyline();

		}

		private void frmVNFinale_MouseClick(object sender, MouseEventArgs e)
		{
			storyline();
		}
	}
}
