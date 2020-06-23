using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;     

namespace Speed_Typing_Test___tester
    {
    class Globals
        {
        public static Timer timer = new Timer(60000);
        public static bool stopTimer = false;
        }
    class Program:Globals
        {
        private static List<string> TextList = new List<string>();
        private static Timer minuteTimer = new System.Timers.Timer();
        private static string UserFile = " ";


 
        static void Main(string[] args)
            {
            string input = "";

            int randNum = RandomNumber(1, 5);
            string FileName = "story" + randNum.ToString() +".txt";
            Console.WriteLine("Insturctions: Copy the phrase! Case and punctuation matter. Do try your best :)\n");
            string pathOfFile = Path.GetFullPath(FileName);
            pathOfFile = pathOfFile.Replace(@"\","/");
            string storyFile = pathOfFile.Replace(@"/bin/Debug/netcoreapp3.1/" + FileName , "/" + FileName);
            string text = System.IO.File.ReadAllText(storyFile);
            System.Console.WriteLine(text);
            Console.WriteLine("\nPress enter to start");
            Console.ReadLine(); 
            Console.WriteLine("your 60 seconds starts NOW!!!\n");
            UserFile = pathOfFile.Replace(@"/bin/Debug/netcoreapp3.1/" + FileName, "/userstext.txt");
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        
            while (stopTimer != true)
                {
                input = input + (Console.ReadKey().KeyChar).ToString();
                
                }
            System.IO.File.WriteAllText(UserFile, input);
            Console.WriteLine("\nYou typed: "+ input);
            Console.ReadKey();
          




            //System.IO.File.WriteAllText(pathOfFile , String.Empty);

            //For Later

            //compare, score wpm and accuracy % method, carryon loop, stopping breaks- boundaries., Testing -----> Add to menu

            }
        private static int RandomNumber(int min, int max) 
            {
            Random random = new Random();
            return random.Next(min, max);
            }
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
            {
            // Use SignalTime.
            DateTime time = e.SignalTime;
            Console.WriteLine("\nTIME'S UP!!");
            Console.WriteLine("Press any key to continue");
            stopTimer = true;
            timer.Stop();
            timer.Dispose();


            

            }
        }
    }
     
      
   
