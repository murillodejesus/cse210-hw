using System;
using System.Collections.Generic;

class Activity {
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set;}

    public virtual double GetDistance() {
        return 0;
    }

    public virtual double GetSpeed() {
        return 0;
    }

    public virtual double GetPace() {
        return 0;
    }

    public virtual string GetSummary() {
        return $"{Date.ToShortDateString()} {GetType().Name} ({LengthInMinutes} min)";
    }
}

class Running : Activity {
    public double Distance { get; set; }

    public override double GetDistance() {
        return Distance;
    }

    public override double GetSpeed() {
        return Distance / (LengthInMinutes / 60.0);
    }

    public override double GetPace() {
        return LengthInMinutes / Distance;
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}

class Cycling : Activity {
    public double Speed { get; set; }

    public override double GetSpeed() {
        return Speed;
    }

    public override double GetPace() {
        return 60 / Speed;
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} - Speed: {Speed} mph, Pace: {GetPace()} min/mile";
    }
}

class Swimming : Activity {
    public int Laps { get; set; }

    public override double GetDistance() {
        return Laps * 50 / 1000; // Distance in kilometers
    }

    public override double GetSpeed() {
        return GetDistance() / (LengthInMinutes / 60.0);
    }

    public override double GetPace() {
        return LengthInMinutes / (Laps * 50 / 1000); // Pace in minutes per kilometer
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}