using System.Diagnostics;
using System.Text;

namespace HomeworkSystem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            /*Завдання 1
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "ping",
                    Arguments = "google.com",
                    RedirectStandardOutput = true, 
                    UseShellExecute = false, 
                    CreateNoWindow = true 
                };

                Process process = Process.Start(startInfo);

                process.WaitForExit();

                int exitCode = process.ExitCode;

                Console.WriteLine($"Дочірній процес завершився з кодом: {exitCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }*/


            /*Завдання 2
            try
            {
                Console.WriteLine("Виберіть дію:");
                Console.WriteLine("1. Чекати завершення процесу і вивести код завершення.");
                Console.WriteLine("2. Примусово завершити процес.");

                int choice = int.Parse(Console.ReadLine());

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "ping",
                    Arguments = "google.com", 
                    RedirectStandardOutput = true,
                    UseShellExecute = false, 
                    CreateNoWindow = true 
                };

                Process process = Process.Start(startInfo);

                if (choice == 1)
                {
                    Console.WriteLine("Чекаємо завершення процесу...");
                    process.WaitForExit(); 

                    int exitCode = process.ExitCode;
                    Console.WriteLine($"Дочірній процес завершився з кодом: {exitCode}");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Примусово завершуємо процес...");
                    process.Kill();
                    Console.WriteLine("Процес був завершений.");
                }
                else
                {
                    Console.WriteLine("Невірний вибір.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }*/



            /*Завдання 3
            Console.WriteLine("Введіть перше число:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Введіть друге число:");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Введіть операцію (+, -, *, /):");
            string operation = Console.ReadLine();

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "C:\\Users\\ASUS\\source\\repos\\HomeworkSystem1\\CalculatorApp\\bin\\Debug\\net8.0\\CalculatorApp.exe", 
                Arguments = $"{firstNumber} {secondNumber} {operation}",
                RedirectStandardOutput = true, 
                UseShellExecute = false, 
                CreateNoWindow = true
            };

            Process process = Process.Start(startInfo);

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            Console.WriteLine($"Результат: {output}");*/



            /*Завдання 4. Шлях писати з розширенням
            Console.WriteLine("Введіть шлях до файлу:");
            string filePath = Console.ReadLine();

            Console.WriteLine("Введіть слово для пошуку:");
            string wordToSearch = Console.ReadLine();

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "C:\\Users\\ASUS\\source\\repos\\HomeworkSystem1\\SearchWordApp\\bin\\Debug\\net8.0\\SearchWordApp.exe", 
                Arguments = $"{filePath} {wordToSearch}", 
                RedirectStandardOutput = true, 
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = Process.Start(startInfo);

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            Console.WriteLine($"Результат пошуку: {output}");*/
        }
    }
}
