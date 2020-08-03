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
            globals.Phrases.Add("How much wood would a woodchuck chuck if a woodchuck could chuck wood?");
            globals.Phrases.Add("Silly Sally swiftly shooed seven silly sheep");
            globals.Phrases.Add("Peter Piper picked a peck of pickled peppers.A peck of pickled peppers Peter Piper picked");
            globals.Phrases.Add("I wish to wish the wish you wish to wish");
            globals.Phrases.Add("She sells sea shells by the seashore");
            globals.RandNum = globals.RandomNumber(0, 5);//runs RandomnNumber method which gets a Random number between 1 and 5 inclusive and stores it in an integer variable called RandNum
        }

        private void BTStart_Click(object sender, EventArgs e)
        {
            BTStart.Visible = false;
            TBText.Visible = true;
            TBText.Text = globals.Phrases[globals.RandNum];
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
            globals.ValueSetter();// calls ValueSetter method

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
        public static int RandNum = RandomNumber(1, 5);
        public static List<string> Phrases = new List<string>();// List storing all 5 possible phrases
        public static void ValueSetter()//Method called ValueSetter to reset specific variables for when the form is selected from the menu
        {
            TimesRan = 0;// TimesRan is set back to 0
        }
            public static int RandomNumber(int min, int max)// method for a Random number
        {
            Random Random = new Random();// randomn varibale called Random
            return Random.Next(min, max);// returns a Random number between 1 and 5 inclusive
        }
    }
}
