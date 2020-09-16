using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace coin_del2
{
    class Program
    {
        static void Main(string[] args)
        {
            string headsOrTailsGuess;
            
            Console.WriteLine("Guess which will have more: heads or tails? ");
            headsOrTailsGuess = Console.ReadLine();
            
            //Console.WriteLine("You chose " + headsOrTailsGuess);
            
            Console.WriteLine("How many times do you want to flip the coin? ");
            int numberOfFlips = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("You want to flip " + numberOfFlips);
            double correctCount = 0;
            double tossCount = 0;
            //int percentage = correctCount / numberOfFlips * 100;
            while (tossCount < numberOfFlips)
            {
                Random toss = new Random();
                int n = toss.Next();
                if (n % 2 == 0)
                { Console.WriteLine("heads"); 
                    if ("heads" == headsOrTailsGuess)
                    { correctCount++; }
                } //even number is heads
                else
                { Console.WriteLine("tails"); 
                    if ("tails" == headsOrTailsGuess)
                    { correctCount++; }
                } //odd number is tails
               tossCount++;


            }

 
            double percentage =  Math.Round(correctCount / tossCount * 100);

            Console.WriteLine("Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");
            Console.WriteLine("That's " + percentage + "%.");



        }
    }
}
