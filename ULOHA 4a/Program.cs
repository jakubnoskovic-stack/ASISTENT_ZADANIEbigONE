Console.Write("Napis cislo a ja ti poviem či je to prvočíslo: ");
int hladacPrvocisla;
while(!int.TryParse(Console.ReadLine(),out hladacPrvocisla))
{
    Console.Write("Toto veru, že nieje číslo. Skús znova: ");
}

for (int i = 1; i <= hladacPrvocisla; i++)
{
    if(i!=1)
    {
        if (hladacPrvocisla % i == 0)
        {
            Console.WriteLine("Toto nieje prvocielo. :(");
        }
       
    }
}