class Program
{
    static void Main(string[] args)
    {
        int[] pole = { 2, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 27, 29 };
        int sucet = 0;
        for (int a = 0; a < pole.Length; a++)
        {
            sucet = sucet + pole[a];
        }
        Console.WriteLine(" toto je sucet pola: "+sucet);
    }
}