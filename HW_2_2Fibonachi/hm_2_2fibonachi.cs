using System;
using System.Numerics;

class Fibonacci
{
    // Рекурсивно
    public static BigInteger FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Итеративно
    public static BigInteger FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        BigInteger a = 0, b = 1, temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    // Измерение времини
    public static void MeasureTime(int n)
    {
        // для рекурсивного
        var startRecursive = DateTime.Now;
        var resultRecursive = FibonacciRecursive(n);
        var endRecursive = DateTime.Now;
        var timeRecursive = endRecursive - startRecursive;

        // для итеративного
        var startIterative = DateTime.Now;
        var resultIterative = FibonacciIterative(n);
        var endIterative = DateTime.Now;
        var timeIterative = endIterative - startIterative;

        Console.WriteLine($"Рекурсивное время для n={n}: {timeRecursive.TotalMilliseconds} ms, результат: {resultRecursive}");
        Console.WriteLine($"Итеративное время для n={n}: {timeIterative.TotalMilliseconds} ms, результат: {resultIterative}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер числа Фибоначчи (n): ");
        int n = int.Parse(Console.ReadLine());

        MeasureTime(n);
    }
}

