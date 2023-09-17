using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);

        string letter = "";

        if (grade > 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter} ");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed! ");
        }
        else
        {
            Console.WriteLine("You didn't pass. Keep studying! ");
        }
    }
}