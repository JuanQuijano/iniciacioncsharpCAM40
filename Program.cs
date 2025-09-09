Console.Clear();
/*
for (var indice = 0; indice < 10; indice++)
{
    Console.WriteLine(indice);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names = ["Alex", "Eddie", "David", "Michael"];
for (var i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/
var i = 0;

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

i = 0;
foreach (var name in names)
{
    if (name == "Sammy")
        names[i] = "Pepe";
    
    Console.WriteLine(name);
    i++;
}
