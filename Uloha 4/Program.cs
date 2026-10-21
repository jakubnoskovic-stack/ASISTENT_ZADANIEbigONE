Console.Write("Cena tovaru: ");
double cena = double.Parse(Console.ReadLine());
Console.Write("Zľavový kupón: ");
double kupon = double.Parse(Console.ReadLine());

double finalnaCena = VypocitajCenuPoZlave(cena, kupon);

Console.WriteLine($"Pôvodná cena: {cena} EUR");
Console.WriteLine($"Cena po zľave: {finalnaCena} EUR");
Console.ReadKey();


// --- TU DOPÍŠ FUNKCIU VypocitajCenuPoZlave ---
double VypocitajCenuPoZlave(double povodnaCena,double ZlavaVEurach)
{
    while (ZlavaVEurach>=povodnaCena)
    {
        Console.Write("Zlava nemôže byť väčšia ako Pôvodná cena! Skús Znova: ");
        ZlavaVEurach= double.Parse(Console.ReadLine());
    }
    double VyslednaCena=povodnaCena-ZlavaVEurach;
    return VyslednaCena;
}