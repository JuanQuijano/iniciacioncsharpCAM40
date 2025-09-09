Console.Clear();

var random = new Random();
var current = 7;

do
{
    //current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


Console.WriteLine("----------");

while (current != 7)
{
    //current = random.Next(1, 11);
    Console.WriteLine(current);
}
Console.WriteLine($"Last number: {current}");