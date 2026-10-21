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

    public Boolean VeberPeniaze(double sumaNaVyber)
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
        
    }
}