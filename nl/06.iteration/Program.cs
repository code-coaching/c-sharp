using System;

Console.WriteLine("Hoe vaak itereren?");
int amount = int.Parse(Console.ReadLine() ?? string.Empty);

int i = 0;
while (i < amount)
{
    Console.WriteLine($"while: {i}");
    i++;
}

for (int j = 0; j < amount; j++)
{
    Console.WriteLine($"for: {j}");
}


// Verschil while en do-while
int k = 10;
while (k < 10)
{
    // dit wordt nooit uitgevoerd
    Console.WriteLine($"while: {k}");
    k++;
}

do
{
    // dit wordt wel één keer uitgevoerd
    Console.WriteLine($"do-while: {k}");
    k++;
} while (k < 10);

// Een do-while loop wordt altijd minimaal één keer uitgevoerd en daarna wordt de conditie gecheckt
