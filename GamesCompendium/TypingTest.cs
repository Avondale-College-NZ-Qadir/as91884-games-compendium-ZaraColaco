using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;


namespace Speed_Typing_Test___Form_Template
    {
    public partial class TypingTestForm : Form
        {
        public TypingTestForm()
            {
            InitializeComponent();
            }
        
        private void TypingTestForm_Load(object sender, EventArgs e)// Form load event
            {
            TBUserInput.Visible = false;//Hides the text box for user input
            globals.RandNum = globals.RandomNumber(1, 6);//runs RandomnNumber method which gets a random number between 1 and 5 inclusive and stores it in an integer variable called RandNum
            globals.PathOfFile = globals.PathOfFile.Replace(@"\", "/");//Replaces the back slashes with forward slashes in the path of the story file
            string storyFile = globals.PathOfFile.Replace(@"/bin/Debug/" + globals.FileName, "/" + globals.FileName);// stores the path of the story file in a string variable and replaces the extras in the file path with just the file name of the story          
            TBStory.Text = File.ReadAllText(storyFile);//Reads the text from the story file and dsiplays it in the story text box
            }

        private void BTStart_Click(object sender, EventArgs e)//Start button click event
            {
            BTStart.Visible = false;// Hides the start button
            LBdisplay.Text = "Your 60 seconds starts NOW!!!";//Sets the text of the display label to this
            TBUserInput.Visible = true;// Displays the text box for user input
            TBUserInput.ReadOnly = false;//Disables readonly on the user text box
            Timer timer1 = new Timer//new timer
                {
                Interval = 60000// timer runs for 60 seconds
                };
            timer1.Enabled = true;//Starts the timer
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            TBUserInput.Focus();

            }

        public void OnTimerEvent(object sender, EventArgs e)
            {
            TBUserInput.ReadOnly = true;
            LBdisplay.Text = "Time's up!!!";
            if (globals.TimesRan == 0)
                    {
                BTScore.Visible = true;
                    }

            }

        private void BTScore_Click(object sender, EventArgs e)
            {
            globals.TimesRan++;
            string userFile = globals.PathOfFile.Replace(@"/bin/Debug/" + globals.FileName, "/userstext.txt");
            TextWriter txt = new StreamWriter(userFile);
            txt.Write(TBUserInput.Text);
            txt.Close();
            BTScore.Visible = false;
            char[] charSeparators = new char[] { ' ', '\r', '\t', '\n' };
            string[] storyArray = TBStory.Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            string[] answerArray = TBUserInput.Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            List<string> storyList = new List<string>(storyArray.ToList());
            List<string> userStoryList = new List<string>(answerArray.ToList());
            List<string> resultList = storyList.Except(userStoryList).ToList();
            int storywords = storyList.Count();
            resultList.Clear();
            for (int i = 0; i < storywords && i < (userStoryList.Count()); i++)
                {

                    if (storyList[i] == userStoryList[i]) 
                    {
                        resultList.Add(storyList[i]);
                        
                    }
                    else 
                    {
                    break;
                       
                    }
             }
            float correctWords = resultList.Count();
            float score = (correctWords) / (storywords) * 100;
            scoreLabel.Text = correctWords + "WPM        completion: " + score.ToString("0.00") + "%";
            scoreLabel.Visible = true;
            }

        private void BTreturn_Click_1(object sender, EventArgs e)
        {
        this.Hide();
        globals.valueSetter();
        }

        private void TypingTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GamesCompendium.MenuForm mf = new GamesCompendium.MenuForm();
            this.Hide();
            mf.Show();
        }
    }

    public static class globals
        {
        public static int TimesRan = 0;
        public static int RandNum = RandomNumber(1, 6);
        public static string FileName = "story" + RandNum.ToString() + ".txt";
        public static string PathOfFile = Path.GetFullPath(FileName);

        public static void valueSetter()
        { 
        TimesRan = 0;
        RandNum = RandomNumber(1, 6);
        FileName = "story" + RandNum.ToString() + ".txt";
        PathOfFile = Path.GetFullPath(FileName);
        
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
    
    }
    
