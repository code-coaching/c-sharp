using System;

// method/functie die niks teruggeeft -> void
void HelloWorld()
{
    Console.WriteLine("Hello World!");
}
HelloWorld(); // Functie aanroepen

// method/functie met een parameter
void Print(string text)
{
    Console.WriteLine(text);
}
// Functie aanroepen met een parameter/argument
Print("Hello World!");
Print("John Duck");

// method/functie die een waarde teruggeeft, type van de returnwaarde staat voor de functienaam -> int
int Som(int a, int b)
{
    return a + b;
}

// Functie aanroepen met twee parameters/argumenten
int resultaat = Som(6, 9); // resultaat = 15
Print(resultaat.ToString()); // Print("15");

Print(Som(10, 13).ToString()); // Print("23");
