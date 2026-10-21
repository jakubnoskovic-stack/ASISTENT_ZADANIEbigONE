List<string> names=new List<string>();
names.Add("Jakub");
names.Add("Jan");
names.Add("Peder");
names.Add("Dano");
names.Add("Winnetou");
names.Add("Esmeralda");
names.Add("Sano");
names.Insert(0,"Aragorn");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}
