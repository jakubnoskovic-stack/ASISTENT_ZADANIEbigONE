Boolean NajdiSlovo(string vstup, string hladanéSlovo)
{
    vstup = vstup.ToLower();
    hladanéSlovo = hladanéSlovo.ToLower();
    Boolean PravdivostnáHodnota = false;
    if (vstup.Contains(hladanéSlovo))
    {
        PravdivostnáHodnota = true;
    }

    return PravdivostnáHodnota;
}
double odmocni(double vklad)
{
    double odmocnina = Math.Sqrt(vklad);
    return odmocnina;
}
double spočítaj (double input1 ,double input2)
{
    double vysledok = input1 +input2;
    return vysledok;
}
double odčítaj (double input1 ,double input2)
{
    double vysledok = input1 -input2;
    return vysledok;
}
double vydel (double input1 ,double input2)
{
    double vysledok = input1 / input2;
    return vysledok;
}
double vynasob (double input1 ,double input2)
{
    double vysledok = input1 * input2;
    return vysledok;
}
Console.WriteLine("Ahoj som tovoj osobný asistent, ktory ti pomôže s tvojimy ulohami.");
Console.WriteLine("Ak nevieš aké veci viem pre teba spraviť napíš '/help'");
string prikaz=Console.ReadLine();
while (prikaz!="/exit"&&prikaz!="/sum"&&prikaz!="/odmocni"&&prikaz!="/find"&&prikaz!="/help")
{
   Console.Write("Toto neni príkaz. Skús znova: "); 
   prikaz=Console.ReadLine();
}
while(prikaz!="/exit")
{
    if (prikaz == "/sum")
    {
        Console.Write("Napíš prvé čislo na operáciiu: ");
        double Cislo1;
        while (!double.TryParse(Console.ReadLine(), out Cislo1))
        {
            Console.Write("Toto neni číslo. Skús znova: ");
        }
        Console.Write("Napíš druhé čislo na operáciu: ");
        double Cislo2;
        while (!double.TryParse(Console.ReadLine(), out Cislo2))
        {
            Console.Write("Toto neni číslo. Skús znova: ");
        }
        Console.WriteLine("Akú operáciu chceš vykonať?");
        Console.WriteLine("/násob");
        Console.WriteLine("/vydel");
        Console.WriteLine("/sčítaj");
        Console.WriteLine("/odčítaj");
        string PrikazSum = Console.ReadLine();
        while (PrikazSum!="/násob"&&PrikazSum!="/vydel"&&PrikazSum!="/sčítaj"&&PrikazSum!="/odčítaj")
        {
            Console.Write("Toto nie je žiaden príkaz. Skús znova: ");
            PrikazSum = Console.ReadLine();
        }
        if (PrikazSum == "/sčítaj")
        {
            double vysledok= spočítaj(Cislo1, Cislo2);
            Console.WriteLine("Toto je vysledok: "+ vysledok);
        }

        if (PrikazSum == "/odčítaj")
        {
            double vysledok= odčítaj(Cislo1, Cislo2);
            Console.WriteLine("Toto je vysledok: "+ vysledok);
        }
        if (PrikazSum == "/vydel")
        {
            double vysledok= vydel(Cislo1, Cislo2);
            Console.WriteLine("Toto je vysledok: "+ vysledok);
        }
        if (PrikazSum == "/vynásob")
        {
            double vysledok= vynasob(Cislo1, Cislo2);
            Console.WriteLine("Toto je vysledok: "+ vysledok);
        }
        
    }

    else if (prikaz == "/odmocni")
    {
        double cisloOdmocnina;
        Console.Write("Napíš číslo na odmocnenie");
        while (double.TryParse(Console.ReadLine(),out cisloOdmocnina))
        {
            Console.Write("Toto neni číslo. Skús znova: ");
            Console.WriteLine("Toto je vysledok: "+ odmocni(cisloOdmocnina));
        }
    }

    else if (prikaz == "/find")
    {
        Console.Write("Napíš vetu: ");
        string vstup= Console.ReadLine();
        Console.Write("Čo chceš nájsť: ");
        string hladanyText=Console.ReadLine();
        if (NajdiSlovo(vstup, hladanyText) == true)
        {
            Console.Write("Tento text sa tam nachádza :).");
        }
        else
        {
            Console.WriteLine("Tento text sa tam nenachádza :(.");
        }
    }
    else if (prikaz=="/help")
    {
        Console.WriteLine("Toto sú príkazy, ktoré môžeš použiť:");
        Console.WriteLine("/sum --> Toto je základná kalkulačka.");
        Console.WriteLine("/odmocni --> Toto ti odmocni číslo");
        Console.WriteLine("/find -->Toto ti povie či sa v texte nachádza určité slovo.");
    }
}
if (prikaz == "/exit")
{
    return;
}