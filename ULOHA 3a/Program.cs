namespace ULOHA_3a;

class Program
{
    static void Main()
    {
        string NeznamaFunkia(string text, int cislo)
        {
            string vysledok = "";
            for (int i = 0; i < cislo; i++)
            {
                vysledok += text + " ";
            }

            return vysledok;
        }

        int cislo;
        Console.Write("Napiš najskôr slovo a potom cislo podla toho kolko krát mám vypísať to slovo: ");
        string slovo = Console.ReadLine();
        if (slovo == null)
        {
            Console.Write("musíš niečo zadať");
        }
    while (!int.TryParse(Console.ReadLine(), out cislo))
        {
            Console.Write("kamosko toto veruze neni cislo :(. SKÚS ZNOVA: ");
        }
            Console.WriteLine(NeznamaFunkia(slovo, cislo));
        
    }
}