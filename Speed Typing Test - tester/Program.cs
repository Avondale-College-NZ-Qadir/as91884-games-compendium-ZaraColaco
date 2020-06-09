using System;
using System.Collections.Generic;

namespace Speed_Typing_Test___tester
    {
    class Program
        {
        private static List<string> PHRASES = new List<string>();
        static void Main(string[] args)
            {
            string userPhrase = " ";
            Console.WriteLine("Insturctions: Copy the phrase! Case and punctuation matter. Do try your best :)");
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            PHRASES.Add("Amidst the mists and coldest frosts,With stoutest wrists and loudest boasts.\nHe thrusts his fists against the posts,And still insists he sees the ghosts.");
            PHRASES.Add("Silly Sally swiftly shooed seven silly sheep.\nThe seven silly sheep Silly Sally shooed \nShilly shallied south.\nThese sheep shouldn't sleep in a shack; \nSheep should sleep in a shed.");
            PHRASES.Add("Peter Piper picked a peck of pickled peppers. \nA peck of pickled peppers Peter Piper picked.\nIf Peter Piper picked a peck of pickled peppers?\nWhere's the peck of pickled peppers Peter Piper picked?");
            PHRASES.Add("I wish to wish the wish you wish to wish,\nbut if you wish the wish the witch wishes,\nI won't wish the wish you wish to wish.");
            PHRASES.Add("A tutor who tooted the flute tried to tutor two tooters to toot.\nSaid the two to the tutor, 'Is it harder to toot or to tutor two tooters to toot ?'");
            for (int i = 0; i < PHRASES.Count; i++)
                {
                Console.WriteLine("\n" + PHRASES[i] + "\n");
                userPhrase = Console.ReadLine();

                }
            }
    }   }
