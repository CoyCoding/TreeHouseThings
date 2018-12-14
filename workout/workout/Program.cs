using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace workout
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            HandleInput();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome To the Workout App");
            Console.WriteLine("------------------------------------");     
        }

        private static void HandleInput(int totalMinutes = 0)
        {
            Console.WriteLine("How many minutes have you exercised? (Type exit to exit)");

            var inputMinutes = Console.ReadLine();

            if(inputMinutes.ToLower() == "exit")
            {
                FinalTime(totalMinutes);
                return;
            }

            if (int.TryParse(inputMinutes, out int minutes))
            {
                totalMinutes += minutes;
                Console.WriteLine("You have exercised a total of " + totalMinutes + " minutes");
                HandleInput(totalMinutes);
            }
            else
            {
                Console.WriteLine(totalMinutes + "is an invalid input.");
                HandleInput(totalMinutes);
            }
        }

        private static void FinalTime(int totalTime)
        {
            Console.WriteLine("Your Final time spent exercising was " + totalTime + " minutes");
            Console.ReadLine();
        }
    }
}
