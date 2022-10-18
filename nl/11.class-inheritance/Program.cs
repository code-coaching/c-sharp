Ferrari f40 = new Ferrari("F40", 320);
Ferrari f50 = new Ferrari("F50", "Geel", 340);

Console.WriteLine(f40.ToString());
Enter();

Console.WriteLine(f50); // ToString() wordt automatisch aangeroepen als je een instantie van een class print
f50.Versnellen(); // De default waarde van het argument van de method Versnellen() is 10
f50.Versnellen(20);
Console.WriteLine(f50);
f50.Rijden();
Enter();

Ford mustang = new Ford("Mustang", "Blauw", 250);
Ford ka = new Ford("Ka", "Rood", 150);

Console.WriteLine(mustang);
mustang.Rijden();
Enter();

Console.WriteLine(ka);
ka.Versnellen(200);
Console.WriteLine(ka);
Enter();

void Enter()
{
    Console.WriteLine("--------------------");
    Console.WriteLine();
}

class Voertuig
{
    public string merk = "Onbekend";
    public string model = "Onbekend";
    public string kleur = "Onbekend";
    public int aantalWielen = 4;
    int snelheid = 0;

    public int Snelheid
    {
        get
        {
            return snelheid;
        }
        set
        {
            if (value > this.topSnelheid) snelheid = this.topSnelheid;
            else this.snelheid = value;
        }
    }
    public int topSnelheid = 200;

    public Voertuig(string merk, string model, string kleur, int aantalWielen, int topSnelheid)
    {
        this.merk = merk;
        this.model = model;
        this.kleur = kleur;
        this.aantalWielen = aantalWielen;
        this.topSnelheid = topSnelheid;
    }

    public Voertuig(string merk, string model)
    {
        this.merk = merk;
        this.model = model;
    }

    public virtual void Rijden()
    {
        Console.WriteLine("Vroem vroem");
    }

    public void Rijden(int snelheid)
    {
        this.Snelheid = snelheid;
        Console.WriteLine($"Vroem vroem {snelheid} km/u");
    }

    public void Versnellen(int ophogenMet = 10)
    {
        this.Snelheid += ophogenMet;
        Console.WriteLine($"{merk} {model}: Vroem vroem {snelheid} km/u");
    }

    public string HuidigeSnelheid()
    {
        return $"Huidige snelheid: {snelheid} km/u";
    }

    /*
    * override van de ToString()-methode van de Object class
    */
    public override string ToString()
    {
        return $"Merk: {merk}, Model: {model}, Kleur: {kleur}, Aantal wielen: {aantalWielen}, Topnelheid: {snelheid}, {this.HuidigeSnelheid()}";
    }
}

/*
* Wagen is een child van Voertuig (parent)
* Wagen "erft" de fields en methods van Voertuig
*/
class Wagen : Voertuig
{
    /*
    * Wanneer de constructor van Wagen aangeroepen wordt,
    * wordt de constructor van "Voertuig(string merk, string model)" ook aangeroepen
    * Dit door ": base(merk, model)" dat achter de constructor van Wagen staat
    */
    public Wagen(string merk, string model) : base(merk, model)
    {
    }

    /*
    * Constructor overloading: dezelfde naam, maar andere parameters
    * Dit zorgt ervoor dat zowel new Wagen("BMW", "M3") als new Wagen("BMW", "M3", "Zwart", 4, 200) werkt
    */
    public Wagen(string merk, string model, string kleur, int aantalWielen, int topSnelheid) : base(merk, model, kleur, aantalWielen, topSnelheid)
    {
    }
}

/*
* Ford en Ferrari zijn children van Wagen (parent), en dus ook van Voertuig (parent van Wagen)
*/
class Ford : Wagen
{
    public Ford(string model, string kleur, int topSnelheid) : base("Ford", model, kleur, 4, topSnelheid)
    {
    }
}

class Ferrari : Wagen
{
    public Ferrari(string model, string kleur, int topSnelheid) : base("Ferrari", model, kleur, 4, topSnelheid)
    {
    }

    public Ferrari(string model, int topSnelheid) : base("Ferrari", model, "Rood", 4, topSnelheid)
    {
    }

    // Override van de Versnellen()-method van de parent class Voertuig
    public override void Rijden()
    {
        Console.WriteLine("Vroem vroem vroem");
    }
}
