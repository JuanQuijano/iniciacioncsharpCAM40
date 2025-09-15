public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;

    // Methods
    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "Alice";
        person.Age = 27;
        
        person.Display();
    }
}