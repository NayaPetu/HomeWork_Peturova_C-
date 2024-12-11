using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    // Рекурсивный метод для вычисления факториала
    public static BigInteger FactorialRecursive(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * FactorialRecursive(n - 1);
    }

    // Итеративный метод для вычисления факториала
    public static BigInteger FactorialIterative(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // Измерение времини
    public static void MeasureTime(int n)
    {
        // для рекурсивного
        var startRecursive = DateTime.Now;
        var resultRecursive = FactorialRecursive(n);
        var endRecursive = DateTime.Now;
        var timeRecursive = endRecursive - startRecursive;

        // для итеративного
        var startIterative = DateTime.Now;
        var resultIterative = FactorialIterative(n);
        var endIterative = DateTime.Now;
        var timeIterative = endIterative - startIterative;

        Console.WriteLine($"Рекурсивное время для n={n}: {timeRecursive.TotalMilliseconds} ms, результат: {resultRecursive}");
        Console.WriteLine($"Итеративное время для n={n}: {timeIterative.TotalMilliseconds} ms, результат: {resultIterative}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для Факториала (n): ");
        int n = int.Parse(Console.ReadLine());

        MeasureTime(n);
    }


    //вывести числа подряд и посмотреть изменение времени
    //static void Main (string[] args)
    //{
    //    // Тестируем факториалы для различных чисел
    //    for (int number = 1; number <= 200; number++)
    //    {
    //        Console.WriteLine($"факториал числа {number}");

    //        // Замер времени для рекурсивного метода
    //        Stopwatch stopwatch = new Stopwatch();
    //        stopwatch.Start();
    //        BigInteger resultRecursive = FactorialRecursive(number);
    //        stopwatch.Stop();
    //        long timeRecursive = stopwatch.ElapsedMilliseconds;

    //        // Замер времени для итеративного
    //        stopwatch.Restart();
    //        BigInteger resultIterative = FactorialIterative(number);
    //        stopwatch.Stop();
    //        long timeIterative = stopwatch.ElapsedMilliseconds;

    //        Console.WriteLine($"Рекурсивный {number}: {resultRecursive}");
    //        Console.WriteLine($"Итеративный {number}: {resultIterative}");
    //        Console.WriteLine($"Время рекурсивного вычисления: {timeRecursive} мс");
    //        Console.WriteLine($"Время итеративного вычисления: {timeIterative} мс");

    //        // Выясняем, с какого числа рекурсивный метод становится медленнее итеративного
    //        // Как только рекурсивный метод начинает работать медленнее итеративного, программа завершает выполнение.
    //        if (timeRecursive > timeIterative)
    //        {
    //            Console.WriteLine($"Рекурсивный метод стал медленнее на числе {number}");
    //            break;
    //        }

    //        Console.WriteLine();
    //    }

    //    Console.ReadLine();
    //}
}

