namespace index_diopazon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Index moon = ^1;

            Console.WriteLine($"Value {moon.Value} и IsFromEnd {moon.IsFromEnd}");
        }
    }
}