using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

void VykonajFind()
{
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

    Console.Write("Napíš vetu: ");
    string vstup = Console.ReadLine();
    Console.Write("Čo chceš nájsť: ");
    string hladanyText = Console.ReadLine();
    if (NajdiSlovo(vstup, hladanyText) == true)
    {
        Console.WriteLine("Tento text sa tam nachádza :).");
    }
    else
    {
        Console.WriteLine("Tento text sa tam nenachádza :(.");
    }
}

void UrobSum()
{
    double spočítaj(double input1, double input2)
    {
        double vysledok = input1 + input2;
        return vysledok;
    }

    double odčítaj(double input1, double input2)
    {
        double vysledok = input1 - input2;
        return vysledok;
    }

    double vydel(double input1, double input2)
    {
        double vysledok = input1 / input2;
        return vysledok;
    }

    double vynasob(double input1, double input2)
    {
        double vysledok = input1 * input2;
        return vysledok;
    }

    Console.Write("Napíš prvé čislo na operáciu: ");
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
    while (PrikazSum != "/násob" && PrikazSum != "/vydel" && PrikazSum != "/sčítaj" && PrikazSum != "/odčítaj")
    {
        Console.Write("Toto nie je žiaden príkaz. Skús znova: ");
        PrikazSum = Console.ReadLine();
    }

    if (PrikazSum == "/sčítaj")
    {
        double vysledok = spočítaj(Cislo1, Cislo2);
        Console.WriteLine("Toto je vysledok: " + vysledok);
    }

    if (PrikazSum == "/odčítaj")
    {
        double vysledok = odčítaj(Cislo1, Cislo2);
        Console.WriteLine("Toto je vysledok: " + vysledok);
    }

    if (PrikazSum == "/vydel")
    {
        double vysledok = vydel(Cislo1, Cislo2);
        Console.WriteLine("Toto je vysledok: " + vysledok);
    }

    if (PrikazSum == "/násob")
    {
        double vysledok = vynasob(Cislo1, Cislo2);
        Console.WriteLine("Toto je vysledok: " + vysledok);
    }
}

void UrobOdmocnenie()
{
    double odmocni(double vklad)
    {
        double odmocnina = Math.Sqrt(vklad);
        return odmocnina;
    }

    double cisloOdmocnina;
    Console.Write("Napíš číslo na odmocnenie: ");
    while (!double.TryParse(Console.ReadLine(), out cisloOdmocnina))
    {
        Console.Write("Toto neni číslo. Skús znova: ");
    }

    Console.WriteLine("Toto je vysledok: " + odmocni(cisloOdmocnina));
}

void VykonajHelp()
{
    Console.WriteLine("Toto sú príkazy, ktoré môžeš použiť:");
    Console.WriteLine("/sum --> Toto je základná kalkulačka.");
    Console.WriteLine("/odmocni --> Toto ti odmocni číslo");
    Console.WriteLine("/find -->Toto ti povie či sa v texte nachádza určité slovo.");
    Console.WriteLine("/rect -->Toto ti pomoze s operáciamy na obdížniky.");
}

void VykonajRect()
{
    Console.WriteLine("Ak chceš vypočítať Obvod zadaj '/Obvod', ak chceš vypočítať obsah napíš '/Obsah' a ak chceš vypočítať uhlopriečku napíš '/Uhlopriečka'.");
    string prikaz = Console.ReadLine();
    while (prikaz != "/Obvod" && prikaz != "/Obsah" && prikaz != "/Uhlopriečka")
    {
        Console.Write("Toto nieje platný príkaz. Skús znova: ");
        prikaz=Console.ReadLine();
    }
    Console.WriteLine("Napíš stanu 'a' a potom stranu 'b': ");
    double a;
    double b;
    while (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Toto neni číslo. Skús znova: ");
        Console.ReadLine();
    }
    while (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Toto neni číslo. Skús znova: ");
        Console.ReadLine();
    }
    if (prikaz == "/Obvod")
    {
        double vysledok = 2 * (a + b);
        Console.WriteLine("Obvod obdĺžnika je "+vysledok);
    }

    if (prikaz == "/Obsah")
    {
        double vysledok = a * b;
        Console.WriteLine("Obsah obdĺžnika je "+vysledok);
    }

    if (prikaz == "/Uhlopriečka")
    {
        double vysledok = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Uhlopriečka obdĺžnika je " + vysledok);
    }
}

Console.WriteLine("Ahoj som tovoj osobný asistent, ktory ti pomôže s tvojimy ulohami.");
Console.WriteLine("Ak nevieš aké veci viem pre teba spraviť napíš '/help'");

string prikaz=Console.ReadLine();
while (prikaz!="/exit"&&prikaz!="/sum"&&prikaz!="/odmocni"&&prikaz!="/find"&&prikaz!="/help"&&prikaz!="/rect"&&prikaz!="/array")
{
   Console.Write("Toto neni príkaz. Skús znova: "); 
   prikaz=Console.ReadLine();
}
while(prikaz!="/exit")
{
    if (prikaz == "/sum")
    {
        UrobSum();
    }
    else if (prikaz == "/odmocni")
    {
      UrobOdmocnenie();  
    }

    else if (prikaz == "/find")
    {
        VykonajFind();
    }

    else if (prikaz == "/rect")
    {
        VykonajRect();
    }
    
    else if (prikaz=="/help")
    {
        VykonajHelp();
    }
    else if (prikaz=="/array")
    {
        Console.Write("Zadaj Vstupy do array: ");
        int vstup;
        while (!int.TryParse(Console.ReadLine(), out vstup))
        {
            Console.Write("Toto nie je číslo. Skús znova: ");
        }

        string vstupString = vstup.ToString();

        int[] Arrays = Array.ConvertAll(vstupString.Split(' '), s => int.Parse(s.Trim()));

    }
    Console.Write("Napíš další príkaz: ");
    prikaz = Console.ReadLine();
    while (prikaz!="/exit"&&prikaz!="/sum"&&prikaz!="/odmocni"&&prikaz!="/find"&&prikaz!="/help"&&prikaz!="/rect"&&prikaz!="/array")
    {
        Console.Write("Toto neni príkaz. Skús znova: "); 
        prikaz=Console.ReadLine();
    }

}
if (prikaz == "/exit")
{
    return;
}