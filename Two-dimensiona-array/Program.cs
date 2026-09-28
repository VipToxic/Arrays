namespace Two_dimensiona_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Одномерный массив
            int[] nums1 = new int[] { 1, 2, 3, 4, 5};

            // Двумерный массив
            int[,] nums2 = {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 3, 1, 5 }
            };

            for (int i = 0; i < nums2.GetLength(0); i++)
            {
                for (int j = 0; j < nums2.GetLength(1); j++)
                {
                    Console.Write(nums2[i, j]);
                }
            }

            
        }
    }
}