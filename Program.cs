using System;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");


int[] times = [800, 1200, 1600, 2000];
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());
TimesCalculation();

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

Console.WriteLine();

#region Methods

/* Format and display medicine times */
void DisplayTimes()
{

    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        { time = time.Insert(len - 2, ":"); }
        else if (len == 2)
        { time = time.Insert(0, "0:"); }
        else
        { time = time.Insert(0, "0:0"); }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

/* Adjust the times by adding the difference, keeping the value within 24 hours */
void AdjustTimes()
{
    for (int i = 0; i < times.Length; i++)
    { times[i] = (times[i] + diff) % 2400; }
}

/* Calculate the time difference based on GMT values */
void TimesCalculation()
{

    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        AdjustTimes();
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
        AdjustTimes();
    }

}

#endregion