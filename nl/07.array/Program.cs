using System;

int[] anArray = new int[3]; // Array met plaats voor 3 elementen van het type int
Console.WriteLine(anArray[0]); // 0
Console.WriteLine(anArray[1]); // 0
anArray[2] = 5; // Overschrijven van de waarde op index 2
Console.WriteLine(anArray[2]); // 5
// Console.WriteLine(anArray[3]); // Index out of bounds exception - de array heeft maar plaats voor 3 elementen

int[] initializedArray = new int[3] { 10, 13, 69 };
Console.WriteLine(initializedArray[0]); // 10
Console.WriteLine(initializedArray[1]); // 13
Console.WriteLine(initializedArray[2]); // 69

for (int i = 0; i < initializedArray.Length; i++)
{
    Console.WriteLine($"Element {i} is {initializedArray[i]}");
}

foreach (int element in initializedArray)
{
    Console.WriteLine($"Element is {element}");
}