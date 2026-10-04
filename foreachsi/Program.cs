namespace foreachsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = 
            {
                {1, 2, 3 },
                {3, 4, 5 }
            };

            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
