/*
//úloha 1
Console.WriteLine("Naíš svoj rok narodenia: ");
string rok_narodenia =Console.ReadLine();
int rok_narodenia_int;
while(!int.TryParse(rok_narodenia, out rok_narodenia_int))
{
    Console.WriteLine("Musíš zadať číslo! Zadaj znova!: ");
}

if (2026-rok_narodenia_int >= 18)
{
    Console.WriteLine("možeš vstúpiť.");
}
else
{
    Console.WriteLine("nemožeš vstúpiť.");

}
*/

/*
//úloha 2
Console.Write("Zadaj číslo vstupenky: ");
string vstupenka=Console.ReadLine();
if (vstupenka[0] == '9' && vstupenka[1]=='9')
{
    Console.WriteLine("Máš VIP vstup.");
}
else
{
    Console.WriteLine("Máš obyčajný vstup.");
}
*/

/*
//úloha 3
Console.WriteLine("Ako sa voláš: ");
string Ivan=Console.ReadLine().ToLower();
if (Ivan == "ivan")
{
    Console.WriteLine("Nesmieš vojsť");
}
else
{
    Console.WriteLine("Môžeš vojsť");
}
*/


//úloha 4
Console.WriteLine("Naíš svoj rok narodenia: ");
string rok_narodenia =Console.ReadLine();
int rok_narodenia_int;
while(!int.TryParse(rok_narodenia, out rok_narodenia_int))
{
    Console.WriteLine("Musíš zadať číslo! Zadaj znova!: ");
}
Console.Write("Zadaj číslo vstupenky: ");
string vstupenka=Console.ReadLine();
Console.WriteLine("Ako sa voláš: ");
string Ivan=Console.ReadLine().ToLower();
if (2026 - rok_narodenia_int >= 18 && vstupenka[0] == '9' && vstupenka[1] == '9' && Ivan != "ivan")
{
    Console.WriteLine("Môžeš vstupiť.");
}
else
{
    Console.WriteLine("Nesmieš vstpiť.");
}
