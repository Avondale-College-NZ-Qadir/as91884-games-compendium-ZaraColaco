using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anagrams
    {
    public partial class AnagramsForm : Form
        {
        public AnagramsForm()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)//form load event
            {
            TBUser.Visible = false;//Displays the user's text box for input
            
            }

        private void BTstart_Click(object sender, EventArgs e)//start button click event
            {
            TBLetters.Visible = true;//Displays the text box for Letters in the game
            BTstart.Visible = false;//Hides the start button on click
            LBPrompts.Visible = true;// displays a blank label
            LBPrompts.Text = "Your 60 seconds starts NOW!";//sets the text of the blank label
            TBLetters.Text = "R     A     N     S     W     E";// Populates the text box with these letters
            TBUser.Visible = true;//Displays the user's text box for input
            TBUser.ReadOnly = false;// Allows user to input into the text box
            Timer timer1 = new Timer//timer
                {
                Interval = 60000// timer for 60 seconds
                };
            timer1.Enabled = true;// starts the time
            timer1.Tick += new System.EventHandler(OnTimerEvent);// when times up it calls the following method
            TBUser.Focus();// focuses the users cursor in the user text box
            

            }
        public void OnTimerEvent(object sender, EventArgs e)// method for after 60 seconds is up
            {
            TBUser.ReadOnly = true;//Disallows input into the users text box
            LBPrompts.Text = "Time's up!!!";// Changes the text of the prompt label to this
            if (globals.TimesRan == 0)// loop with counter since timer runs in background incriments counter after every 60 seconds and only after the first time will it do this
                {
                BTscore.Visible = true;// displays the score label
                }

            }

        private void BTscore_Click_1(object sender, EventArgs e)//score button click event
            {
            string [] answer = TBUser.Text.ToLower().Split('\n');// string array storing the users typing and coverting all the characters to lower case. Splits each word at enter.
            List<string> listUsersAnswers = new List<string>(answer.ToList().Distinct());//List for users answers, adds all the answers from the string array that are unique/ no double ups
            string fileName = "Answers.txt";// string storing the file name of the answe file
            string pathOfFile = Path.GetFullPath(fileName);// gets the path of the file and stores in a string called pathOfFile
            pathOfFile = pathOfFile.Replace(@"\", "/");// replaces all the backslashes in the file with forward slashes
            string answerFile = pathOfFile.Replace(@"/bin/Debug/" + fileName, "/" + fileName);// adds the file name to the path to get the exact path of the answer file
            List<string> answers = File.ReadLines(answerFile).ToList();// reads the answers form the file and stores in a list called answers
            int ctr = 0;// new counter
            for (int i = 0; i < listUsersAnswers.Count; i++)//for loop for when the counter is less than the length of the users answers list and then incriments the i  counter
                {
                if (answers.Contains(listUsersAnswers[i]))// if the correct answers list contains the answers in the users list
                    {
                    ctr++;// score counter incriments 
                    }
                }
            scoreLabel.Visible = true;// Displays the score label
            scoreLabel.Text = "You scored: " + ctr + " out of 79";// sets the text for the score label ctr is the score
        }

        private void BTreturn_Click(object sender, EventArgs e)//Return to menu button click event
        {
            this.Hide();// Hides the form
            globals.TimesRan = 0; // resets variable to 0 for future rounds
        }

        public static class globals//globals class for global variables
        {
            public static int TimesRan = 0;//Integer variable to calculate how many times the timer runs
        }

        private void AnagramsForm_FormClosing(object sender, FormClosingEventArgs e)//For closing event
        {
            GamesCompendium.MenuForm mf = new GamesCompendium.MenuForm();//returns to the menu form
            this.Hide();//hides this form
            mf.Show();//displays the menu form
        }
    }
}

  