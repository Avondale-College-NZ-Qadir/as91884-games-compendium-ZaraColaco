﻿using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.Linq;
//using System.Timers;
//using Timer = System.Timers.Timer;

namespace Speed_Typing_Test___Form_Template
    {
    public partial class Form1 : Form
        {
        //public static Timer timer = new Timer(30000);
        //public static bool stopTimer = false;
        public Form1()
            {
            InitializeComponent();
            }
        string UserFile = "";
        string StoryFile = "";
        
        private void Form1_Load(object sender, EventArgs e)
            {
            LBdisplay.Text = "";
            TBUserInput.Visible = false;
            int randNum = RandomNumber(1, 5);
            string FileName = "story" + randNum.ToString() + ".txt";
            string pathOfFile = Path.GetFullPath(FileName);
            pathOfFile = pathOfFile.Replace(@"\", "/");
            StoryFile = pathOfFile.Replace(@"/bin/Debug/" + FileName, "/" + FileName);
            TBStory.Text = File.ReadAllText(StoryFile);
            UserFile = pathOfFile.Replace(@"/bin/Debug/" + FileName, "/userstext.txt");
            


  


            }
        private static int RandomNumber(int min, int max)
            {
            Random random = new Random();
            return random.Next(min, max);
            }


        private void TBUserInput_TextChanged(object sender, EventArgs e)
            {

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




            //users cursor position set in TBUserInput
            }
        public void OnTimerEvent(object sender, EventArgs e)
            {
            TBUserInput.ReadOnly = true;
            LBdisplay.Text = "Time's up!!!";
            TextWriter txt = new StreamWriter(UserFile);
            txt.Write(TBUserInput.Text);
            txt.Close();
            BTScore.Visible = true;

            }

        private void timer1_Tick(object sender, EventArgs e)
            {

            }

        private void BTScore_Click(object sender, EventArgs e)
            {
            BTScore.Visible = false;
            string[] test1 = TBStory.Text.Split(' ');
            string[] test2 = TBUserInput.Text.Split(' ');
            var storyList = new List<string> (test1.ToList());
            var responseList = new List<string> (test2.ToList());
            var filter = storyList.Except(responseList);
            firstNotSecond = storyList.Except(responseList);
            //List<string> resultsList = test2.ToList();s
            //int i;
            //for (i in range(len(storyList)))
            //    {
            //    if(storyList[i]>responseList[i])
            //        {
            //        resultsList.Append(1);
            //        }
            //    else
            //        {
            //        resultsList.Append(0);
            //        }

            //    }



            //int ctr = 0;
            //int y = 0;
            //for (int i = 0; i < storyList.Count && i < responseList.Count; i++)
            //    {
            //    if (resultsList[i] == storyList[i])

            //        {
            //        ctr++;
            //        }
            //    else
            //        {
            //        if (resultsList[i] == storyList[i + 1])
            //            {

            //            }
            //        }
            //    }
            }
        }
    }