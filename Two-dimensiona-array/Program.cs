namespace Two_dimensiona_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
                    Console.Write(nums2[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] myArray = new int[3, 5];

            myArray[0,2] = 99;
            
            Console.WriteLine(myArray[0,2]);
            */

            int[,] playAreaFloor = new int[,] 
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
            };

            for (int i = 0; i <  playAreaFloor.GetLength(0); i++)
            {
                for (int j = 0; j < playAreaFloor.GetLength(1); j++)
                {
                    Console.Write(playAreaFloor[i, j] + " ");
                }
                Console.WriteLine();
            };

            Console.WriteLine();
            playAreaFloor[2, 3] = 99;

            Console.WriteLine(playAreaFloor[0, 2]);
            Console.WriteLine(playAreaFloor[1, 1]);
            Console.WriteLine(playAreaFloor[2, 3]);

            Console.WriteLine();
            int[,] matrix = new int[,]
            {
                {10, 20, 30},
                {40, 50, 60},
                {70, 80, 90},
                {100, 110, 120}
            };

            matrix[1, 1] = 500;
            matrix[3, 2] = 999;

            Console.WriteLine(matrix[0, 1]);
            Console.WriteLine(matrix[2, 0]);
            Console.WriteLine(matrix[1, 1]);
            Console.WriteLine(matrix[3, 2]);

            int sum = 0;
            int[,] numbers =
            {
                { 5, 8, 2 },
                { 7, 1, 9 },
                { 4, 6, 3 }
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sum += numbers[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма равен: " + sum);


            int[,] numbers2 =
            {
                { 12, 7, 25 },
                { 4, 31, 9 },
                { 18, 2, 14 }
            };

            int largenumber = numbers2[0, 0];

            for (int i = 0; i < numbers2.GetLength(0); i++)
            {
                for (int j = 0; j < numbers2.GetLength(1); j++)
                {
                    if (numbers2[i, j] > largenumber)
                    {
                        largenumber = numbers2[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Самое большое число: " + largenumber);


            
            int[,] numbers3 =
            {
                { 15, 8, 23, 4 },
                { 7, 42, 11, 19 },
                { 31, 6, 17, 10 }
            };

            int smallNumbers = numbers3[0, 0];
            for (int i = 0; i < numbers3.GetLength(0); i++)
            {
                for (int j = 0; j < numbers3.GetLength(1); j++)
                {
                    if (numbers3[i, j] <= smallNumbers)
                    {
                        smallNumbers = numbers3[i, j];
                    }
                }
            }

            Console.WriteLine("Самое маленькое число: " + smallNumbers);



            
        }
    }
}