using System;

namespace CW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string menuChoice;
            Random rnd = new Random();
            
            int num = rnd.Next(1, 100);
            Console.WriteLine("I'm thinking of a number between 1-100\n");
            //Console.WriteLine(num);
            string numGuess;
            Console.WriteLine("Guess the number: ");
            numGuess = Console.ReadLine();
            int res = Convert.ToInt32(numGuess);
            if(res < num)
            {
                Console.WriteLine("Guess a higher number");
            }
            else if(res > num)
            {
                Console.WriteLine("Guess a lower number");
            }
            while(res != num)
            {
                Console.WriteLine("Guess the number: ");
                numGuess = Console.ReadLine();
                res = Convert.ToInt32(numGuess);
                Console.WriteLine("Try again...\n");
                //Console.WriteLine(num);
                if (res < num)
                {
                    Console.WriteLine("Guess a higher number");
                }
                else if (res > num)
                {
                    Console.WriteLine("Guess a lower number");
                }              
            }

        }
    }
}
