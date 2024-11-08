using System.Text;

namespace CalculatorApp
{
    internal class CalculatorApp
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (args.Length != 3)
            {
                Console.WriteLine("Невірна кількість аргументів.");
                return;
            }

            double firstNumber = double.Parse(args[0]);
            double secondNumber = double.Parse(args[1]);
            string operation = args[2];

            Console.WriteLine($"Перший аргумент: {firstNumber}");
            Console.WriteLine($"Другий аргумент: {secondNumber}");
            Console.WriteLine($"Операція: {operation}");

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        Console.WriteLine("Помилка: ділення на нуль.");
                    return;
                default:
                    Console.WriteLine("Невідома операція.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}

