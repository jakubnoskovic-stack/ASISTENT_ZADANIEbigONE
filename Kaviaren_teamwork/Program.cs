namespace Kaviaren_teamwork;

class Produkt
{
    public string Nazov_Produktu;
    public double Cena_Produktu;

    public void Vypis_Produkt()
    {
        Console.WriteLine("Názov: "+Nazov_Produktu);
        Console.WriteLine("Cena: "+Cena_Produktu);
    }
}

class Menu
{
    public List<Produkt> Zoznam_Produktov = new List<Produkt>();

    public void Pridaj_Do_Ponuky()
    {
        Produkt Novy_Produkt = new Produkt();
        Console.Write("čo chceš pridať?: ");
        Novy_Produkt.Nazov_Produktu = Console.ReadLine();
        Console.Write("Napis Cenu: ");
        while (!double.TryParse(Console.ReadLine(), out Novy_Produkt.Cena_Produktu))
        {
            Console.Write("Toto neni cislo skus znova: ");
        }
        Zoznam_Produktov.Add(Novy_Produkt);
    }

    public void Vypis_Menu()
    {
        if (Zoznam_Produktov.Count < 0)
        {
            for (int i = 0; i <= Zoznam_Produktov.Count;i++)
            {
                Zoznam_Produktov[i].Vypis_Produkt();
            }
        }
        else
        {
            Console.WriteLine("Nenachadza sa na menu ziaden produkt");
        }
    }

    public void Hladaj_podla_nazvu()
    {
        Console.WriteLine("Podla akeho mena to chces hladat?: ");
        String Meno=Console.ReadLine();
        for (int i = 0; i <= Zoznam_Produktov.Count; i++)
        {
            if (Zoznam_Produktov[i].Nazov_Produktu.Contains(Meno))
            {
                Zoznam_Produktov[i].Vypis_Produkt();  
            }
        }
    }

    public void Hladaj_Podla_Max_Ceny()
    {
        double cena;
        Console.WriteLine("Aka je tvoja max cena?: ");
        while (!double.TryParse(Console.ReadLine(), out cena))
        {
            Console.Write("Toto neni cislo skus znova: ");
        }
        for (int i = 0; i <= Zoznam_Produktov.Count; i++)
        {
            if (Zoznam_Produktov[i].Cena_Produktu<cena)
            {
                Zoznam_Produktov[i].Vypis_Produkt();  
            }
            
        }
    }
}

class Objednavka
{
    public List<Produkt> Produkty_Objednavky = new List<Produkt>();
    public string Meno_Zakaznika;

    public void Vypis_Objednavku()
    {
        Console.WriteLine("Meno Zákaznika: "+ Meno_Zakaznika);
        if (Produkty_Objednavky.Count < 0)
        {
            for (int i = 0; i <= Produkty_Objednavky.Count;i++)
            {
                Produkty_Objednavky[i].Vypis_Produkt();
            }
        }
        else
        {
            Console.WriteLine("Nenachadza sa v objednavke ziaden produkt");
        }

        double Spolu;
        for (int i = 0; i <= Produkty_Objednavky.Count;i++)
        {
            Spolu =+Produkty_Objednavky[i].Cena_Produktu;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        
    }
}