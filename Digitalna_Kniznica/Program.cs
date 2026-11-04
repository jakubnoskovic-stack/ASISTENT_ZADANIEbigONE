namespace Digitalna_Kniznica;

class navstevnici
{
    public string Meno_Navstevnika;
    public DateOnly Datum_Narodenia;
    public int id;
    
    public List<Kniha> Moje_Knihy = new List<Kniha>();
}

class Kniha
{
    public string Nazov_Knihy;
    public string Meno_Autora;
    public int Rok_Vydania;
    public Boolean Dostupnost_Knihy;
}

class Kniznica
{
    public List<Kniha> Zoznam_Knih = new List<Kniha>();
    public List<navstevnici> Zoznam_Navstevnikov = new List<navstevnici>();
    public void Pridaj_Knihu()
    {
        Kniha Kniha = new Kniha();
        Console.WriteLine("Nazov Knihy:");
        Kniha.Nazov_Knihy =Console.ReadLine().ToLower();
        Console.WriteLine("Meno Autora:");
        Kniha.Meno_Autora =Console.ReadLine().ToLower();
        Console.WriteLine("Rok Vydania");
        Kniha.Rok_Vydania =int.Parse(Console.ReadLine());
        Kniha.Dostupnost_Knihy = true;
        Zoznam_Knih.Add(Kniha);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kniznica Kniznica_Prva = new Kniznica();
        
        
        Console.WriteLine("Ak chceš pridať knihu tak napis 'pridaj' a ak chceš prestať pridavať napíš 'exit, Ak chces vypisat knihy podla autora napis 'autor', Ak chces vediet kolko je priemerne knih a kolko ich je napis 'riaditel', ak si chces pozicat knihu napis 'pozicaj'.");
        string prikaz = Console.ReadLine().ToLower();

        while (prikaz != "exit")
        {
            if (prikaz == "pridaj")
                do
                {
                    Kniznica_Prva.Pridaj_Knihu();
                    Console.WriteLine("ak chces znovu daj enter ak nie napis 'exit':");
                } while (Console.ReadLine().ToLower() != "exit");
            
            else if (prikaz == "autor")
            {
                Console.Write("Napíš meno autora: ");
                String Meno_Autora = Console.ReadLine().ToLower();

                for (int i = 0; i < Kniznica_Prva.Zoznam_Knih.Count; i++)
                {
                    if (Kniznica_Prva.Zoznam_Knih[i].Meno_Autora.Contains(Meno_Autora))
                    {
                        Console.WriteLine(Kniznica_Prva.Zoznam_Knih[i].Nazov_Knihy);
                        Console.WriteLine(Kniznica_Prva.Zoznam_Knih[i].Rok_Vydania);
                        if (Kniznica_Prva.Zoznam_Knih[i].Dostupnost_Knihy = true)
                        {
                            Console.WriteLine("Dostupna");
                        }
                        else
                        {
                            Console.WriteLine("Nedostupná");
                        }
                    }
                }
            }
            
            else if (prikaz == "riaditel")
            {
                double roky_spolu = 0;
                for (int i = 0; i < Kniznica_Prva.Zoznam_Knih.Count; i++)
                {
                    roky_spolu = +Kniznica_Prva.Zoznam_Knih[i].Rok_Vydania;
                }

                Console.WriteLine($"Kníh je {Kniznica_Prva.Zoznam_Knih.Count} a priemerne je {roky_spolu / Kniznica_Prva.Zoznam_Knih.Count}");
            }
            else if (prikaz == "pozicaj")
            {
                Console.WriteLine("ked budes chcieť prestat pridavat memberov napis 'exit'");
                int i = 0;

                do
                {
                    navstevnici navstevnik_prvy = new navstevnici();

                    navstevnik_prvy.id = i;
                    Console.WriteLine("Tvoje Meno:");
                    navstevnik_prvy.Meno_Navstevnika = Console.ReadLine();
                    Console.Write("Zadaj dátum narodenia (DD.MM.YYYY): ");
                    navstevnik_prvy.Datum_Narodenia = DateOnly.Parse(Console.ReadLine());

                    i++;

                    Kniznica_Prva.Zoznam_Navstevnikov.Add(navstevnik_prvy);
                } while (Console.ReadLine().ToLower() != "exit");



                do
                {
                    int cislo_membera_na_spitanie;
                    Console.Write("napis cislo membera ktoremu chces pridat knihu: ");
                    while (!int.TryParse(Console.ReadLine(), out cislo_membera_na_spitanie))
                    {
                        Console.Write("Toto nie je cislo. Skus znova: ");
                    }

                    Console.WriteLine("akú knihu si chces pozicat?: ");
                    string Nazov_Knihy_na_Pozicanie = Console.ReadLine();

                    for (int j = 0; j < Kniznica_Prva.Zoznam_Knih.Count; j++)
                    {
                        if (Kniznica_Prva.Zoznam_Knih[j].Nazov_Knihy.Contains(Nazov_Knihy_na_Pozicanie))
                        {
                            Console.WriteLine(Kniznica_Prva.Zoznam_Knih[j].Nazov_Knihy);
                            Console.WriteLine(Kniznica_Prva.Zoznam_Knih[j].Rok_Vydania);
                            if (Kniznica_Prva.Zoznam_Knih[j].Dostupnost_Knihy = true)
                            {
                                Console.WriteLine("Dostupna");
                                Console.WriteLine("");
                                Kniznica_Prva.Zoznam_Knih[j].Dostupnost_Knihy = false;
                                Kniznica_Prva.Zoznam_Navstevnikov[cislo_membera_na_spitanie].Moje_Knihy
                                    .Add(Kniznica_Prva.Zoznam_Knih[j]);
                                Console.WriteLine("pozicané ");
                            }
                            else
                            {
                                Console.WriteLine("Nedostupná");
                            }
                        }
                    }

                    Console.WriteLine("akú knihu si chces vratit?: ");
                    string Nazov_Knihy_na_vratenie = Console.ReadLine();

                    for (int j = 0; j < Kniznica_Prva.Zoznam_Knih.Count; j++)
                    {
                        if (Kniznica_Prva.Zoznam_Knih[j].Nazov_Knihy.Contains(Nazov_Knihy_na_vratenie))
                        {
                            Console.WriteLine(Kniznica_Prva.Zoznam_Knih[j].Nazov_Knihy);
                            Console.WriteLine(Kniznica_Prva.Zoznam_Knih[j].Rok_Vydania);
                            if (Kniznica_Prva.Zoznam_Knih[j].Dostupnost_Knihy = true)
                            {
                                Console.WriteLine("Dostupna");
                                Console.WriteLine("");
                                Kniznica_Prva.Zoznam_Knih[j].Dostupnost_Knihy = false;
                                Kniznica_Prva.Zoznam_Navstevnikov[cislo_membera_na_spitanie].Moje_Knihy
                                    .Add(Kniznica_Prva.Zoznam_Knih[j]);
                                Console.WriteLine("pozicané ");
                            }
                            else
                            {
                                Console.WriteLine("Nedostupná");
                            }
                        }

                        
                    }

                    prikaz = Console.ReadLine().ToLower();
                } while (Console.ReadLine() != "exit");
            }
        }
    }
}