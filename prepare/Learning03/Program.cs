using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction();

        // Test with 1
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        
        // Test with 5
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        // Test with 3/4
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // Test with 1/3 but using input
        int top = 0;
        int bottom = 0;

        Console.Write("Enter numerator: ");
        string num = Console.ReadLine();
        Console.Write("Enter denominator: ");
        string den = Console.ReadLine();

        top = int.Parse(num);
        bottom = int.Parse(den);

        fraction4.SetTop(top);
        fraction4.SetBottom(bottom);

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());


        

    }
}