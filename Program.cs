using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
            Console.ReadLine();

        }

        static void Game()
        {
            string play = "Y";

            while (play == "Y")
            {
                NumberGame();

                Console.WriteLine("Press Y to continue and N to exit.");
                play = Console.ReadLine().ToUpper();
            }
        }

        static void NumberGame()
        {
            const int maxattempts = 3;

            int numToGuess, userGuess, userAttempts;
            bool win = false;

            Random rand = new Random();

            numToGuess = rand.Next(0, 100);
            userAttempts = 1;

            Console.WriteLine("Guessing Game!");


            while (userAttempts <= maxattempts)
            {
                Console.WriteLine("Enter your guess between 0 and 100: ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == numToGuess)
                {
                    Console.WriteLine($"You've won! You guessed the number in {userAttempts} attempts");
                    win = true;
                    break;
                }

                else if (userGuess > numToGuess)
                    Console.WriteLine("Too High");

                else
                    Console.WriteLine("Too Low");

                userAttempts++;
            }

            if (win != true)
                Console.WriteLine("You've used up all attempts, You Lose!");
        }



    }
}
