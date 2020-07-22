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
            string answer = Console.ReadLine().ToLower();
            globals.ListUsersAnswers.Add(answer);

            }
        public void OnTimerEvent(object sender, EventArgs e)
            {
            TBUser.ReadOnly = true;
            label1.Text = "Time's up!!!";
            //TextWriter txt = new StreamWriter(UserFile);

            }

        }
    public static class globals
        {
        public static List<string> ListUsersAnswers = new List<string>();
        public static List<string> LIST_CORRECT_ANSWERS = new List<string> { "d", "a", "b", "d", "c", "b", "d", "a", "c", "c", "d", "b" };
        }
    }

  