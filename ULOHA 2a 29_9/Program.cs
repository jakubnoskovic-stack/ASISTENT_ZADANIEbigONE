int[] pole1 = { 7, 12, 9, 7, 3, 5 };
int[] pole2 = new int[pole1.Length];

for (int i = 0; i < pole1.Length; i++)
{
    pole2[i] = pole1[i];
    Console.WriteLine(pole2[i]);
}