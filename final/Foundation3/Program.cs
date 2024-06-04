using System;

class Program {
    static void Main(string[] args) {
        Lecture lecture = new Lecture{
            Title = "Introduction to AI",
            Description = "Learn about artificial intelligence concepts.",
            Date = DateTime.Now.Date,
            Time = new TimeSpan(10, 0, 0),
            Address = new Address { Street = "456 Elmy St", City = "Spring Summer", State = "UT", Country = "USA"},
            Speaker = "Dr. Smith",
            Capacity = 50
        };

        Reception reception = new Reception {
            Title = "Company Anniversary Party",
            Description = "Celebrate 50 years of Success!",
            Date = DateTime.Now.Date.AddDays(7),
            Time = new TimeSpan (18, 0, 0),
            Address = new Address {Street = "1001 Cap. Ernesto", City = "São Bento do Sul", State = "SC", Country = "BR"},
            RsvpEmail = "rvsp@example.com"
        };

        OutdoorGathering gathering = new OutdoorGathering{
            Title = "Summer Picnic",
            Description = "Enjoy a day in the sun with games and food.",
            Date = DateTime.Now.Date.AddDays(14),
            Time = new TimeSpan (12, 0, 0),
            Address = new Address { Street = "Park Blvd", City = "SunnyVille", State = "FL", Country = "USA"},
            WeatherForecast = "Sunny, high of 80°F"
        };

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(gathering.GetShortDescription());
    }
}