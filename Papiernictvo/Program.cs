using System.Security.Cryptography.X509Certificates;

namespace papiernictvo;

class Zakaznik
{
    public string meno;
    public string e_mail;
    public string adresa;
}

class produkt
{
    public double cena;
    public string nazov;
}

class Objednavka
{
    public int id;
    public Zakaznik objednavatel;
    public List<produkt> Polozky = new List<produkt>();
}

class Program
{
    static void Main(string[] args)
    {
        Zakaznik Peto = new Zakaznik();
        Peto.meno = "Peto";
        Peto.e_mail = "peto.v@najskola.sk";
        Peto.adresa = "trnavova 4 Trnava";

        produkt prod1 = new produkt();
        prod1.nazov = "Pracka";
        prod1.cena = 999;

        produkt prod2 = new produkt();
        prod2.nazov = "zehlicka";
        prod2.cena = 120;

        Objednavka PrvaObjednavka = new Objednavka();
        PrvaObjednavka.id = 1;
        PrvaObjednavka.objednavatel = Peto;
        PrvaObjednavka.Polozky.Add(prod1);
        PrvaObjednavka.Polozky.Add(prod2);

        Console.WriteLine($"Zakaznik ");
    }
}