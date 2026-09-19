namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums2 = new int[10]; // Создали массив на 10 элементов

            nums2[3] = 10; // на 3 индекс поместили значение 10

            Console.WriteLine(nums2[3]); // Вывод значение

            nums2[2] = 6;
            nums2[1] = 7;
            Console.WriteLine(nums2[2] + nums2[1]); // Ну тут все понятно

            int a = nums2[3];
            Console.WriteLine(a + 100);

            Console.WriteLine("\t");


            //Практика
            int[] nums3 = new int[5] { 10, 20, 30, 40, 50 }; 

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nums3[i]);
            }

            Console.WriteLine("\t");

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum = sum + numbers[i];
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Сумма чисел равен:" + sum);


            //19.09.2026
            int[] myAroy = Enumerable.Repeat(5, 10).ToArray();
            int[] myAroy2 = Enumerable.Range(4, 5).ToArray();
            Console.ReadLine();

        }
    }
}
