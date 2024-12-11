Console.WriteLine("Исходный массив:");
int[] a = { 5, 3, 8, 4, 2 };
PrintArray(a);

BubbleSort(a);

Console.WriteLine("\nОтсортированный массив:");
PrintArray(a);


// пузырьковая сортировка
static void BubbleSort(int[] a)
{
        int n = a.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
}

//вывода массива
static void PrintArray(int [] a)
{
    foreach (int i in a)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
