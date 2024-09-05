using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string userChoice;
            do
            {
                // Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Print Numbers");
                Console.WriteLine("2. Guessing Game");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintNumbers();
                        break;
                    case "2":
                        GuessingGame();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again");
                        break;
                }

                do
                {
                    // Console.Clear();
                    Console.WriteLine("Do you want to play again? (yes/no)");
                    userChoice = Console.ReadLine().ToLower();

                    if (userChoice == "no")
                    {
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                    }
                    else if (userChoice != "yes" && userChoice != "no")
                    {
                        Console.WriteLine("Invalid option, please try again.");
                    }
                } while (userChoice != "yes" && userChoice != "no");

            } while (userChoice == "yes");
        }

        static void PrintNumbers()
        {
            // Console.Clear();
            Console.WriteLine("Enter your start number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your end number");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Printing numbers...");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }    
        }

        static void GuessingGame()
        {
            Console.WriteLine("Guessing game...");
            Random myRand = new Random();
            int randomNum = myRand.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses += 1;

                if(result == randomNum.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            } while (incorrect == true);
            Console.WriteLine($"Correct! It took you {guesses} guesses");
        }
    }
}
