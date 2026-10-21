void Zvatsi(int[] pole)
{
    int plus = 7;
    for(int i=0;i<pole.Length;i++)
    {
        int vysledok=pole[i] + plus;
        Console.WriteLine(vysledok +" ");
        
    }
}
void ScitajPrvkyPola(int[] pole)
{
    int sucet = 0;
    for (int a = 0; a < pole.Length; a++)
    {
        sucet = sucet + pole[a];
    }
    Console.WriteLine("Toto je sucet pola: "+sucet);
}

void ZistiNajvacieCislo(int[] pole)
{
    int najvacieCislo=0;
    for (int i = 0; i < pole.Length; i++)
    {
        najvacieCislo=pole[i];
        if (pole[i] > najvacieCislo)
        {
            najvacieCislo = pole[i];
        }
    }
    Console.Write(najvacieCislo);
}
int[] pole = { 2, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 27, 29 };

Zvatsi(pole);
ScitajPrvkyPola(pole);
ZistiNajvacieCislo(pole);