using System.Globalization;

public class Person
{
    public string PersonName { get; set; }
    public string PersonAge { get; set; }
    public static string defaultName;
    public static string defaultAge;

    static Person()
    { 
        defaultName = "unknown";
        defaultAge = "unknown";
    }

    public Person()
    {
        PersonName = "unknown";
        PersonAge = "unknown";
    }

    public Person(string name)
    {
        PersonName = name;
        PersonAge = "unknown";
    }

    public Person(string name, int age)
    {
        PersonName = name;
        PersonAge = age.ToString();
    }
}

static class Program
{
    // the Main method is the entry point of the program.
    static void Main()
    {
        Console.Clear();
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

        Person person1 = new Person();
        Person person2 = new Person("Jane Doe");
        Person person3 = new Person("John Doe", 30);

        Console.WriteLine($"Person 1 Name: {person1.PersonName} Age: {person1.PersonAge}");
        Console.WriteLine($"Person 2 Name: {person2.PersonName} Age: {person2.PersonAge}");
        Console.WriteLine($"Person 3 Name: {person3.PersonName} Age: {person3.PersonAge}");
    }
}
