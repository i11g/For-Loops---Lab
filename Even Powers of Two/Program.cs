namespace Even_Powers_of_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i <=number; i+=2)
            {
                Console.WriteLine(Math.Pow(2,i));                   
                            }
        }
    }
}