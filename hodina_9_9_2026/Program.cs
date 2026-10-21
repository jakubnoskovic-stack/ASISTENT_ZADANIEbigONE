
//úloha 1 
 int cislo;

Console.Write("Zadaj číslo: ");

while (!int.TryParse(Console.ReadLine(), out cislo))
{
    Console.WriteLine("Chyba: Zadaný vstup nie je platné číslo!");
    Console.Write("Zadaj číslo znova: ");
}

bool cislo3 = (cislo % 3 == 0);
bool cislo5 = (cislo % 5 == 0);
bool cislo7 = (cislo % 7 == 0);

if (cislo3)
{
    Console.WriteLine("Číslo je delitelne trojkov");
}
if (cislo5)
{
    Console.WriteLine("Číslo je delitelné päťkov");
}
if (cislo7)
{
    Console.WriteLine("Číslo je delitelné sedmičkou");
}

if (!cislo3 && !cislo5 && !cislo7)
{
    Console.WriteLine("Číslo neni delitelne číslami 3,5,7.");
}
else if (cislo3 && !cislo5 && !cislo7)
{
    Console.WriteLine("Číslo neni delitelne číslami 5,7.");
}
else if (!cislo3 && cislo5 && !cislo7)
{
    Console.WriteLine("Číslo neni delitelne číslami 3,7.");
}
else if (!cislo3 && !cislo5 && cislo7)
{
    Console.WriteLine("Číslo neni delitelne číslami 3,5.");
}
else if (cislo3 && cislo5 && !cislo7)
{
    Console.WriteLine("Číslo neni delitelne číslom 7.");
}
else if (cislo3 && !cislo5 && cislo7)
{
    Console.WriteLine("Číslo neni delitelne číslom 5.");
}
else if (!cislo3 && cislo5 && cislo7)
{
    Console.WriteLine("Číslo neni delitelne číslom 3.");
}


/*
//úloha 2
Console.WriteLine("Zadaj číslo od 1-7: ");
String cislotext = Console.ReadLine();
int cislo=int.Parse(cislotext);
if (cislo >= 1 && cislo <= 5)
{
    Console.WriteLine("Číslo je pracovný deň.");
}
else if (cislo == 6 || cislo == 7)
{
    Console.WriteLine("Číslo je víkend.");
}
else
{
    Console.WriteLine("Číslo nie je od 1-7.");
*/

/*
//uloha 3
Console.WriteLine("Napíš lubovolnu vetu: ");
string veta=Console.ReadLine();
if (veta[0] == '#')
{
    Console.WriteLine("Veta začína mriežkov.");
}
else
{
    Console.WriteLine("veta nezaína mriežkov.");
}
*/

/*
//úloha 4
Console.WriteLine("zadaj uživatelské meno: ");
string veta=Console.ReadLine();
if (veta.Length <= 12 && veta.Length >= 4)
{
    Console.WriteLine("dobre uživatelské meno");
}
else
{
    Console.WriteLine("zlé uživatelské meno");
}
*/

/*
//úloha 5
Console.WriteLine("napis najväčší uhol trojuholnika: ");
string uholtext=Console.ReadLine();
int uhol = int.Parse(uholtext);
if (uhol >= 0 && uhol <= 89)
{
    Console.WriteLine("Uhol je pravý.");
}
else if (uhol == 90)
{
    Console.WriteLine("uhol je pravý.");
}
else if (uhol >= 91 && uhol <= 178)
{
    Console.WriteLine("uhol je tupý.");
}
else
{
    Console.WriteLine("troj uholnik neni realny");
}
*/

/*
//uloha 6
Console.WriteLine("napis 2 čísla");
string stringcislo1=Console.ReadLine();string stringcislo2=Console.ReadLine();
int cislo1 = int.Parse(stringcislo1);
int cislo2 = int.Parse(stringcislo2);
if (cislo1 < cislo2)
{
    Console.WriteLine("číslo 2 je väčšie");
}
else if (cislo1 > cislo2)
{
    Console.WriteLine("číslo 1 je väčšie");
}
else if(cislo1==cislo2)
{
    Console.WriteLine("čísla sú rovnaké");
}
*/

/*
//úloha 7
double cislo;
Console.WriteLine("Zadaj číslo: ");
double.TryParse(Console.ReadLine(), out cislo);
string prikaz=Console.WriteLine("Zadaj príkaz (obratena hodnota, druha mocnina, odmocnina): ");
if (prikaz == "obratena hodnota")
{
    if (cislo == 0)
    {
        Console.WriteLine("Chyba: Obrátená hodnota z nuly sa nedá vypočítať (nemožno deliť nulou).");
    }
    else
    {
        double vysledok = 1.0 / cislo;
        Console.WriteLine($"Výsledok: {vysledok}");
    }
}
else if (prikaz == "druha mocnina")
{
    double vysledok = Math.Pow(cislo, 2);
    Console.WriteLine($"Výsledok: {vysledok}");
}
else if (prikaz == "odmocnina")
{
    if (cislo < 0)
    {
        Console.WriteLine("Chyba: Odmocnina zo záporného čísla neexistuje.");
    }
    else
    {
        double vysledok = Math.Sqrt(cislo);
        Console.WriteLine($"Výsledok: {vysledok}");
    }
}
else
{
    Console.WriteLine("Chyba: Zadal si neplatný príkaz.");
}
*/

/*
//úloha 8
Console.WriteLine("napis vetu: ");
string veta= Console.ReadLine();
if (veta.Contains("the") || veta.Contains("The"))
{
    Console.WriteLine("Vo vete sa nachádza 'THE'.");
}
else
{
    Console.WriteLine("Vo vete sa nenachádza 'THE'.");
}
*/

/*
//úloha 9
int percento;
Console.WriteLine("Zadaj percentá, ktoré si dostal: ");
bool znova = true;
for (; znova == true;)
{
    int.TryParse(Console.ReadLine(), out percento);
    int pocitadlo = 41;
    int znamka = 5;
    for (int i = 0; i < 5; i++)
    {
        if (percento < pocitadlo)
        {
            Console.WriteLine("Dostal si " + znamka);
            break;
        }

        pocitadlo = pocitadlo + 15;
        znamka--;
    }

    pocitadlo = 40;
    znamka = 5;
    Console.WriteLine("Chceš znova? (ak ano zadaj 'Ano' ak nie zadaj 'Nie'");
    string strznova = Console.ReadLine();
    string ano = "Ano";
    string nie = "Nie";
    if (strznova == ano)
    {
        znova = true;
    }
    if (strznova == nie)
    {
        znova = false;
    }
}
*/
