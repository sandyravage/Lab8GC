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

        private static string[][] students = {new string[] {"Stephanie... I... I think","Pizza","Meming","the Northern Flicker"},
                new string[] {"Tracy McAllistair", "Chicken", "Surfing","the Eastern Wild Turkey"},
                new string[] {"Topher-B", "Jelly Beans", "Pumpkin Carving","the Boops Boops"}, 
                new string[] {"Yolsworth Pennymoney", "Defeat", "Lawn Bowling","the Nene"},
                new string[] {"Yeezus", "the YAMS", "Coin Collecting","the Cockroach"},
                new string[] {"Geoff Diggum", "The Sun's Rays", "Drinking","a slightly rumpled paper plane"},
                new string[] {"El Tigre", "Pocket Lint", "Stealing Stop Signs","Mother Russia"},
                new string[] {"XV889", "Pineapple Upside-Down Cake", "Chiropracty","the penguin"},
                new string[] {"Yousif", "Phytoplankton", "Yeezus","Giraffe"},
                new string[] {"[B]eter", "Protein Bars/Muscle Milk", "Chainsaw Juggling","Air Force 1"},
                new string[] {"XWing@Aliciousness", "The Void", "defeating the enemy","flying Gatorade Caps"},
                new string[] {"Newt Gingrich", "Infinite Loops", "defending his country","the noble house fly"},
                new string[] {"Steve(2)", "Canada", "Ego tripping at the edge of the universe","[INSERT BIRD]"} };

        static void Main()
        {
            Console.Write("Welcome to our C# class. Which student " +
                "would you like to learn more about? (Enter a number between " +
                "1-13):");

            Prompter();

            Console.WriteLine("\nStudent {0} is {1}. What would you like to know about {1}? " +
                "(enter a choice or \"options\" for available options):", student + 1, students[student][0]);

            SearchConverter();

        }
        static void SearchConverter()
        {
            decision = 0;
            string choice = "";
            Console.WriteLine("");
            choice = Console.ReadLine().ToString().ToLower();
            if (choice == "favorite food") 
            {
                decision = 1;
                Console.WriteLine("\n{0}'s favorite food is {1}.", students[student][0], students[student][decision]);
                AskAgain();
            }
            else if(choice == "favorite pass-time")
            {
                decision = 2;
                Console.WriteLine("\n{0}'s favorite pass-time is {1}.", students[student][0], students[student][decision]);
                AskAgain();
            }
            else if (choice == "favorite state bird")
            {
                decision = 3;
                Console.WriteLine("\n{0}'s favorite state bird is {1}.", students[student][0], students[student][decision]);
                AskAgain();
            }
            else if (choice == "options")
            {
                Console.WriteLine("\nEnter \"favorite food\", \"favorite pass-time\", or \"favorite state bird\"");
                SearchConverter();
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
            Console.WriteLine("");
            try
            {
                choice1 = Int32.Parse(Console.ReadLine()) - 1;
            }
            catch(Exception)
            {
                Console.WriteLine("Not even a number bud.");
                Prompter();
            }
            if (choice1 < students.Length && choice1 >= 0)
            {
                student = choice1;
            }
            else
            {
                Console.WriteLine("There are only 13 students in the class. Please try again\n");
                Prompter();
            }
        }
        static void AskAgain()
        {
            string choice2 = "";
            Console.WriteLine("\nWould you like to know anything " +
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
                "(enter a choice or \"options\" for available options)",students[student][0]);
            SearchConverter();
        }
        static void Repeat()
        {
            string choice3 = "";
            Console.WriteLine("\nWould you like to know about another student? (\"y\" for yes " +
                "or anything else to exit program\n)");
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
