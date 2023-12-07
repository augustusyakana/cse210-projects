using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();

        // RECEPTION DETAILS
        string type1 = "Reception";
        string title1 = "Moonlit Elegance";
        string description1 = "Step into an evening of refined splendor with our Moonlit Elegance reception. Set indoors, this event promises an enchanting ambiance, sophisticated décor, and an unforgettable night of celebration. Join us for an evening where elegance meets warmth in every carefully curated detail.";
        string date1 = "December 20th, 2024";
        string time1 = "7:00pm to Midnight";
        string street1 = "1120 Moonlight Ave";
        string city1 = "Honolulu";
        string state1 = "Hawaii";
        string country1 = "USA";
        int zipcode1 = 96819;
        string instructions1 = "On the 30th floor, conference room #3";
        string rsvpStatement = "RSVP REQUIRED\nText 'MOONLIGHT' to (808)123-4567 along with your fullname\nThank YOU!";

        Reception reception = new Reception(rsvpStatement, type1, title1, description1, date1, time1);
        reception.SetAddress(street1, city1, state1, country1, zipcode1, instructions1);
        _events.Add(reception);

        // OUTDOOR DETAILS
        string type2 = "Outdoor Gathering";
        string title2 = "Starlit Serenity in the Garden";
        string description2 = "Immerse yourself in the magic of our outdoor reception, 'Starlit Serenity in the Garden.' Amidst fragrant blooms and a gentle breeze, revel in the celestial charm. The night sky, weather permitting, will be our canvas, creating an ambiance of pure enchantment.";
        string date2 = "November 9, 2024";
        string time2 = "8PM to 1AM";
        string street2 = "2237 S King St.";
        string city2 = "Honolulu";
        string state2 = "Hawaii";
        string country2 = "USA";
        int zipcode2 = 96826;
        string instructions2 = "Middle of the field, where all the balloons are.";
        string weather = "Please note that the event is subject to weather conditions, and in case of inclement weather, appropriate arrangements will be made to ensure the comfort and enjoyment of our guests.";

        Outdoor outdoor = new Outdoor(weather, type2, title2, description2, date2, time2);
        outdoor.SetAddress(street2, city2, state2, country2, zipcode2, instructions2);
        _events.Add(outdoor);

        // LECTURE DETAILS
        string type3 = "Lecture";
        string title3 = "Cosmic Conversations: Exploring the Mysteries of the Universe";
        string description3 = "Join us for an enlightening lecture, 'Cosmic Conversations,' where we delve into the profound mysteries of the universe. Embark on a journey through space and time as our guest speaker unravels celestial wonders, bringing the cosmos closer to Earth. This intellectually stimulating event promises to expand your understanding of the cosmos and ignite your curiosity about the vastness that surrounds us.";
        string date3 = "June 28, 2024";
        string time3 = "10:00 AM";
        string street3 = "2450 Date Street";
        string city3 = "Honolulu";
        string state3 = "Hawaii";
        string country3 = "USA";
        int zipcode3 = 96826;
        string instructions3 = "On the 1st Floor, Suite 103";
        string speaker = "Elon Musk";
        int capacity = 250;

        Lecture lecture = new Lecture(speaker, capacity, type3, title3, description3, date3, time3);
        lecture.SetAddress(street3, city3, state3, country3, zipcode3, instructions3);
        _events.Add(lecture);

        Console.WriteLine("\nSTANDARD DETAILS FOR EACH:");
        foreach(Event @event in _events)
        {
            Console.WriteLine($"\n{@event.GetStandardDetails()}");
        }

        Console.WriteLine("\nSHORT DESCRIPTION FOR EACH:");
        foreach(Event @event in _events)
        {
            Console.WriteLine($"\n{@event.GetShortDescription()}");
        }

        Console.WriteLine("\nFULL DETAILS FOR EACH:");
        foreach(Event @event in _events)
        {
            Console.WriteLine($"\n{@event.GetFullDetails()}");
        }
        Console.WriteLine("");

    }
}