using System;
using System.Collections.Generic;

namespace EventPlanning
{
    // Address class to encapsulate address details
    public class Address
    {
        private string street;
        private string city;
        private string state;
        private string zipCode;

        public Address(string street, string city, string state, string zipCode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{street}, {city}, {state}, {zipCode}";
        }
    }

    // Base class for events
    public abstract class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private string time;
        private Address address;

        protected Event(string title, string description, DateTime date, string time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string GetStandardDetails()
        {
            return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
        }

        public abstract string GetFullDetails();

        public string GetShortDescription()
        {
            return $"{GetType().Name}: {title} on {date.ToShortDateString()}";
        }
    }

    // Derived class for lectures
    public class Lecture : Event
    {
        private string speaker;
        private int capacity;

        public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
        }
    }

    // Derived class for receptions
    public class Reception : Event
    {
        private string rsvpEmail;

        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
        }
    }

    // Derived class for outdoor gatherings
    public class OutdoorGathering : Event
    {
        private string weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            this.weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
        }
    }

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