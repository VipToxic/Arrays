using System.ComponentModel.DataAnnotations;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Практика 1: Заполнить массив с клавиатуры
                Console.Write("Введите размер массива: ");
                int numbers = int.Parse(Console.ReadLine());

                // Создали размер массива
                int[] keybordArray = new int[numbers];
                Console.WriteLine("Размер массива:" + numbers);


                for (int i = 0; i < numbers; i++)
                {
                    // Просим пользователя вести данные в массив
                    Console.Write($"\nВведите {i + 1} вое число: "); // i + 1 потому что i изначально равен к 0
                    int input = int.Parse(Console.ReadLine());
                    keybordArray[i] = input;
                }

                // Выводим созданный массив перебирая каждое число в массиве
                Console.WriteLine("\n-----------Созданый массив-----------");
                for (int i = 0; i < keybordArray.Length; i++)
                {
                    Console.Write($"[{keybordArray[i]}]");
                }


                Console.WriteLine();
                // Практика 2: Вывести массив в обрятном порядке

                // так как жо этого через клавиатуру создаеться массив
                // его не нужно создавать снова

                Console.WriteLine("\n----Массив в обраном порядке----");
                for (int i = 1; i <= keybordArray.Length; i++)
                {
                    //Выводим массив в обратном порядке
                    Console.Write($"[{keybordArray[keybordArray.Length - i]}]");
                }

                Console.WriteLine();
                Console.WriteLine("\n----Проверка массива на четность----");
                // Практика 3: Найти сумму четных и нечетных чисел

                // Используем тот же массив

                int evenNumberSum = 0;
                int oddNumberSum = 0;

                for (int i = 0; i < keybordArray.Length; i++)
                {
                    // Проверяем на четность и нечетность
                    if (keybordArray[i] % 2 == 0)
                    {
                        evenNumberSum += keybordArray[i];
                    }
                    else
                    {
                        oddNumberSum += keybordArray[i];
                    }
                }

                Console.WriteLine("Сумма четных чисел: " + evenNumberSum);
                Console.WriteLine("Сумма нечетных чисел: " + oddNumberSum);
                Console.WriteLine("Общая сумма чисел: " + (evenNumberSum + oddNumberSum));



                Console.WriteLine();
                Console.WriteLine("----Найти наименьшее число----");
                //Практика 4: Найти наименьшее число в массиве

                // Создаем переменную где будет хранится первый элемент
                int theSmallestNumber = keybordArray[0];

                for (int i = 1; i < keybordArray.Length; i++)
                {
                    // После чего проверяем второй элемент с первым
                    if (keybordArray[i] <= theSmallestNumber)
                    {
                        // Если текущий элемент меньше сохранённого минимального числа
                        // запоминаем текущий элемент как новый минимум если нет то пропускаем
                        theSmallestNumber = keybordArray[i];
                    }

                }
                Console.WriteLine($"Наименьшее число: [{theSmallestNumber}]");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Введите коректные данные: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Длина массива не может быть отрицательным: {ex.Message}");
            }
        }
    }
}