// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (c == 0 & a == 0 & b == 0)
{
    Console.WriteLine("Бесконечно много решений, принадлежат вещественным числам");
}

else if (a == 0 & b != 0)
{
    double x = -c / b;
    Console.Write("Корень  равен: {0} ", x);
}

else if (a == 0 & b == 0 & c != 0)
{
    Console.Write("Нет решений");
}

else if (a != 0 & b != 0 )
{
    int d = b * b - 4 * a * c;
    if (d>0)
    {
        Console.Write($"2 корня,{-b+Math.Sqrt(d)/2*a},{-b - Math.Sqrt(d) / 2 * a}"); 
    }

    else if (d == 0)
    {
        Console.Write($"1 корня,{-b / 2 * a}");
    }

    else if (d > 0)
    {
        Console.Write("Нет решений");
    }
    
}
