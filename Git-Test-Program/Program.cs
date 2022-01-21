using System;

namespace Git_Test_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = 0;
            int stopNum = 0;
            while (startNum >= stopNum)
            {
                Console.WriteLine("Enter a starting number: ");
                startNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a stopping number: ");
                stopNum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("I am thinking of a number between " + startNum + " and " + stopNum);
            var rand = new Random();
            int randomNum = Convert.ToInt32(rand.Next(startNum, stopNum + 1));
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
