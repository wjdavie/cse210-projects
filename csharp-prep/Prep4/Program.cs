using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int listNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        do
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            listNumber = int.Parse(response);

            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            } 
        } while (listNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}" );

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}" );
    }
}