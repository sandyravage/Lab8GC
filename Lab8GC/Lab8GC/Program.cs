using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8GC
{
    class Program
    {
        public static int student;
        public static int decision;

        private static string[][] students = {new string[] {"Stephanie","Pizza","Memes","Northern Flicker"},
                new string[] {"Tracy", "Chicken", "Surfing","Eastern Wild Turkey"},
                new string[] {"Chris", "Jelly Beans", "Pumpkin Carving","Lark Bunting"}, 
                new string[] {"Yolosworth", "Defeat", "Lawn Bowling","Nene"},
                new string[] {"Yeezus", "the YAMS", "Coin Collecting","Cockroach"},
                new string[] {"Geoff", "The Sun's Rays", "Drinking","A slightly rumpled paper plane"},
                new string[] {"El Tigre", "Pocket Lint", "Stealing Stop Signs","Russia"},
                new string[] {"XV889", "Pineapple Upside-Down Cake", "Chiropracty","Penguin"},
                new string[] {"Yousif", "Phytoplankton", "Yeezus","Giraffe"},
                new string[] {"[B]eter", "Protein Bars", "Chainsaw Juggling","Air Force 1"},
                new string[] {"XWing@Aliciousness", "The Void", "defeating the enemy","Gatorade Caps"},
                new string[] {"Newt Gingrich", "Infinite Loops", "defending his country","the noble house fly"},
                new string[] {"Steve(2)", "Canada", "Ego tripping at the edge of the universe","[INSERT BIRD]"} };

        static void Main()
        {
            Console.WriteLine("Welcome to our C# class. Which student " +
                "would you like to learn more about? (Enter a number between " +
                "1-13)\n");

            Prompter();

            Console.WriteLine("\nStudent {0} is {1}. What would you like to know about {1}? " +
                "(enter \"favorite food\", \"favorite pass-time\", or \"favorite state bird\"):", student + 1, students[student][0]);

            SearchConverter();

        }
        static void SearchConverter()
        {
            decision = 0;
            string choice = "";
            choice = Console.ReadLine().ToString().ToLower();
            if (choice == "favorite food") 
            {
                decision = 1;
                Console.WriteLine("{0}'s favorite food is {1}.\n", students[student][0], students[student][1]);
                AskAgain();
            }
            else if(choice == "favorite pass-time")
            {
                decision = 2;
                Console.WriteLine("{0}'s favorite pass-time is {1}.\n", students[student][0], students[student][2]);
                AskAgain();
            }
            else if (choice == "favorite state bird")
            {
                decision = 2;
                Console.WriteLine("{0}'s favorite state bird is {1}.\n", students[student][0], students[student][3]);
                AskAgain();
            }
            else
            {
                Console.WriteLine("That's not a valid choice. Please try again.\n");
                SearchConverter();
            }
        }
        static void Prompter()
        {
            int choice1 = 0;
            try
            {
                choice1 = Int32.Parse(Console.ReadLine()) - 1;
            }
            catch(Exception)
            {
                Console.WriteLine("Not valid input. Please try again.");
                Prompter();
            }
            if (choice1 < students.Length && choice1 >= 0)
            {
                student = choice1;
            }
            else
            {
                Console.WriteLine("That wasn't a valid student. Please try again\n");
                Prompter();
            }
        }
        static void AskAgain()
        {
            string choice2 = "";
            Console.WriteLine("Would you like to know anything " +
                "else about this student? (y / n)");
            choice2 = Console.ReadLine().ToString().ToLower();
            if (choice2 == "y")
            {
                Asker();
            }
            else if (choice2 == "n")
            {
                Repeat();
            }
            else
            {
                Console.WriteLine("That's not a valid choice. Please try again");
            }
        }
        static void Asker()
        {
            Console.WriteLine("What would you like to know about {0}?" +
                "(\"favorite food\", \"favorite pass-time\", or \"favorite state bird\"):",students[student][0]);
            SearchConverter();
        }
        static void Repeat()
        {
            string choice3 = "";
            Console.WriteLine("Would you like to know about another student? (\"y\" for yes " +
                "or anything else to exit program)");
            choice3 = Console.ReadLine().ToString().ToLower();
            if(choice3 == "y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
