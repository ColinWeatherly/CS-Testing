using System;

namespace Git_Test_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 1 and 100");
            var rand = new Random();
            int randomNum = Convert.ToInt32(rand.Next(0, 101));
            int guessNum = Convert.ToInt32(Console.ReadLine());
            Program tester = new Program();
            while(tester.guessResult(guessNum, randomNum) == false)
            {
                Console.WriteLine("Try again: ");
                guessNum = Convert.ToInt32(Console.ReadLine());
            }
        }

        bool guessResult(int numGuess, int randomNum)
        {
            if (numGuess < randomNum)
            {
                Console.WriteLine("This number is too low.");
                return false;
            }
            else if (numGuess > randomNum)
            {
                Console.WriteLine("This number is too high.");
                return false;
            }
            else
            {
                Console.WriteLine("Correct! The number was " + randomNum + '.');
                return true;
            }
        }

    }
}
