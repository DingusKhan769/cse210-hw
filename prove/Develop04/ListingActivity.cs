// filepath: c:\BYUI\CSE 110\projects\CSE210\cse210-hw\prove\Develop04\ListingActivity.cs
using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        name = "Listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Execute()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        ShowCountdown(5);
        int count = 0;
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("List item: ");
            Console.ReadLine();
            count++;
            elapsed += 2; // assuming it takes 2 seconds to list each item
        }

        Console.WriteLine($"You listed {count} items.");
        Finish();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}