namespace ULOHA_2b;

class Program
{
    static void Main(string[] args)
    {
        void IsGreater(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("Number ONE is bigger");
            }
            else
            {
                Console.WriteLine("Number TWO is bigger.");
            }
        }
        Console.WriteLine("Enter a numbers and I will tell you which is greater.");
        string input1 = Console.ReadLine();
        if (!int.TryParse(input1, out int numberOne))
        {
            Console.WriteLine("Error: The input is not a number.");
        }
        string input2 = Console.ReadLine();
        if (!int.TryParse(input2, out int numberTwo))
        {
            Console.WriteLine("Error: The input is not a number.");
        }
        IsGreater(numberOne, numberTwo);    }
}