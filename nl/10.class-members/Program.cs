using System;

Hond hond = new Hond(); // Hond zonder parameters
Console.WriteLine(hond.naam); // "Anoniempje" - de default waarde
// Console.WriteLine(hond.leeftijd); // Dit zou een error geven omdat leeftijd private is
hond.Leeftijd = 8;
Console.WriteLine(hond.Leeftijd);
Console.WriteLine();

Hond samson = new Hond("Samson", 5); // Hond met parameters
Console.WriteLine(samson.naam); // "Samson"
Console.WriteLine(samson.Leeftijd); // 5
Console.WriteLine();

Hond anoniemeHond = new Hond(3); 
Console.WriteLine(anoniemeHond.naam); // "Anoniempje" - de default waarde
Console.WriteLine(anoniemeHond.Leeftijd); // 3
Console.WriteLine();


class Hond
{
    // field/veld met default waarde
    // de access modifier is public, dit field is zichtbaar op de instantie en in de class
    public string naam = "Anoniempje";

    // field/veld zonder default waarde
    // Let op: de standaard access modifier is private - dit field is alleen zichtbaar in de class, niet op de instantie
    int leeftijd;

    // property Leeftijd met een getter en setter 
    // doordat Leeftijd in de class gedefinieerd is, heeft deze toegang tot de private field leeftijd
    // get is een methode die aangeroepen wordt als je de property wilt lezen
    // set is een methode die aangeroepen wordt als  je de property een nieuwe waarde toekent
    public int Leeftijd
    {
        get
        {
            // in het codeblok van de getter kan je nog extra code uitvoeren wanneer de property gelezen wordt
            Console.WriteLine("Leeftijd getter");
            return leeftijd;
        }
        set
        {
            // in het codeblok van de setter kan je nog extra code uitvoeren wanneer de property een nieuwe waarde toekent
            Console.WriteLine("Leeftijd setter");
            leeftijd = value;
        }
    }


    // een constructor - bevat de code die uitgevoerd moet worden wanneer een instantie van de class wordt gemaakt
    // de constructor heeft dezelfde naam als de class
    // de parameters van de constructor zijn de parameters die je moet meegeven wanneer je een instantie maakt
    public Hond(string naam, int leeftijd)
    {
        Console.WriteLine("Hond constructor");
        // this.naam verwijst naar het veld "naam" van de class
        // naam verwijst naar de parameter "naam" van de constructor
        this.naam = naam;
        this.leeftijd = leeftijd;
    }


    /*
    * constructor overloading: dezelfde naam, maar andere parameters
    */
    // constructor zonder parameters - zodat new Hond() werkt
    public Hond()
    {
        Console.WriteLine("Hond constructor zonder parameters");
    }

    public Hond(int leeftijd) {
        Console.WriteLine("Hond constructor met 1 parameter");
        this.leeftijd = leeftijd;
    }
}