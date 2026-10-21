/*
//úloha 1
Console.WriteLine("Napíš číslo: ");
int cislo;
while (!int.TryParse(Console.ReadLine(), out cislo))
{
    Console.WriteLine("Nezadal si číslo. Musíš zadať číslo: ");
}
for (int i = 1; i <= cislo; i++)
{
    if (cislo %i==0)
    {
        Console.WriteLine("Tvoje číslo je delitelné " + i);
    }
}
*/

/*
//úloha 2
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine("Som trpaslík"+i+" a spolu je nás 100");
}
*/

/*
//úloha 3
Console.WriteLine("naíš vetu:");
string veta=Console.ReadLine();
int i = 0;
while ( veta[i] != '!')
{
    i++;
}

i++;
Console.WriteLine(" ! ja na "+i+" pozícií.");
*/

//úloha 5
Console.WriteLine("napis lubovolnu vetu");
string veta=Console.ReadLine();
Console.WriteLine("napis znak ktory najdem vo vete: ");
char znak;
while (!char.TryParse(Console.ReadLine(), out znak))
{
    Console.WriteLine("toto neni znak");
}
