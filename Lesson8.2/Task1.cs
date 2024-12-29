namespace Lesson8._2;

internal class Task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово, чтобы проверить является ли оно палиндромом: ");
        var inputWord = Console.ReadLine();
        if (string.IsNullOrEmpty(inputWord))
        {
            Console.WriteLine("Вы ничего не ввели");
            return;
        }
        else if (string.IsNullOrWhiteSpace(inputWord))
        {
            Console.WriteLine("Вы ввели не строку!");
            return;
        }
        else
        {
            IsTruePalindrome(inputWord);
        }
    }

    static bool IsTruePalindrome(string value)
    {
        value = value.ToLower();
        int i = 0;
        int j = value.Length - 1;
        while (i != j)
        {
            if (value[i++] != value[j--])
            {
                Console.WriteLine($"Строка: [{value}] не является палиндромом!");
                return false;
            }
        }
        Console.WriteLine($"Успешно! Строка: [{value}] является палиндромом!");
        return true;
    }
}
