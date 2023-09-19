namespace Sequence_of_Number_2K_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; result <= number; i++)
            {
                Console.WriteLine(result);
                result = 2*result + 1;
            }
            
        }
    }
}