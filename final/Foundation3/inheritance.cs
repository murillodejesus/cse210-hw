using System;

class Address {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInUSA() {
        return Country.ToLower() == "usa";
    }

    public string GetFullAddress() {
        return$"{Street}, {City}, {State}, {Country}";
    }
}

class Event {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Address { get; set; }

    public virtual string GetStandardDetails() {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAdress : {Address.GetFullAddress()}";
    }

    public virtual string GetFullDetails() {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription() {
        return $"Type: {GetType().Name}, Title: {Title}, Date: {Date.ToShortDateString()}";
    }
}

class Lecture : Event {
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}

class Reception : Event {
    public string RsvpEmail { get; set; }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nRSVP Email: {RsvpEmail}";
    }
}

class OutdoorGathering : Event {
    public string WeatherForecast { get; set; }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nWeather Forecast: {WeatherForecast}";
    }
}

