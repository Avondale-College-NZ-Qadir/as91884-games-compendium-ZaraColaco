using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

namespace Speed_Typing_Test___tester
    {
    class Program
        {
        private static List<string> TextList = new List<string>();
        private static string UserText = " ";
        public static Timer minuteTimer = new System.Timers.Timer();
        //System.Timers.Timer minuteTimer 

        //string FileName = " ";
        static void Main(string[] args)
            {
            int randNum = RandomNumber(1, 5);
            string FileName = "story" + randNum.ToString() +".txt";
            Console.WriteLine("Insturctions: Copy the phrase! Case and punctuation matter. Do try your best :)\n");
            string pathOfFile = Path.GetFullPath(FileName);
            pathOfFile = pathOfFile.Replace(@"\","/");
            pathOfFile = pathOfFile.Replace(@"/bin/Debug/netcoreapp3.1/" + FileName , "/" + FileName);
            string text = System.IO.File.ReadAllText(pathOfFile);
            System.Console.WriteLine(text);
            Console.WriteLine("\nPress enter to start");
            Console.ReadLine(); 
            Console.WriteLine("your 60 seconds starts NOW!!!\n");
            minuteTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            minuteTimer.Interval = 6000;
            minuteTimer.Enabled = true;
            bool a = true;
            while (a )
                {
                UserText = Console.ReadLine();
                //Console.WriteLine("hi");
                pathOfFile = pathOfFile.Replace(@FileName, "userstext.txt");
                System.IO.File.WriteAllText(pathOfFile, UserText);
                }
            static void OnTimedEvent(object source, ElapsedEventArgs e)
                {
                Console.WriteLine("TIME'S UP!!");
                minuteTimer.Enabled = false;
                minuteTimer.Dispose();
                a = false;

                }



            //System.IO.File.WriteAllText(pathOfFile , String.Empty);

            //For Later

            //compare, score wpm and accuracy % method, carryon loop, stopping breaks- boundaries., Testing -----> Add to menu


            Console.ReadKey();




            }
           public static int RandomNumber(int min, int max) 
            {
            Random random = new Random();
            return random.Next(min, max);
            }
          
        }
    }
     
      
   