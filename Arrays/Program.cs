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
        }
    }
}
