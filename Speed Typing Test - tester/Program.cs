using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;

namespace Speed_Typing_Test___tester
    {
    class Globals
        {
        public static Timer timer = new Timer(30000);
        public static bool stopTimer = false;

        }
    class Program : Globals
        {
        private static List<string> TextList = new List<string>();
        private static Timer minuteTimer = new Timer();
        private static string UserFile = " ";



        static void Main(string[] args)
            {


            List<string> input = new List<string>();
            int randNum = RandomNumber(1, 5);
            string FileName = "story" + randNum.ToString() + ".txt";
            Console.WriteLine("Insturctions: Copy the phrase! Case and punctuation matter. Do try your best :)\n");
            string pathOfFile = Path.GetFullPath(FileName);
            pathOfFile = pathOfFile.Replace(@"\", "/");
            string storyFile = pathOfFile.Replace(@"/bin/Debug/netcoreapp3.1/" + FileName, "/" + FileName);
            string text = System.IO.File.ReadAllText(storyFile);
            System.Console.WriteLine(text);
            Console.WriteLine("\nPress enter to start");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            UserFile = pathOfFile.Replace(@"/bin/Debug/netcoreapp3.1/" + FileName, "/userstext.txt");
            Console.ReadLine();
            DateTime time = DateTime.Now;
            DateTime timeOver = DateTime.Now.AddSeconds(10);
            Console.WriteLine(time.ToString("h:mm:ss tt"));
            Console.WriteLine("You have until");
            Console.WriteLine(timeOver.ToString("h:mm:ss tt"));
            Console.WriteLine("\nPress enter to start");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your 60 seconds starts NOW!!!\n");

            while (time.ToString() != timeOver.ToString())
                {
                if (input.Contains("\b"))
                    {
                    Console.WriteLine("backspace pressed");

                    }
                else
                    { 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    time = DateTime.Now;
                    //Console.WriteLine(time.ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    input.Add((Console.ReadKey().KeyChar).ToString());
                   }
            Console.WriteLine("Time over");
            Console.WriteLine(input);
            Console.ReadKey();






                //        //Console.Clear();

                //        input.Clear();

                //        Console.WriteLine(string.Join(" ", input));
                //        }

                //    else if (!(input.Contains("\b")))
                //        {

                //        Console.ForegroundColor = ConsoleColor.Yellow;
                //       input.Add((Console.ReadKey().KeyChar).ToString());
                //        }
                //    time = DateTime.Now;
                //    }

                //input[input.Count - 1] = "";
                static int RandomNumber(int min, int max)
                {
                Random random = new Random();
                return random.Next(min, max);
                }

            }
        }
    }



            
//Stopwatch s = Stopwatch.StartNew();
//s.Stop();
//Console.WriteLine("Elapsed Time: {0} ms", s.ElapsedMilliseconds);
