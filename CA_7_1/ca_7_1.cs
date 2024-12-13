//using System;

//class Program
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            Console.Write("Введите число: ");
//            string input = Console.ReadLine();
//            int number = ValidateAndParse(input);
//            Console.WriteLine($"Введённое число: {number}");
//        }
//        catch (ArgumentOutOfRangeException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//    // Метод для проверки и преобразования строки в int
//    public static int ValidateAndParse(string input)
//    {
//        // Проверяем, является ли строка числом
//        if (!int.TryParse(input, out int result))
//        {
//            throw new FormatException("Введено не число.");
//        }

//        // Проверяем, что число в пределах допустимого диапазона для типа int
//        else if (result < int.MinValue || result > int.MaxValue)
//        {
//            throw new ArgumentOutOfRangeException("Число вне допустимого диапазона.");
//        }

//        return result;
//    }
//}


using System;

public class NumberConversation
{
    public static int Convert(string input)
    {
        return int.Parse(input);
    }
}

class SevenTask
{
    public static object NumberConverter { get; private set; }

    static void Main()
    {
        Console.WriteLine("Число:");

        string userInput = Console.ReadLine();

        try
        {
            int convertedValue = NumberConverter.Convert(userInput);
            Console.WriteLine($"Значение: {convertedValue}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка формата: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Ошибка переполнения: {ex.Message}");
        }
    }
}