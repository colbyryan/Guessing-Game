using System;
using System.Collections.Generic;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNumber = new Random().Next(1, 101);

            void AskUser()
            {

                Console.WriteLine("Choose difficulty Level! 1 - easy, 2 - medium, 3 - hard, 4 - cheater");
                int difficulty = int.Parse(Console.ReadLine());

                var numberOfGuesses = new int[] { 8, 6, 4, 1 }[difficulty - 1];

                while (difficulty == 4 || numberOfGuesses > 0)
                {
                    string guessesLeft = difficulty == 4 ? "INFINITE" : numberOfGuesses.ToString();
                    Console.WriteLine("Can you guess the Secret Number?");
                    Console.WriteLine($"Remaining Guesses: ({guessesLeft})");
                    int answer = int.Parse(Console.ReadLine());

                    if (answer == secretNumber)
                    {
                        Console.WriteLine("Got it!");
                        break;
                    }
                    else if (secretNumber > answer)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine("Too High!");
                    };
                    numberOfGuesses--;
                }
            }

            AskUser();

        }
    }
}
