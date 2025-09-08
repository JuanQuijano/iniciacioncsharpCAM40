Console.Clear();

string[] fraudulentOrderIDs = ["A123", "B456", "C789", "D012" ];

Console.WriteLine(fraudulentOrderIDs[0]);
Console.WriteLine(fraudulentOrderIDs[1]);
Console.WriteLine(fraudulentOrderIDs[2]);
Console.WriteLine(fraudulentOrderIDs[3]);

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Existen {fraudulentOrderIDs.Length} ordenes fraudulentas para procesar.");

Console.WriteLine(fraudulentOrderIDs[fraudulentOrderIDs.Length-1]);