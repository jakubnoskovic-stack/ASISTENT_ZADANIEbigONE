namespace ULOHA_1c;

class Program
{
    static void Main()
    {
        int[] pole = { 2, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 27, 29 };
        int najvacieCislo = 0;
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
}