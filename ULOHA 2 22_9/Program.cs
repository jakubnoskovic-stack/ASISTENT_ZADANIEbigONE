List<int> SpojListy(List<int> CiselnyZoznam1, List<int> CiselnyZoznam2)
{
    List<int> SpojeneZoznamy = new List<int>();
    SpojeneZoznamy.AddRange(CiselnyZoznam1);
    SpojeneZoznamy.AddRange(CiselnyZoznam2);
    return SpojeneZoznamy;
}
List<int> CiselnyZoznam1=new List<int>();
List<int> CiselnyZoznam2=new List<int>();
CiselnyZoznam1.Add(1);
CiselnyZoznam1.Add(2);
CiselnyZoznam1.Add(3);
CiselnyZoznam2.Add(4);
CiselnyZoznam2.Add(5);
CiselnyZoznam2.Add(6);

List<int> SpojeneZoznamy=new List<int>();
SpojeneZoznamy.AddRange(SpojListy(CiselnyZoznam1, CiselnyZoznam2));
for (int i = 0; i < SpojeneZoznamy.Count; i++)
{
    Console.WriteLine(SpojeneZoznamy[i]);
}
