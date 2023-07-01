using FinalProjectInterface;

namespace FinalProjectInterface
{
    internal class Program
    {
        static IOperationNum num = new Calculator();
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите 1 число: ");
                int.TryParse(Console.ReadLine(), out int num1);
                Console.WriteLine("Введите 2 число: ");
                int.TryParse(Console.ReadLine(), out int num2);
                Calculator calculator = new Calculator();
                Console.WriteLine(calculator.Operation(num1, num2));

                Calculator2 calculator2 = new Calculator2(num);
                Calculator3 calculator3 = new Calculator3(num);
                Calculator4 calculator4 = new Calculator4(num);

                calculator2.OperationWithNum(num1, num2);
                calculator3.OperationWithNum(num1, num2);
                calculator4.OperationWithNum(num1, num2);
            }
            catch (Exception ex)
            {
                if (ex is FormatException) Console.WriteLine("Вы ввели неверное значение.");
                else Console.WriteLine($"Ошибка: {ex}");
            }
            Console.ReadKey();
        }
        internal interface IOperationNum
        {
            internal int Operation(int x, int y);
        }
        class Calculator : IOperationNum
        {
            public int Operation(int x, int y) 
            { 
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                return x + y; 
            }
        }
        public interface IOperation
        {
            void OperationWithNum(int x, int y);
        }
    }
}