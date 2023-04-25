using System;

class Program
{
    static void Main(string[] args)
    {
        int adnumber = -1;
        List<int> numbers = new List<int>();
        int total = 0;
        while (adnumber !=0)
        {
            Console.Write("Add a number. If your done then put 0 ");
            adnumber = int.Parse(Console.ReadLine());
            numbers.Add(adnumber);
        }
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.Write($"Your total is {total}");
        

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average: {average}");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}