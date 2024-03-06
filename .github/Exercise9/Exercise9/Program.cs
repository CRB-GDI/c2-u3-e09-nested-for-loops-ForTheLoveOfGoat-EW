namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // convert strings to int and read line
            Console.WriteLine("Enter row with ");
            int with = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many rows? ");
            int rows = Int32.Parse(Console.ReadLine());

            //print rows
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < with; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
} 