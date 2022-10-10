using System;

Rekenmachine rekenmachine = new Rekenmachine(); // Instantie van de class Rekenmachine
// Methodes aanroepen op de instantie
int som = rekenmachine.Som(6, 9);
int verschil = rekenmachine.Verschil(6, 9);

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