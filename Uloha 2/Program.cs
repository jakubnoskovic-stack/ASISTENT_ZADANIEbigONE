Console.Write("Zadaj svoje meno: ");
string meno = Console.ReadLine();

// Volanie funkcie
PrivitajPouzivatela(meno);

Console.ReadKey();

// --- TU DOPÍŠ FUNKCIU PrivitajPouzivatela—
void PrivitajPouzivatela(string VstupneMeno)
{
    Console.WriteLine($"Ahoj {VstupneMeno}, Sme radi, že si späť");
}