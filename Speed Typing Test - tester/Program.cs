using System;
using System.Collections.Generic;

namespace Speed_Typing_Test___tester
    {
    class Program
        {
        private static List<string> PHRASES = new List<string>();
        static void Main(string[] args)
            {

            Console.WriteLine("Insturctions: Copy the phrase! Case and punctuation matter. Do try your best :)");
            Console.WriteLine("Press any enter to start");
            Console.ReadLine();
            string text = System.IO.File.ReadAllText(@"C:C:\Users\ac106503\Source\Repos\as91884-games-compendium-ZaraColaco\story4");
            System.Console.WriteLine( text);
           

                }
            }
    }   }
