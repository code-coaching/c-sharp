using System;

Rekenmachine rekenmachine = new Rekenmachine(); // Instantie van de class Rekenmachine
// Methodes aanroepen op de instantie
int verschil = rekenmachine.Verschil(6, 9);
int som = rekenmachine.Som(6, 9); // Method Som met signature Som(int, int)
int som2 = rekenmachine.Som("3", "6"); // Method Som met signature Som(string, string)
int som3 = rekenmachine.Som(3); // Method Som met signature Som(int)

// Static methodes aanroepen direct op de class (geen instantie nodig)
int optellen = Rekenmachine.Optellen(6, 9);
int aftrekken = Rekenmachine.Aftrekken(6, 9);

// Let op: de class-definitie staat onder de code die de class gebruikt
class Rekenmachine
{
    public int Som(int a, int b)
    {
        return a + b;
    }

    // Method overloading: dezelfde functienaam, maar andere type parameters 
    public int Som(string a, string b)
    {
        return int.Parse(a) + int.Parse(b);
    }

    // Method overloading: dezelfde functienaam, maar andere hoeveelheid parameters
    public int Som(int a)
    {
        return a + a;
    }

    public int Verschil(int a, int b)
    {
        return a - b;
    }

    public static int Optellen(int a, int b)
    {
        return a + b;
    }

    public static int Aftrekken(int a, int b)
    {
        return a - b;
    }
}