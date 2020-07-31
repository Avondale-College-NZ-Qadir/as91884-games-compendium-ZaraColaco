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
            timer1.Tick += new System.EventHandler(OnTimerEvent);//when times up proceed to timer event called OnTimerEvent
            TBUserInput.Focus();//Focuses users cursor in the user input text box

            }

        public void OnTimerEvent(object sender, EventArgs e)//method for timer event
            {
            TBUserInput.ReadOnly = true;// when times up user text box is set to readonly
            LBdisplay.Text = "Time's up!!!";//Display label text is changed to "Time's up!!!"
            if (globals.TimesRan == 0)// if the number of times ran is zero then do this...
                    {
                BTScore.Visible = true;//shows the score button
                    }

            }

        private void BTScore_Click(object sender, EventArgs e)//Score button click event
            {
            globals.TimesRan++;//incriments counter increasing the number of times ran
            string userFile = globals.PathOfFile.Replace(@"/bin/Debug/" + globals.FileName, "/userstext.txt");//changes the path to get the path for the users file and stores ina string variable called userFile
            TextWriter txt = new StreamWriter(userFile);//new streamwriter created ot write the users typing into a file
            txt.Write(TBUserInput.Text);// stores what the user typed in a text file called userstext.txt
            txt.Close();// closes the text file after added the user's information
            BTScore.Visible = false;//Hides the score button
            char[] charSeparators = new char[] { ' ', '\r', '\t', '\n' };//separates the text at spaces, new line characters, tab and Line Feed in a character array
            string[] storyArray = TBStory.Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);// splits the user's text and removes the empty entries then stores it in a string array called storyArray
            string[] answerArray = TBUserInput.Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);// splits the story and removes the empty entries then stores it in a string array called answerArray
            List<string> storyList = new List<string>(storyArray.ToList());//Takes the Answer array called Answerarray and puts it in a list called storyList
            List<string> userStoryList = new List<string>(answerArray.ToList());//Takes the users text array called story array and puts it in a list called storyList
            List<string> resultList = storyList.Except(userStoryList).ToList();//Compares the values of the two lists 
            int storywords = storyList.Count();// int variable counting the lenghth of the story list
            resultList.Clear();// clears the results list
            for (int i = 0; i < storywords && i < (userStoryList.Count()); i++) //for loop for when the counter is less than the length of the storyList and  less than the length of the userStoryList.Then incriments the i  counter
            {

                    if (storyList[i] == userStoryList[i]) // if each corresponding element of both lists match up or basically for every word thats correct...
                    {
                        resultList.Add(storyList[i]);//add that element form the story list to the results list
                        
                    }
                    else //else break and come out of loop
                    {
                    break;
                       
                    }
             }
            float correctWords = resultList.Count();// float varibale called correct words to count the items in the resultsList
            float score = (correctWords) / (storywords) * 100;//float variable called score calculates the percentage of completion by diving the amount of correctwords by the amount of storywords and then mulitplying it by 100
            scoreLabel.Text = correctWords + "WPM        completion: " + score.ToString("0.00") + "%";//The text of the score label is set to displaying the score in WPM and the percentage of completion to 2d.p
            scoreLabel.Visible = true;// displays the score label
            }

        private void BTreturn_Click_1(object sender, EventArgs e)// return button click event
        {
        this.Hide();// hides the form
        globals.ValueSetter();// calls ValueSetter method
        }

        private void TypingTestForm_FormClosing(object sender, FormClosingEventArgs e)//Form closing event
        {
            GamesCompendium.MenuForm mf = new GamesCompendium.MenuForm();//local varible called mf with the menu form
            this.Hide();//Hides typing test form
            mf.Show();// displays the menu form
        }
    }

    public static class globals//globals class
        {
        public static int TimesRan = 0;// global integer variable called TimesRan
        public static int RandNum = RandomNumber(1, 6);// global integer variable called RandNum
        public static string FileName = "story" + RandNum.ToString() + ".txt";//Global string variable called Filename stores story plus the random number plus .txt For Example: story1.txt
        public static string PathOfFile = Path.GetFullPath(FileName);//Global string variable called PathofFile finds the path of filename and stores it in here

        public static void ValueSetter()//Method called ValueSetter to reset specific variables for when the form is selected from the menu
        { 
        TimesRan = 0;// TimesRan is set back to 0
        RandNum = RandomNumber(1, 6);//runs method again for new random number
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
    
