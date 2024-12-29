using System.Globalization;

namespace Lesson8._3;

internal class Task3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        var inputString = Console.ReadLine();
        if (string.IsNullOrEmpty(inputString))
        {
            Console.WriteLine("Вы ничего не ввели");
            return;
        }
        else if (string.IsNullOrWhiteSpace(inputString))
        {
            Console.WriteLine("Вы ввели не строку!");
            return;
        }
        else
        {
            string lowercase = inputString.ToLower();
            Console.WriteLine($"Каждое слово с заглавной буквы: {lowercase}");
            string uppercase = inputString.ToUpper();
            Console.WriteLine($"Каждое слово с заглавной буквы: {uppercase}");
            string firstLetterUp = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputString.ToLower());
            Console.WriteLine($"Каждое слово с заглавной буквы: {firstLetterUp}");
        }
    }
}
