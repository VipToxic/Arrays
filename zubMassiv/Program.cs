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

            int dlina = myArray[0].Length; // Храним первый элемент массива
            int dlina2 = 0; // для того чтобы хранит индекс элемента

            for (int i = 1; i < myArray.Length; i++) // i = 1 потому что предыдуший элемент уже храниться в переменной dlina
            {
                
                if (myArray[i].Length > dlina) // Проверяем текуший элемент с предидушим на большее или меньше
                {
                    dlina = myArray[i].Length; // Если true то меняем местами
                    dlina2 = i; // и меняем инддекс
                }
                
            }
            Console.WriteLine("Самая длинная строка: " + (dlina2 + 1));
            Console.WriteLine("Количество элементов: " + dlina);
            
        }
    }
}