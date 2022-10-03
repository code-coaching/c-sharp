using System; // Nodig voor Console.WriteLine

/*
* Hele getallen
*/
int eenInt = 69;
int kleinstMogelijkeInt = int.MinValue; // -2147483648
int grootstMogelijkeInt = int.MaxValue; // 2147483647

long someLong = 3141592653; // Groter dan int.MaxValue, past wel in long
long kleinstMogelijkeLong = long.MinValue; // -9223372036854775808
long grootstMogelijkeLong = long.MaxValue; // 9223372036854775807

/*
* Kommagetallen
*/
float eenFloat = 3.141592653f; // Merk op dat er een f achter staat
float kleinstMogelijkeFloat = float.MinValue; // -3.40282347E+38
float grootstMogelijkeFloat = float.MaxValue; // 3.40282347E+38

double eenDouble = 1.0;
double kleinstMogelijkeDouble = double.MinValue; // -1.7976931348623157E+308
double grootstMogelijkeDouble = double.MaxValue; // 1.7976931348623157E+308

/*
* Karakters en zinnen
*/
char eenKarakter = 'a'; // enkel karakter, enkel aanhalingstekens
string eenZin = "Dit is een zin."; // meerdere karakters, dubbele aanhalingstekens

/*
* Booleans
*/
bool isWaar = true;
bool isOnwaar = false;

Console.WriteLine("Een voorbeeld van een Integer: " + eenInt);
Console.WriteLine("De kleinst mogelijke Integer: " + kleinstMogelijkeInt);
Console.WriteLine("De grootst mogelijke Integer: " + grootstMogelijkeInt);
Console.WriteLine();
Console.WriteLine("Een voorbeeld van een Long: " + someLong);
Console.WriteLine("De kleinst mogelijke Long: " + kleinstMogelijkeLong);
Console.WriteLine("De grootst mogelijke Long: " + grootstMogelijkeLong);
Console.WriteLine();
Console.WriteLine("Een voorbeeld van een Float: " + eenFloat);
Console.WriteLine("De kleinst mogelijke Float: " + kleinstMogelijkeFloat);
Console.WriteLine("De grootst mogelijke Float: " + grootstMogelijkeFloat);
Console.WriteLine();
Console.WriteLine("Een voorbeeld van een Double: " + eenDouble);
Console.WriteLine("De kleinst mogelijke double: " + kleinstMogelijkeDouble);
Console.WriteLine("De grootst mogelijke double: " + grootstMogelijkeDouble);
Console.WriteLine();
Console.WriteLine("Één karakter - Char: " + eenKarakter);
Console.WriteLine("Meerdere karakters (een zin) - String: " + eenZin);
Console.WriteLine();
Console.WriteLine("Boolean true (waar): " + isWaar);
Console.WriteLine("Boolean false (onwaar): " + isOnwaar);
