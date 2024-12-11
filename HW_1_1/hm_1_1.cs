int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < n; i++)
{
    bool isPr = true;

    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        

        if (i % j == 0)
        {
            isPr = false;
            break;
        }

    }

    if (isPr)
    {
        Console.WriteLine(i);
    }

    
}  

