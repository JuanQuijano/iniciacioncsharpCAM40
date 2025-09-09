Console.Clear();

for (int i = 1; i <= 100; i++)
{
    var suffix = (i % 3 == 0 ? "Fizz" : string.Empty) + (i % 5 == 0 ? "Buzz" : string.Empty);
    Console.WriteLine($"{i} {suffix}");
}

