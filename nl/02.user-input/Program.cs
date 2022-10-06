using System;

Console.WriteLine("Wat is je naam?");
string nameInput = Console.ReadLine();

Console.WriteLine("Wat is je leeftijd?");
string ageInput = Console.ReadLine(); // ReadLine geeft altijd een string terug
int age = int.Parse(ageInput); // int.Parse zet een string om naar een int

Console.WriteLine("Dag " + nameInput + ", je bent " + age + " jaar oud."); // Concatenatie van strings met +
Console.WriteLine($"Dag {nameInput}, over 10 jaar ben je {age + 10} jaar oud."); // Interpolatie van strings met $ en {}