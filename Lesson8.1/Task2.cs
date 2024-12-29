using System.Text;

namespace Lesson8._1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Вы ничего не ввели");
            return;
        }
        else if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Вы ввели не строку!");
            return;
        }
        else
        {
            var sb = new StringBuilder(input.Length);
            foreach (var item in input)
            {
                if (!char.IsWhiteSpace(item))
                {
                    sb.Append(item);
                }
            }
            var OutputWithoutSpaces = sb.ToString();
            Console.WriteLine($"Строка без пробелов: [{OutputWithoutSpaces}]");
        }
    }
}
