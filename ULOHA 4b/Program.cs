int cislo = 2;
while(cislo<1000000)
{
    Boolean prvocislo = true;
    for (int i = 0; i < cislo; i++)
    {
        if (i != 0 && i != 1)
        {
            if (cislo % i == 0)
            {
                prvocislo = false;
                break;
            }
        }
    }

    if (prvocislo == true)
    {
        Console.WriteLine(cislo);
    }

    cislo++;
}