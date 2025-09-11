using System;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");


int[] schedule = [800, 1200, 1600, 2000];
var diff = 0;

AdjusteTimes(6, -6);
DisplayTimes();

void AdjusteTimes(int currentGMT, int newGMT)
{

    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    { Console.WriteLine("Invalid GMT"); }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    { diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT)); }
    else
    { diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT)); }


}
void DisplayTimes()
{
    for (int i = 0; i < schedule.Length; i++)
    {
        int newTime = (schedule[i] + diff) % 2400;
        Console.WriteLine($"{schedule[i]} -> {newTime}");
    }
}