using System;

class Program
{
    static void Main(string[] args)
    {
        //Random randomGenerator = new Random();
        
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();

        int x = int.Parse(magicNumber);
        int y = int.Parse(userGuess); 

        if (y > x)
        {
            Console.WriteLine("Lower ");
        } 
         else if (y < x)
        {
            Console.WriteLine("Higher ");
        }

        while (y != x)
        {
            Console.Write("What is your guess? ");
            string newGuess = Console.ReadLine();
            y = int.Parse(newGuess);

            {
                if (y == x)
                {
                    Console.WriteLine("You guessed it! ");
                }

                else if (y > x)
                {
                    Console.WriteLine("Lower ");
                }

                else if (y < x)
                {
                    Console.WriteLine("Higher ");
                }
            }

        }
    }   
}