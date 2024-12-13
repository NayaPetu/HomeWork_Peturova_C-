using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("f.txt"))
        {
            writer.WriteLine("x sin(x)");

            for (double x = 0; x <= 1; x += 0.1)
            {
                double sinValue = Math.Sin(x);
                writer.WriteLine($"{x:F1} {sinValue:F6}");
            }
        }

        Console.WriteLine("Таблица записана в файл f.txt.");
    }
}

