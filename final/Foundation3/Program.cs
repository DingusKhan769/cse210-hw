using System;
using System.Collections.Generic;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address lectureAddress = new Address("123 Main St", "Anytown", "NY", "12345");
            Address receptionAddress = new Address("456 Oak St", "Othertown", "CA", "67890");
            Address outdoorAddress = new Address("789 Pine St", "Sometown", "TX", "11223");

            Lecture lecture = new Lecture("Tech Talk", "A talk about the latest in tech.", new DateTime(2025, 5, 20), "10:00 AM", lectureAddress, "John Doe", 100);
            Reception reception = new Reception("Wedding Reception", "Celebrating the wedding of Jane and John.", new DateTime(2025, 6, 15), "5:00 PM", receptionAddress, "rsvp@wedding.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Music Festival", "A day of fun and music.", new DateTime(2025, 7, 10), "12:00 PM", outdoorAddress, "Sunny, 75°F");

            List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

            foreach (var ev in events)
            {
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine();
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine();
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}