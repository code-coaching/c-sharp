using System;

Console.WriteLine("Eerste getal?");
int firstNumber = int.Parse(Console.ReadLine() ?? string.Empty); // Indien ReadLine null is, wordt er een lege string gebruikt

Console.WriteLine("Tweede getal?");
int secondNumber = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");

firstNumber = firstNumber + 1; // Ophogen met 1
Console.WriteLine("Eerste getal opgehoogd met 1: " + firstNumber);
firstNumber += 1; // Ophogen met 1
Console.WriteLine("Eerste getal opgehoogd met 1: " + firstNumber);
firstNumber++; // Ophogen met 1
Console.WriteLine("Eerste getal opgehoogd met 1: " + firstNumber);

firstNumber = firstNumber - 1; // Verlagen met 1
Console.WriteLine("Eerste getal verlaagd met 1: " + firstNumber);
firstNumber -= 1; // Verlagen met 1
Console.WriteLine("Eerste getal verlaagd met 1: " + firstNumber);
firstNumber--; // Verlagen met 1
Console.WriteLine("Eerste getal verlaagd met 1: " + firstNumber);