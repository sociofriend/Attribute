namespace AttributesProject;

class Program
{
    static void Main(string[] args)
    {
        Contact sarah = new Contact()
        {
            FirstName = "Sarah Conner",
            AgeInYears = 38
        };

        var sarahWriter = new ContactConsoleWriter(sarah);
        sarahWriter.Write();

        Console.WriteLine("\n\nHit enter to exit...");
        Console.ReadLine();
    }
}

