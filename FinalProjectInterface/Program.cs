namespace FinalProjectInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 1 число: ");
                int.TryParse(Console.ReadLine(), out int num1);
                Console.WriteLine("Введите 2 число: ");
                int.TryParse(Console.ReadLine(), out int num2);
                Calculator calculator = new Calculator();
                Console.WriteLine(((ISumNum)calculator).Sum(num1, num2));
            }
            catch (Exception ex)
            {
                if (ex is FormatException) Console.WriteLine("Вы ввели неверное значение.");
                else Console.WriteLine($"Ошибка: {ex}");
            }
            Console.ReadKey();
        }
        interface ISumNum
        {
            int Sum(int x, int y);
        }
        class Calculator : ISumNum
        {
            int ISumNum.Sum(int x, int y) { return x + y; }
        }
    }
}