using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

namespace Speed_Typing_Test___tester
    {
    class Program
        {
        private static List<string> TextList = new List<string>();
        private static string UserText = " ";

        //string FileName = " ";
        static void Main(string[] args)
            {
            int randNum = RandomNumber(1, 5);
            string FileName = "story" + randNum.ToString() +".txt";
            Console.WriteLine("Insturctions: Copy the phrase! Case and punctuation matter. Do try your best :)");
            string text = System.IO.File.ReadAllText(@"C:\Users\ac106503\Source\Repos\as91884-games-compendium-ZaraColaco" + FileName);
            //..\Repos\as91884-games-compendium-ZaraColaco
            System.Console.WriteLine(text);
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            UserText = Console.ReadLine();
            System.IO.File.WriteAllText(@"C:\Users\colac\Source\Repos\as91884-games-compendium-ZaraColaco2\userstext.txt", UserText);




            Console.ReadKey();




            }
           public static int RandomNumber(int min, int max) 
            {
            Random random = new Random();
            return random.Next(min, max);
            }
          
        }
    }
     
      
   