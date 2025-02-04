using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int correctNum = ran.Next(1, 11);

            int maxGuess = 3;
            int guessLeft = maxGuess;

            while (guessLeft != 0)
            {
                Console.Write("Enter your Guess: ");
                int guessNum;
                if (!int.TryParse(Console.ReadLine(), out guessNum) && guessNum >= 1 && guessNum <= 10)
                {
                    Console.WriteLine("Enter a valid number.");
                }
                else
                {
                    if (Math.Abs(guessNum - correctNum) >= 3)
                    {
                        Console.WriteLine("COLD");
                    }
                    else if (Math.Abs(guessNum - correctNum) == 2)
                    {
                        Console.WriteLine("WARM");
                    }
                    else if (Math.Abs(guessNum - correctNum) == 1)
                    {
                        Console.WriteLine("HOT");
                    }
                    else
                    {
                        Console.WriteLine("Congratulation! You guessed the correct number.");
                        return;
                    }
                }
                guessLeft--;
            }

            Console.WriteLine("You failed to guess the correct number.");
            Console.WriteLine("The correct number was " + correctNum);
            Console.WriteLine("Better Luck Next Time!.");
            
        }
    }
}
