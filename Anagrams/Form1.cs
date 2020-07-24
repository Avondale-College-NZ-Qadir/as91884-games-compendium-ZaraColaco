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
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            TBUser.Visible = false;
            
            }

        private void BTstart_Click(object sender, EventArgs e)
            {
            BTstart.Visible = false;
            label1.Visible = true;
            label1.Text = "Your 60 seconds starts NOW!";
            TBLetters.Text = "N     A     R     S     E     W";
            TBUser.Visible = true;
            TBUser.ReadOnly = false;
            Timer timer1 = new Timer
                {
                Interval = 20000
                };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            TBUser.Focus();
            TBUser.Text.ToLower();
            string answer = TBUser.Text.ToLower();
            answer.Split('\n');
            globals.ListUsersAnswers.Add(answer);

            }
        public void OnTimerEvent(object sender, EventArgs e)
            {
            TBUser.ReadOnly = true;
            label1.Text = "Time's up!!!";
            //TextWriter txt = new StreamWriter(UserFile);

            }

        private void BTscore_Click(object sender, EventArgs e)
            {
            string fileName = "Answers.txt";
            string pathOfFile = Path.GetFullPath(fileName);
            string userFile = pathOfFile.Replace(@"/bin/Debug/" + fileName, "/" + fileName);
            string correctAnswers = File.ReadAllText(userFile);

            Char[] newArray  = correctAnswers.ToArray();
            globals.LIST_CORRECT_ANSWERS = newArray.ToList();
            correctAnswers.ToList();
            int ctr = 0;
            for (int i = 0; i < storyList.Count && i < globals.ListUsersAnswers.Count; i++)
                {
                if (globals.ListUsersAnswers[i] == List[i])

                    {
                    ctr++;
                    }
                else
                    {
                        {
                        scoreLabel.Visible = true;
                        scoreLabel.Text = "You scored: " + ctr;
            }
        }
    public static class globals
        {
        public static List<string> ListUsersAnswers = new List<string>();
        public static List<Char> LIST_CORRECT_ANSWERS = new List<Char>();


        }
    }

  