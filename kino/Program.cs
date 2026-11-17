namespace kino;

class Film
{
    public string Meno_Filmu;
    public int Dlzka_Filmu;
    
    public void Vypis_film()
    {
        Console.WriteLine(Meno_Filmu + " (" + Dlzka_Filmu + " min)");
    }
}

class Divak
{
    public string Meno_Divaka;
}

class Predstavenie
{
    public List<Divak> Zoznam_Divakov_Predstavenia = new List<Divak>();
    
    public int Pocet_Volnych_Miest;
    public Film Film_Predstavenia;
    
    public void Pridaj_Divaka()
    {
        Console.Write("Jak sa volá tvoj Divák?: ");
        string divak1 = Console.ReadLine();
        Divak DivakA =new Divak();
        DivakA.Meno_Divaka = divak1;
        if (Pocet_Volnych_Miest > 0)
        {
            Zoznam_Divakov_Predstavenia.Add(DivakA);
            Pocet_Volnych_Miest--;
            Console.WriteLine("Si in!");
        }
        else
        {
            Console.WriteLine("Je vypredané!");
        }
    }

    public void Vypis_Predstavenie()
    {
        Film_Predstavenia.Vypis_film();
        for (int i = 0; i < Zoznam_Divakov_Predstavenia.Count; i++)
        {
            Console.Write(Zoznam_Divakov_Predstavenia[i].Meno_Divaka + ", ");
        }
        Console.WriteLine("Pocet Volnych miest: "+Pocet_Volnych_Miest);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Film Vesmirna_Misia = new Film();
        Vesmirna_Misia.Meno_Filmu = "Vesmírna misia";
        Vesmirna_Misia.Dlzka_Filmu = 120;

        Predstavenie Prve_Predstavenie = new Predstavenie();
        Prve_Predstavenie.Pocet_Volnych_Miest = 2;
        Prve_Predstavenie.Film_Predstavenia = Vesmirna_Misia;
        
        Prve_Predstavenie.Pridaj_Divaka();
        Prve_Predstavenie.Pridaj_Divaka();
        Prve_Predstavenie.Pridaj_Divaka();
        
        Prve_Predstavenie.Vypis_Predstavenie();
    }
}