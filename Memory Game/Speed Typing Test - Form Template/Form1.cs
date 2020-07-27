using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;


namespace Speed_Typing_Test___Form_Template
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }
        string StoryFile = "";
        
        private void Form1_Load(object sender, EventArgs e)
            {
            TBUserInput.Visible = false;
            globals.RandNum = RandomNumber(1, 6);
            globals.PathOfFile = globals.PathOfFile.Replace(@"\", "/");
            StoryFile = globals.PathOfFile.Replace(@"/bin/Debug/" + globals.FileName, "/" + globals.FileName);
            TBStory.Text = File.ReadAllText(StoryFile);
            }

        private static int RandomNumber(int min, int max)
            {
            Random random = new Random();
            return random.Next(min, max);
            }

        private void BTStart_Click(object sender, EventArgs e)
            {
            BTStart.Visible = false;
            LBdisplay.Text = "Your 60 seconds starts NOW!!!";
            //DateTime time = DateTime.Now;
            //DateTime timeOver = time.AddSeconds(30);
            TBUserInput.Visible = true;
            TBUserInput.ReadOnly = false;
            Timer timer1 = new Timer
                {
                Interval = 20000
                };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            TBUserInput.Focus();

            }
        public static class globals
        {
            public static int TimesRan = 0;
            public static int RandNum = RandomNumber(1, 6);
            public static string FileName = "story" + RandNum.ToString() + ".txt";
            public static string PathOfFile = Path.GetFullPath(FileName);

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
        }

    
    }
    
