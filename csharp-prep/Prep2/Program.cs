using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        int lastDigit = percentage % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptional cases
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+ grade
        }
        if (letter == "F")
        {
            sign = ""; // No F+ or F- grades
        }

        // Print the letter grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the user passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Better luck next time!");
        }
    }
}