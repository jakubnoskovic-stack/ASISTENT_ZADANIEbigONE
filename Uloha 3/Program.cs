while (true)
{
    Console.Write("Zadaj vek návštevníka: ");
    string? vstup = Console.ReadLine();
    if (!int.TryParse(vstup, out int vek))
    {
        Console.WriteLine("\"" + vstup + "\" nie je platné číslo");
        continue;
    }
    bool mozeVstupit = JePlnolety(vek);
    if (mozeVstupit)
    {
        Console.WriteLine("Vstup povolený.");
    }
    else
    {
        Console.WriteLine("Vstup zakázaný. Si príliš mladý.");
    }
}

// --- TU DOPÍŠ FUNKCIU JePlnolety ---
Boolean JePlnolety(int ZadanyVek)
{
    if(ZadanyVek>=18)
    {
        return true;
    }

    return false;
}