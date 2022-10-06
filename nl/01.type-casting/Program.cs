/*
* Impliciete type casting
*
* Iets dat 'kleiner' is kan in iets 'groter' worden gestopt
*/

int eenInt = 5;
long longGroterDanInt = eenInt; // geen probleem

/*
long eenLong = 5L;
int intKleinerDanLong = eenLong; // foutmelding - een long past niet in een int
*/

float eenFloat = 5.0f;
double doubleGroterDanFloat = eenFloat; // geen probleem

/*
double eenDouble = 5.0;
float floatKleinerDanDouble = eenDouble; // foutmelding - een double past niet in een float
*/

/*
* Expliciete type casting
* 
* Een data type dat 'groter' is, waarvan de waarde in een data type dat 'kleiner' is past
* kan expliciet worden gecast worden.
*/

long eenLong = 5L;
int intKleinerDanLong = (int)eenLong; // Dit is een expliciete type cast van long naar int

double eenDouble = 5.0;
float floatKleinerDanDouble = (float)eenDouble; // Dit is een expliciete type cast van double naar float

long maxGrootteVanInt = int.MaxValue;
int maxGrootteInt = (int)maxGrootteVanInt; // Dit is een expliciete type cast van long naar int

/*
long groterDanInt = int.MaxValue + 1;
int kleinerDanLong = (int)groterDanInt; // Dit geeft een 'overflow' error, je kan enkel een cast naar een kleiner type doen als de waarde past
*/