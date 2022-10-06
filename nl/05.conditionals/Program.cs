using System;

Console.WriteLine("Eerste getal?");
int firstNumber = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Tweede getal?");
int secondNumber = int.Parse(Console.ReadLine() ?? string.Empty);


if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} is groter dan {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"{firstNumber} is kleiner dan {secondNumber}");
}
else
{
    Console.WriteLine($"{firstNumber} is gelijk aan {secondNumber}");
}

if (firstNumber % 2 == 0)
{
    Console.WriteLine($"{firstNumber} is even");
}
else
{
    Console.WriteLine($"{firstNumber} is oneven");
}

string secondNumberEven = secondNumber % 2 == 0 ? "even" : "oneven"; // ternary operator
// als de statement voor het vraagteken true is, dan wordt de waarde na het vraagteken gebruikt
// als de statement voor het vraagteken false is, dan wordt de waarde na de dubbele punt gebruikt
Console.WriteLine($"{secondNumber} is {secondNumberEven}");

switch (firstNumber)
{
    case 1:
        Console.WriteLine("Een");
        break;
    case 2:
        Console.WriteLine("Twee");
        break;
    case 3:
        Console.WriteLine("Drie");
        break;
    default:
        Console.WriteLine("Kleiner dan 1 of groter dan 3");
        break;
}