namespace ULOHA_3b;

class Program
{
    static void Main()
    {
        string NeznamaFunkia(string text, int cislo,string pretext, string posttext)
        {
            string vysledok = "";
            for (int i = 0; i < cislo; i++)
            {
                vysledok += pretext;   
                vysledok += text + " ";
                vysledok += posttext;
            }

            return vysledok;
        }

        int cislo;
        Console.Write("Napiš najskôr slovo, potom napis slovo co pojde pred tym, potom slovo co pojde za povodnym slovom a potom cislo podla toho kolko krát mám vypísať to slovo: ");
        string slovo = Console.ReadLine();
        if (slovo == null)
        {
            Console.Write("musíš niečo zadať");
        }
        string pretext = Console.ReadLine();
        if (pretext == null)
        {
            Console.Write("musíš niečo zadať");
        }
        string posttext = Console.ReadLine();
        if (posttext == null)
        {
            Console.Write("musíš niečo zadať");
        }
        while (!int.TryParse(Console.ReadLine(), out cislo))
        {
            Console.Write("kamosko toto veruze neni cislo :(. SKÚS ZNOVA: ");
        }
        Console.WriteLine(NeznamaFunkia(slovo, cislo,pretext, posttext));
    }
}