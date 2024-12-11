    static int CollatzConjecture(int n)
    {
        int count = 0;
        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
            count++;
        }
        return count;
    }

    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine());

    int result = CollatzConjecture(n);
    Console.WriteLine($"Количество замен: {result}");
