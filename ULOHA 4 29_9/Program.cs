string veta = Console.ReadLine();
string[] slova = veta.Split(' ');
int[] cisla = new int[slova.Length];
for (int i = 0; i < slova.Length; i++)
{
    if (int.TryParse(slova[i], out int cislo))
    {
        cisla[i] = cislo;
        slova[i] = "";
    }
    else
    {
        cisla[i] = 0;
    }
}

for (int i = 0; i < cisla.Length - 1; i++)
{
    for (int j = 0; j < cisla.Length - 1 - i; j++)
    {
        if (cisla[j] > cisla[j + 1])
        {
            int pomocna = cisla[j];
            cisla[j] = cisla[j + 1];
            cisla[j + 1] = pomocna;
        }
    }
}


Console.WriteLine("Zoradené pole:");
foreach (int c in cisla)
{
    Console.Write(c + " ");
}