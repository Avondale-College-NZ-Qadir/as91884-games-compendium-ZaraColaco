using System;
using System.Timers;

namespace GamePortal__inital_planning_and_trialing
    {
    class Program
        {
        static void Main(string[] args)
            {
            // Create a timer with a one minute interval.
            Timer aTimer = new System.Timers.Timer(60000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            Console.ReadKey();

            }
        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
            
            }


        }
    }
