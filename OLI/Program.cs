double VypocitajZlavu(string cenaString, string zlavaString)
{
    double cena=double.Parse(cenaString);
    double zlava=double.Parse(zlavaString);
    double vysledok = cena - (cena * (zlava / 100));
    return vysledok;
}
Console.Write("Cena: ");
string cena=Console.ReadLine();
Console.Write("Zlava: ");
string zlava=Console.ReadLine();
Console.Write("toto je cena so zlavou: " + VypocitajZlavu(cena,zlava));
