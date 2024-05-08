using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallOfTheShinigami.frmGameVN;
using static System.Net.Mime.MediaTypeNames;

namespace CallOfTheShinigami
{
	public partial class frmAttacking : Form
	{
		private Player player;
		private int monsterHealth;
		private int monsterMaxDamage;
		private int monsterMinDamage;
		private bool isDefended = false;
		private Form previousForm;
		private int expAdded = 0;
		private string monsterName;
		public frmAttacking(Player player, string monster, Form frmRPG)
		{
			InitializeComponent();
			monsterName = monster;
			this.player = player;
			this.previousForm = frmRPG;
			prgCharacter.Maximum = player.MaxHealth;
			prgCharacter.Value = player.Health;
			if (monster == "Gluttony Minion" )
			{
				monsterHealth = 40;
				monsterMaxDamage = 15;
				monsterMinDamage = 10;
				picEnemy.Size = new Size(250, 250);
				picEnemy.Image = Properties.Resources.LittleGluttonyEnemy;
				expAdded = 50;
			} else if (monster == "Bigger Gluttony Minion")
			{
				monsterHealth = 100;
				monsterMaxDamage = 25;
				monsterMinDamage = 15;
				picEnemy.Image = Properties.Resources.BiggerGluttonyDemon;
				picEnemy.Size = new Size(400, 400);
				picEnemy.Location = new Point(200,100);
				expAdded = 100;
			} else if (monster == "Beelzebub")
			{
				monsterHealth = 1000;
				monsterMaxDamage = 40;
				monsterMinDamage = 20;
				picEnemy.Image = Properties.Resources.Beelzebub;
				picEnemy.Size = new Size(400, 400);
				picEnemy.Location = new Point(200, 100);
				expAdded = 500;
				txtComment.Text += "You dare challenge me lost soul?";
			}
			prgEnemy.Maximum = monsterHealth;
			prgEnemy.Value = monsterHealth;
			lblCharacterHealth.Text = prgCharacter.Value.ToString() + "/" + prgCharacter.Maximum.ToString();
			lblEnemyHealth.Text = prgEnemy.Value.ToString() + "/" + prgEnemy.Maximum.ToString();
			lblEnemyName.Text = monster;
		}
		private bool playerTurn = true;

		private void enemyAttack()
		{

			int damage = new Random().Next(monsterMinDamage, monsterMaxDamage);
			if (isDefended == true)
			{
				if (prgCharacter.Value - damage/2 <= 0)
				{
					this.Hide();
					frmGameOver GameOver = new frmGameOver();
					GameOver.ShowDialog();
				} else
				{
					prgCharacter.Value -= damage/2;
				}
			} else
			{
				if (prgCharacter.Value - damage <= 0)
				{
					this.Hide();
					frmGameOver GameOver = new frmGameOver();
					GameOver.ShowDialog();
				}
				else
				{
					prgCharacter.Value -= damage;
				}
			}
			txtComment.Text += "\r\nEnemy Damaged For: " + damage;
			lblCharacterHealth.Text = prgCharacter.Value.ToString() + "/" + prgCharacter.Maximum.ToString();
			playerTurn = true;
			cmdAttack.Enabled = true;
			cmdDefend.Enabled = true;
			cmdHeal.Enabled = true;
		}

		private void cmdAttack_Click(object sender, EventArgs e)
		{
			if (playerTurn)
			{
				int damage = new Random().Next((((player.WeaponAttackPower + player.AttackPower) * 2) + 5), (((player.WeaponAttackPower + player.AttackPower) * 2) + 10));

				if (monsterHealth - damage <= 0 && monsterName != "Beelzebub")
				{
					player.ChangeHealth(prgCharacter.Value);
					player.AddExperience(expAdded);
					frmGameRPG.isAttacking = false;
					this.Close();
				}
				else if (monsterHealth - damage <= 0 && monsterName == "Beelzebub")
				{
					frmGameRPG.isAttacking = false;
					this.Hide();
					frmVisualNovel2 VN2 = new frmVisualNovel2();
					VN2.ShowDialog();
					this.Close();
				}
				else
				{
					prgEnemy.Value -= damage;
					monsterHealth -= damage;
					txtComment.Text += "\r\nYou Damaged For: " + damage;
					lblEnemyHealth.Text = prgEnemy.Value.ToString() + "/" + prgEnemy.Maximum.ToString();
					playerTurn = false;
					cmdAttack.Enabled = false;
					cmdDefend.Enabled = false;
					cmdHeal.Enabled = false;
					Thread.Sleep(1000);
					enemyAttack();
				}
			}
		}

		private void cmdHeal_Click(object sender, EventArgs e)
		{
			if (playerTurn)
			{
				int heal = new Random().Next(((player.AttackPower*player.Level) + 10), ((player.AttackPower*player.Level) + 15));
				if (prgCharacter.Value + heal >= prgCharacter.Maximum)
				{
					prgCharacter.Value = prgCharacter.Maximum;
				}
				else
				{
					prgCharacter.Value += heal;
				}
				lblCharacterHealth.Text = prgCharacter.Value.ToString() + "/" + prgCharacter.Maximum.ToString();
				txtComment.Text += "\r\nYou Healed For " + heal;
				playerTurn = false;
				cmdAttack.Enabled = false;
				cmdDefend.Enabled = false;
				cmdHeal.Enabled = false;
				Thread.Sleep(1000);
				enemyAttack();
			}
		}

		private void cmdDefend_Click(object sender, EventArgs e)
		{
			if (playerTurn)
			{
				isDefended = true;
				txtComment.Text += "\r\nYou Defended";
				playerTurn = false;
				cmdAttack.Enabled = false;
				cmdDefend.Enabled = false;
				cmdHeal.Enabled = false;
				Thread.Sleep(1000);
				enemyAttack();
			}
		}   

		private void frmAttacking_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (monsterName != "Beelzebub")
			{         
				previousForm.Show();
			}
			else
			{
				previousForm.Close();
			}
		}

		private void frmAttacking_Load(object sender, EventArgs e)
		{

		}

	}
}
