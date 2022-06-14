using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 777;
            Console.WriteLine($"Guess my favorite number. The only hint is to think about casinos!");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput < favoriteNumber)
            {
                Console.WriteLine($"Too low!");
            }
            else if (userInput > favoriteNumber)
            {
                Console.WriteLine($"Too high!");
            }

            else if (userInput == favoriteNumber)
            {
                Console.WriteLine($"You are correct, here is your jackpot");

            }

            else
            {
                Console.WriteLine($"Nevermind.");
            }


            Console.WriteLine($"What's your favorite school subject?");
            var response = Console.ReadLine();
            switch (response)
            {
                case "math":
                    Console.WriteLine($"Math is a tough subject!");
                    break;
                case "english":
                    Console.WriteLine($"English is a grammatically correct subject.");
                    break;
                case "science":
                    Console.WriteLine($"Science is a suject that helps you understand the world!");
                    break;
                case "gym":
                    Console.WriteLine($"Gym class!! I am to out of shape for that class!");
                    break;
                case "computer":
                    Console.WriteLine($"Computers are a hard subject to learn but very rewarding to gain knowledge in!");
                    break;
                default:
                    Console.WriteLine($"Never heard of that one. Tell me more about this subject.");
                    break;
            }





        }
    }
}
