namespace заполнение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы: ");

            Console.Write("Количиство строк: ");
            int matrix1 = int.Parse(Console.ReadLine());

            Console.Write("Количиство столбцов: ");
            int matrix2 = int.Parse(Console.ReadLine());

            int[,] myArray = new int[matrix1, matrix2];

            Console.WriteLine("Введите диапазон чисел");
            Console.Write("Первое число: ");
            int diapazon = int.Parse(Console.ReadLine());

            Console.Write("Второе число: ");
            int diapazon2 = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(diapazon, diapazon2 + 1);
                } 
            }

            for (int i = 0;i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
