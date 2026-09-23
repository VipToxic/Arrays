namespace index_diopazon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };

            Index index = 2; // Value равен к 2 а IsFromEnd к false
            Console.WriteLine(numbers[index]);
            Console.WriteLine(index.Value + " " + index.IsFromEnd);

            // Value хранит индекс массива а IsFromEnd направление с конца или с начало
            // если с конца то true если наоборот то false
            Index index2 = ^2; // Value равен к 2 а IsFromEnd к true
            Console.WriteLine(numbers[index2]);
            Console.WriteLine(index2.Value + " " + index2.IsFromEnd);

            // Конструктор Index() создает два значение первый числовое значение второй true или false с конца или с начало
            // Второй же обьект это IsFromEnd оно указывает направление 
            Index index3 = new Index(2, true); // Это то же самое что ^2
            Console.WriteLine(index3); // ^2
            Console.WriteLine(numbers[index3]); // 70

            // ".." Это диапазон например "1..4" взять все элементы с 1 до 4 НЕ включительно
            // Есть еще Range это тип данных и Range(.., ..); он принимает два значение и выполняет ту же функцию что и ".."

            // Использууем тип данных Range для создание диапазона
            Range range = 2..7;
            // Создаем массив на основе существуюшего
            int[] result = numbers[range];

            Console.WriteLine();

            // Выводдим все с помощью цикла for
            // result.Length потому что result меньше numbers
            // Втаком случае цикл вывел бы исключение о том что мы вышли за пределы массива
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]); // 30 40 50 60 70 (это написал до цикла как и все предсказание до этого)
            }
            Console.WriteLine();

            // Оператор " ^ " нужен для того чтобы брать элементы с конца массива
            // например ^1 будет равен к 80 а ^4 50
            // Если использовать в диапазоне то при выводе массива последний элемент не будет учтен
            int[] range2 = numbers[1..^1]; // результат равен к 20 30 40 50 60 70
            // Это я загуглил так как через WriteLine выводился System.Int32[]
            Console.WriteLine(string.Join(", ", range2)); // результат равен к 20, 30, 40, 50, 60, 70,
            Console.WriteLine();
            // Range это тип данных
            Range range3 = new Range(2, 5);
            Console.WriteLine(range3); // Выведет просто результат 2..5
            Console.WriteLine(string.Join(", ", numbers[range3])); // выведет 30, 40, 50

            Console.WriteLine();
            // Последняя задачка
            int[] health = { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };

            // Создаем отдельные переменные с диапазонами начало и конца
            Index start = ^8;
            Index end = ^2;
            Range range4 = start..end;

            int[] result2 = health[range4];
            for (int i = 0; i < result2.Length; i++)
            {
                Console.WriteLine(result2[i]);
            }




        }
    }
}