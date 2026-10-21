namespace hodina_22_9;

class Program
{
    static void Main(string[] args)
    {
        Boolean IsEven (int i)
        {
            Boolean pravda;
            if (i % 2 == 0)
            {
                pravda=true;
            }
            else
            {
                pravda = false;
            }
            return pravda;
        }
        Console.WriteLine("Enter a number and I will tell you if it is even.");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            if (IsEven(number))
                Console.WriteLine("Yes, yes, the number is even.");
            else
                Console.WriteLine("This is odd, this number is odd.");
        }
        else
        {
            Console.WriteLine("Error: The input is not a number.");
        }
       
        
    }
}