namespace texmerniyemassiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] trex = new int[3, 10, 5];
            Random random = new Random();

            for (int i = 0; i < trex.GetLength(0); i++)
            {
                for (int j = 0; j < trex.GetLength(1); j++)
                {
                    for ( int k = 0; k < trex.GetLength(2); k++)
                    {
                        trex[i, j, k] = random.Next(100);  
                    }
                }
            }

            for (int i = 0; i < trex.GetLength(0); i++)
            {
                Console.WriteLine("Страница: " + (i + 1));
                for (int j = 0; j < trex.GetLength(1); j++)
                {
                    for (int k = 0; k < trex.GetLength(2); k++)
                    {
                        Console.Write(trex[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }



        }
    }
}