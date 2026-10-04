namespace zubMassiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[random.Next(1, 20 + 1)];
                for(int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(1, 20 + 1);
                }
            } 

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            int dlina = myArray[0].Length;
            int dlina2 = 0;

            for (int i = 1; i < myArray.Length; i++)
            {
                
                if (myArray[i].Length > dlina)
                {
                    dlina = myArray[i].Length;
                    dlina2 = i;
                }
                
            }
            Console.WriteLine("Самая длинная строка: " + (dlina2 + 1));
            Console.WriteLine("Количество элементов: " + dlina);
            
        }
    }
}