using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class MemoryGameForm : Form
    {
        public MemoryGameForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TBUser.Visible = false;
            TBText.Visible = false;
            BTscore.Visible = false;
        }

        private void BTStart_Click(object sender, EventArgs e)
        {
            BTStart.Visible = false;
            TBText.Visible = true;
            TBText.Text = "How much wood would a woodchuck chuck if the woodchuck could chuck wood?";
            Timer timer1 = new Timer
            {
                Interval = 5000
            };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            TBUser.Focus();


        }
        public void OnTimerEvent(object sender, EventArgs e)
        {
            TBUser.Visible = true;
            TBUser.ReadOnly = false;
            TBUser.Focus();
            if (globals.TimesRan == 0)
            {
                TBText.Visible = false;
                BTscore.Visible = true;
            }
        }

        private void BTscore_Click(object sender, EventArgs e)
        {
            globals.TimesRan++;
            TBText.Visible = true;
            if (TBText.Text.ToLower() == TBUser.Text.ToLower())
            {
                LBscore.Text = "You win!";
            }
            else
            {
                LBscore.Text = "You Loose!";
            }
            LBscore.Visible = true;
        }

        private void BTReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MemoryGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GamesCompendium.MenuForm mf = new GamesCompendium.MenuForm();
            this.Hide();
            mf.Show();

        }

    }
    public static class globals
    {
        public static int TimesRan = 0;
    }
}
