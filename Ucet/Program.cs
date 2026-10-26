namespace Uloha_2_21_10;

class ucet
{
    public string cislo;
    public double zostatok;
    public string majitel;

    public double VložPeniaze(double PriataSuma)
    {
        if (PriataSuma < 0)
        {
            Console.WriteLine("Nemôžeš vložiť zápornú hodnotu ani nulu.");
            return zostatok;
        }

        zostatok = zostatok + PriataSuma;
        return zostatok;
    }

    public Boolean VyberPeniaze(double sumaNaVyber)
    {
        if (sumaNaVyber > zostatok)
        {
            Console.WriteLine("Nemôžeš vybrať viac peňazý ako máš na učte.");
            return false;
        }
        else
        {
            zostatok = zostatok - sumaNaVyber;
        }

        return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        double ZiskajDouble()
        {
            double medzicislo;
            while (!double.TryParse(Console.ReadLine(), out medzicislo))
            {
                Console.Write("Toto nieje cislo. Skus znova: ");
            }

            return medzicislo;
        }
        
        ucet Ucet1=new ucet();
        Ucet1.majitel = "Janko";
        Ucet1.zostatok = 1000;

        ucet Ucet2 = new ucet();
        Ucet2.majitel = "Ferko";
        Ucet2.zostatok = 300;


        double Ucet2VyberPenaziCislo=ZiskajDouble();
        Ucet2.VyberPeniaze(Ucet2VyberPenaziCislo);

        double Ucet2VlozeniePeniazeCislo=ZiskajDouble();
        Ucet2.VložPeniaze(Ucet2VlozeniePeniazeCislo);


        double Ucet1VkladPenaziCislo = ZiskajDouble();
        Ucet1.VložPeniaze(Ucet1VkladPenaziCislo);

        double ucet1VyberPeniazeCislo = ZiskajDouble();
        Ucet1.VyberPeniaze(ucet1VyberPeniazeCislo);
    }
}