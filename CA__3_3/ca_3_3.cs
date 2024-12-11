using System;
using System.Numerics;

public class ComplexNumber
{
    double Real;
    double Imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    //сложение
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    //умножение
    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
        double imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
        return new ComplexNumber(real, imaginary);
    }

    //деление
    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
        double d = b.Real * b.Real + b.Imaginary * b.Imaginary;
        if (d == 0)
            throw new DivideByZeroException("Деление на ноль");

        double real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / d;
        double imaginary = (a.Imaginary * b.Real - a.Real * b.Imaginary) / d;
        return new ComplexNumber(real, imaginary);
    }

    //возведение в степень
    public ComplexNumber Power(int exponent)
    {
        double modulus = Modulus();
        double angle = Angle();

        double newModulus = Math.Pow(modulus, exponent);
        double newAngle = angle * exponent;

        double real = newModulus * Math.Cos(newAngle);
        double imaginary = newModulus * Math.Sin(newAngle);

        return new ComplexNumber(real, imaginary);
    }

    //квадратный корнь
    public ComplexNumber Sqrt()
    {
        double modulus = Modulus();
        double angle = Angle();

        double newModulus = Math.Sqrt(modulus);
        double newAngle = angle / 2;

        double real = newModulus * Math.Cos(newAngle);
        double imaginary = newModulus * Math.Sin(newAngle);

        return new ComplexNumber(real, imaginary);
    }

    //модуль
    public double Modulus()
    {
        return Math.Sqrt(Real * Real + Imaginary * Imaginary);
    }

    //угол в радианах
    public double Angle()
    {
        return Math.Atan2(Imaginary, Real);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

public class Program
{
    public static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(6, 5);  
        ComplexNumber c2 = new ComplexNumber(0, -2); 

        Console.WriteLine("c1 = " + c1);
        Console.WriteLine("c2 = " + c2);

        // Сложение
        ComplexNumber sum = c1 + c2;
        Console.WriteLine("Сложение: " + sum);

        // Умножение
        ComplexNumber product = c1 * c2;
        Console.WriteLine("Умножение: " + product);

        // Деление
        ComplexNumber quotient = c1 / c2;
        Console.WriteLine("Деление: " + quotient);

        // Возведение в степень
        ComplexNumber power = c1.Power(2);
        Console.WriteLine("Возведение в степень 2: " + power);

        // Извлечение квадратного корня
        ComplexNumber sqrt = c1.Sqrt();
        Console.WriteLine("Квадратный корень: " + sqrt);

        // Модуль и угол
        Console.WriteLine("Модуль c1: " + c1.Modulus());
        Console.WriteLine("Угол c1: " + c1.Angle() + " радиан");
    }
}
