using System;

class Program {
    static void Main(string[] args) {
        List<Activity> activities = new List<Activity>();

        Running running = new Running { Date = DateTime.Now.Date, LengthInMinutes = 30, Distance = 3.0 };
        Cycling cycling = new Cycling { Date = DateTime.Now.Date, LengthInMinutes = 45, Speed = 15.0 };
        Swimming swimming = new Swimming { Date = DateTime.Now.Date, LengthInMinutes = 60, Laps = 20 };

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (var activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}