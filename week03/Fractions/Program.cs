using System;

class Program
{
    static void Main(string[] args)
    {
        // Using the default constructor
        Fraction f1 = new Fraction();

        // Using the constructor with one parameter
        Fraction f2 = new Fraction(5);

        // Using the constructor with two parameters
        Fraction f3 = new Fraction(3, 4);

        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine("Fractions and Decimal Values:");
        Console.WriteLine($"{f1.GetFractionString()} = {f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()} = {f3.GetDecimalValue()}");
        Console.WriteLine($"{f4.GetFractionString()} = {f4.GetDecimalValue()}");

        Console.WriteLine();

        // Testing getters and setters
        f1.SetTop(6);
        f1.SetBottom(7);

        Console.WriteLine("After using setters:");
        Console.WriteLine($"Top: {f1.GetTop()}");
        Console.WriteLine($"Bottom: {f1.GetBottom()}");
        Console.WriteLine($"{f1.GetFractionString()} = {f1.GetDecimalValue()}");
    }
}