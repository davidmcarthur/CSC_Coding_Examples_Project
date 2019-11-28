using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    public class GuessingGame
    {


        public static void Main(string[] args)
        {
            // Computer to choose a number between 0 and 100
            int num = new Random().Next(101);
            int guess = 0;
            bool wrongGuess = true;

            while (wrongGuess)
            {
                // get user input
                // check input against num
                Console.WriteLine("input a number between 1 and 100");
                guess = Convert.ToInt32(Console.ReadLine());
                if(guess < num)
                    Console.WriteLine($"Your guess {guess} was too low");
                if(guess > num)
                    Console.WriteLine($"Your guess {guess} was too high");
                if (guess == num)
                {
                    Console.WriteLine("You guessed correctly");
                    wrongGuess = false;
                }
            }

        }
        // user guesses the number

        // for every guess the program will check to see if you've won

        // each guess the program will tell you if you're too high
        // or too low

        
    }
}

