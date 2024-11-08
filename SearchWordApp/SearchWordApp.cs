using System.Text;

namespace SearchWordApp
{
    internal class SearchWordApp
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (args.Length != 2)
            {
                Console.WriteLine("Необхідно вказати шлях до файлу та слово для пошуку.");
                return;
            }

            string filePath = args[0]; 
            string wordToSearch = args[1]; 

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не знайдено.");
                return;
            }

            int count = 0;

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    count += CountOccurrences(line, wordToSearch);
                }

                Console.WriteLine($"Слово '{wordToSearch}' зустрічається {count} разів.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }

        static int CountOccurrences(string line, string word)
        {
            int count = 0;
            int index = 0;

            while ((index = line.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += word.Length; 
            }

            return count;
        }
    }
}
