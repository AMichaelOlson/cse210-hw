class Program
{
    static void Main(string[] args)
    {
        //First Address
        Address address1 = new Address("2447 Village Street", "Twin Falls", "ID", "USA");
        // Second Address
        Address address2 = new Address("1337 Elite Street", "Pocatello", "ID", "USA");
        // Third Address
        Address address3 = new Address("3839 Rick Avenue", "Rexburg", "ID", "USA");

        // Lecture event on September 12th at 10am by Dr Doof with a limit of 100 people
        Event lecture = new Lecture("Local Wildlife Update", "Giving an update on all the local wildlife", new DateTime(2024, 9, 12), "10:00 AM", address1, "Dr. Doof", 100);
        // Reception event on October 20th at 6pm
        Event reception = new Reception("Elayna's Reception", "Celebrate Elayna's wedding at this reception", new DateTime(2024, 10, 20), "6:00 PM", address2, "elaynabug@gmail.com");
        // Outdoor Gathering on AUgust 15th at 12pm with Sunny weather
        Event outdoorGathering = new OutdoorGathering("City Picnic", "A fun outdoor picnic", new DateTime(2024, 8, 15), "12:00 PM", address3, "Sunny, 72Â°F");


        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var eventItem in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine("\n---------------------------------\n");
        }
    }
}