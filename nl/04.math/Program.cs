using System;

Console.WriteLine("Eerste getal?");
int firstNumber = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Tweede getal?");
int secondNumber = int.Parse(Console.ReadLine() ?? string.Empty);

int max = Math.Max(firstNumber, secondNumber);
Console.WriteLine($"Het grootste getal is {max}");

int min = Math.Min(firstNumber, secondNumber);
Console.WriteLine($"Het kleinste getal is {min}");

double sqrt = Math.Sqrt(firstNumber);
Console.WriteLine($"De vierkantswortel van {firstNumber} is {sqrt}");
double sqrt2 = Math.Sqrt(secondNumber);
Console.WriteLine($"De vierkantswortel van {secondNumber} is {sqrt2}");

float pi = 3.141592f;
int round = (int)Math.Round(pi); // Math.Round geeft een double terug, dus we casten naar een int
Console.WriteLine($"De afgeronde waarde van {pi} is {round}");

float round2 = (float)Math.Round(pi * 100) / 100; // afronden op 2 decimalen
Console.WriteLine($"De afgeronde waarde van {pi} is {round2}");
