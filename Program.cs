using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

Random random = new Random();


if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = GetRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    Console.WriteLine("Would you like to play? (Y/N)");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        return false;
        
    var c = input.Trim()[0];
    Console.Clear();
    return c.ToString().ToLower() == "y";
}
int GetTarget()
{ return random.Next(1, 6); }
int GetRoll()
{ return random.Next(1, 7); }
string WinOrLose(int target, int roll)
{    return roll > target ? "You win!" : "You lose.";}