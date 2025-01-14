using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        
        int x = int.Parse(userInput);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string gradeLetter = "";

        
        if (x >= a)
        {
            gradeLetter = "A";
            //Console.Write("Congratulations! Your grade is an A! ");   
        }

        else if (x >= b && x < a)
        {
            gradeLetter = "B";
            //Console.Write("Your grade is a B ");
        }

        else if (x >= c && x < b)
        {
            gradeLetter = "C";
            //Console.Write("Your grade is a C ");
        }

        else if (x >= d && x < c)
        {
            gradeLetter = "D";
            //Console.Write("Your grade is a D ");
        }

        else
        {
            gradeLetter = "F";
            //Console.Write("Sorry your grade is an F. ");

        }

        Console.WriteLine($"Your grade is an: {gradeLetter}");

        if (x >= c)
        {
            Console.Write("Congratulations! You have passed the class! ");
        }

        else
        {
            Console.Write("Sorry classes can be hard. Keep working hard and next time you can pass the this class. ");
        }
  
    }
}