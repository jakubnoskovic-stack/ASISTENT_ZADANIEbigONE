using System;

void VykonajSum()
{
    Console.Write("Zadaj prvé číslo: ");
    double cislo1;
    while (!double.TryParse(Console.ReadLine(), out cislo1))
    {
        Console.Write("Toto nie je číslo. Skús znova: ");
    }

    Console.Write("Zadaj druhé číslo: ");
    double cislo2;
    while (!double.TryParse(Console.ReadLine(), out cislo2))
    {
        Console.Write("Toto nie je číslo. Skús znova: ");
    }

    double vysledok = cislo1 + cislo2;
    Console.WriteLine(cislo1 + " + " + cislo2 + " = " + vysledok);
}

void VykonajOdm()
{
    Console.Write("Zadaj číslo na odmocnenie: ");
    double cislo;
    while (!double.TryParse(Console.ReadLine(), out cislo) || cislo < 0)
    {
        if (cislo < 0)
        {
            Console.Write("Odmocnina zo záporného čísla neexistuje. Zadaj číslo >= 0: ");
        }
        else
        {
            Console.Write("Toto nie je číslo. Skús znova: ");
        }
    }

    double vysledok = Math.Sqrt(cislo);
    Console.WriteLine("Odmocnina z " + cislo + " je " + vysledok);
}

void VykonajFind()
{
    Console.Write("Napíš vetu: ");
    string vstup = Console.ReadLine();
    Console.Write("Čo chceš nájsť: ");
    string hladaneSlovo = Console.ReadLine();

    if (vstup.ToLower().Contains(hladaneSlovo.ToLower()))
    {
        Console.WriteLine("Tento text sa tam nachádza.");
    }
    else
    {
        Console.WriteLine("Tento text sa tam nenachádza.");
    }
}

void VykonajHelp()
{
    Console.WriteLine("Podporované príkazy:");
    Console.WriteLine("  sum    - sčítanie dvoch čísel");
    Console.WriteLine("  odm    - odmocnina zo zadaného čísla");
    Console.WriteLine("  find   - nájde podreťazec vo vete");
    Console.WriteLine("  rect   - zapne mód merania obdĺžnikov");
    Console.WriteLine("  array  - zapne mód práce s poľom");
    Console.WriteLine("  help   - vypíše podporované príkazy");
    Console.WriteLine("  exit   - ukončí program");
}

double VypocitajObsah(double a, double b)
{
    return a * b;
}

double VypocitajObvod(double a, double b)
{
    return 2 * (a + b);
}

double VypocitajUhlopriecku(double a, double b)
{
    return Math.Sqrt(a * a + b * b);
}

void VykonajRect()
{
    Console.WriteLine("Ideme merať obdĺžnik.");
    
    double a;
    Console.Write("Zadaj dĺžku prvej strany: ");
    while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
    {
        Console.Write("Strana musí byť číslo väčšie ako 0. Skús znova: ");
    }

    double b;
    Console.Write("Zadaj dĺžku druhej strany: ");
    while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
    {
        Console.Write("Strana musí byť číslo väčšie ako 0. Skús znova: ");
    }

    Console.WriteLine("Máme obdĺžnik o rozmeroch " + a + "x" + b + ", čo chceš vypočítať? (area, perimeter, diagonal)");

    while (true)
    {
        Console.Write("> ");
        string prikaz = Console.ReadLine();

        if (prikaz == "exit")
        {
            break;
        }
        else if (prikaz == "area")
        {
            Console.WriteLine("Obsah obdĺžnika je " + VypocitajObsah(a, b));
        }
        else if (prikaz == "perimeter")
        {
            Console.WriteLine("Obvod obdĺžnika je " + VypocitajObvod(a, b));
        }
        else if (prikaz == "diagonal")
        {
            Console.WriteLine("Uhlopriečka obdĺžnika je " + VypocitajUhlopriecku(a, b));
        }
        else
        {
            Console.WriteLine("Neznámy príkaz pre obdĺžnik. Použi: area, perimeter, diagonal alebo exit.");
        }
    }
}

void VykonajArray()
{
    Console.Write("Zadaj číselné pole (čísla oddelené medzerou): ");
    
    int[] pole = null;
    while (pole == null)
    {
        string vstup = Console.ReadLine();
        string[] casti = vstup.Split(' ');
        
        int pocetCisel = 0;
        for (int i = 0; i < casti.Length; i++)
        {
            if (casti[i] != "")
            {
                pocetCisel++;
            }
        }

        if (pocetCisel == 0)
        {
            Console.Write("Pole nesmie byť prázdne. Skús znova: ");
            continue;
        }

        bool jePlatne = true;
        int[] docasnePole = new int[pocetCisel];
        int indexDocasneho = 0;

        for (int i = 0; i < casti.Length; i++)
        {
            if (casti[i] != "")
            {
                if (!int.TryParse(casti[i], out docasnePole[indexDocasneho]))
                {
                    jePlatne = false;
                    break;
                }
                indexDocasneho++;
            }
        }

        if (jePlatne)
        {
            pole = docasnePole;
        }
        else
        {
            Console.Write("Zadal si neplatné číslo. Zadaj celé čísla oddelené medzerou: ");
        }
    }

    Console.WriteLine("Čo chceš spraviť s poľom? (find, min, sort, exit)");

    while (true)
    {
        Console.Write("> ");
        string prikaz = Console.ReadLine();

        if (prikaz == "exit")
        {
            break;
        }
        else if (prikaz == "find")
        {
            Console.Write("Aké číslo chceš nájsť? ");
            int hladane;
            while (!int.TryParse(Console.ReadLine(), out hladane))
            {
                Console.Write("Toto nie je platné číslo. Skús znova: ");
            }

            int index = -1;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == hladane)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine("Hodnota " + hladane + " sa nachádza v poli na pozícii " + (index + 1) + ".");
            }
            else
            {
                Console.WriteLine("Hodnota " + hladane + " sa v poli nenachádza.");
            }
        }
        else if (prikaz == "min")
        {
            int min = pole[0];
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < min)
                {
                    min = pole[i];
                }
            }
            Console.WriteLine("Minimálna hodnota v poli je: " + min);
        }
        else if (prikaz == "sort")
        {
            for (int i = 0; i < pole.Length - 1; i++)
            {
                for (int j = i + 1; j < pole.Length; j++)
                {
                    if (pole[i] > pole[j])
                    {
                        int docasna = pole[i];
                        pole[i] = pole[j];
                        pole[j] = docasna;
                    }
                }
            }

            Console.Write("Pole bolo zoradené: ");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Neznámy príkaz pre pole. Použi: find, min, sort alebo exit.");
        }
    }
}

Console.WriteLine("Ahoj, som tvoj osobný asistent. Pre zoznam príkazov napíš 'help'.");

while (true)
{
    Console.Write("Zadaj príkaz: ");
    string prikaz = Console.ReadLine();

    if (prikaz == "exit")
    {
        break;
    }
    else if (prikaz == "sum")
    {
        VykonajSum();
    }
    else if (prikaz == "odm")
    {
        VykonajOdm();
    }
    else if (prikaz == "find")
    {
        VykonajFind();
    }
    else if (prikaz == "rect")
    {
        VykonajRect();
    }
    else if (prikaz == "array")
    {
        VykonajArray();
    }
    else if (prikaz == "help")
    {
        VykonajHelp();
    }
    else
    {
        Console.WriteLine("Neznámy príkaz. Skús znova alebo napíš 'help'.");
    }
}