using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();

        number.Add(18);
        number.Add(36);
        number.Add(2);
        number.Add(48);
        number.Add(6);
        number.Add(12);
        number.Add(9);
        number.Add(0);

        int sum = number.Sum();
        Console.WriteLine($"The sum is: {sum}");
        
        double average = Queryable.Average(number.AsQueryable());
        Console.WriteLine($"The average is: {average}");

        int biggest = number.Max();
        Console.WriteLine($"The largest number is: {biggest}");
        
    }
}