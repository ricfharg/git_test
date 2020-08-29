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
            string startNum, endNum;
            Console.WriteLine("Enter the starting number:");
            startNum = Console.ReadLine();
            Console.WriteLine("Enter the end number");
            endNum = Console.ReadLine();

            int startNumInt, endNumInt;
            startNumInt = Convert.ToInt32(startNum);
            endNumInt = Convert.ToInt32(endNum);

            int num = rnd.Next(startNumInt, endNumInt);
            string startMsg = "I'm thinking of a number between " + startNum + " and " + endNum;
            Console.WriteLine(startMsg);
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
            int count = 1;
            while (res != num)
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
                count++;
            }
            string endMsg = "It took you " + count.ToString() + " tries to guess the right number";
            Console.WriteLine(endMsg);


        }
    }
}
