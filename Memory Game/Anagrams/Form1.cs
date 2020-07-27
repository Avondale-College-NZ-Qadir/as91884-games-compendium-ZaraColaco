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
                Interval = 60000
                };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            TBUser.Focus();
            

            }
        public void OnTimerEvent(object sender, EventArgs e)
            {
            TBUser.ReadOnly = true;
            label1.Text = "Time's up!!!";
            if (globals.TimesRan == 0)
                {
                BTscore.Visible = true;
                }


            }

        private void BTscore_Click_1(object sender, EventArgs e)
            {
            string [] answer = TBUser.Text.ToLower().Split('\n');
            List<string> listUsersAnswers = new List<string>(answer.ToList().Distinct());
            string fileName = "Answers.txt";
            string pathOfFile = Path.GetFullPath(fileName);
            pathOfFile = pathOfFile.Replace(@"\", "/");
            string answerFile = pathOfFile.Replace(@"/bin/Debug/" + fileName, "/" + fileName);
            List<string> lines = File.ReadLines(answerFile).ToList();
            //var correctAnswers = File.ReadAllLines(answerFile);
            //string []correctAns = correctAnswers.Split('\n');
            //var LIST_CORRECT_ANSWERS = new List<string>(correctAnswers.ToList()); 
            //Char[] newArray  = correctAnswers.ToArray();
           // globals.LIST_CORRECT_ANSWERS = newArray.ToList();
            //correctAnswers.ToList();
            int ctr = 0;
            for (int i = 0; i < listUsersAnswers.Count; i++)
                {
                if (lines.Contains(listUsersAnswers[i]))
                    {
                    ctr++;
                    }
                }
            scoreLabel.Visible = true;
            scoreLabel.Text = "You scored: " + ctr;
        }

    public static class globals
        {
        public static int TimesRan = 0;
        }

        private void BTreturn_Click(object sender, EventArgs e)
        {

        }
    }
}

  