namespace Sum_Of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <=number; i++)
            {
                int currentNumber=int.Parse(Console.ReadLine());
                sum+= currentNumber;
                if (sum >= number)
                {
                    break;
                }

            }
            Console.WriteLine(sum);
        }
    }
}