namespace PIT2022.FractionEX;

public class Fraction
{
    public readonly int Numerator;
    public int Denominator { get; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        if (denominator == 0) throw new ArgumentException("denominator cannot be zero");
        if (denominator < 0) throw new ArgumentException("denominator cannot be negative");
        Denominator = denominator;
    }

    public override string ToString()
    {
        return Numerator + "/" + Denominator;
    }

    public Fraction Summ(Fraction f)
    {
        int numerator = Numerator * f.Denominator + f.Numerator * Denominator;
        int denominator = Denominator * f.Denominator;
        
        Fraction result = new Fraction(numerator, denominator);
        return result;
    }

    public Fraction Summ(int f)
    {
        int numerator = Numerator + f * Denominator;
        Fraction result = new Fraction(numerator, Denominator);
        return result;
    }
    
    public Fraction Substract(Fraction f)
    {
        int numerator = Numerator * f.Denominator - f.Numerator * Denominator;
        int denominator = Denominator * f.Denominator;
        
        Fraction result = new Fraction(numerator, denominator);
        return result;
    }

    public Fraction Substract(int f)
    {
        int numerator = Numerator - f * Denominator;
        Fraction result = new Fraction(numerator, Denominator);
        return result;
    }
    
    public Fraction Multiply(Fraction f)
    {
        int numerator = Numerator * f.Numerator;
        int denominator = Denominator * f.Denominator;
        
        Fraction result = new Fraction(numerator, denominator);
        return result;
    }

    public Fraction Multiply(int f)
    {
        int numerator = Numerator * f;
        Fraction result = new Fraction(numerator, Denominator);
        return result;
    }
    
        
    public Fraction Div(Fraction f)
    {
        int numerator = Numerator * f.Denominator;
        int denominator = Denominator * f.Numerator;
        
        Fraction result = new Fraction(numerator, denominator);
        return result;
    }

    public Fraction Div(int f)
    {
        int denominator = Denominator * f;
        Fraction result = new Fraction(Numerator, denominator);
        return result;
    }

    public static void Example()
    {
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(2, 3);
        Fraction f3 = new Fraction(1, 3);
        Fraction f4 = new Fraction(21, 6);
        Console.WriteLine($"{f1} + {f2} = {f1.Summ(f2)}");
        Console.WriteLine($"{f1} - {f2} = {f1.Substract(f2)}");
        Console.WriteLine($"{f1} * {f2} = {f1.Multiply(f2)}");
        Console.WriteLine($"{f1} / {f2} = {f1.Div(f2)}");
        Console.WriteLine($"{f1} + 2 = {f1.Summ(2)}");
        Console.WriteLine($"{f1} - 2 = {f1.Substract(2)}");
        Console.WriteLine($"{f1} * 2 = {f1.Multiply(2)}");
        Console.WriteLine($"{f1} / 2 = {f1.Div(2)}");
        Console.WriteLine($"{f4} - 5 = {f4.Substract(5)}");
        Console.WriteLine($"({f1} + {f2})/({f3}) - 5 = {f1.Summ(f2).Div(f3).Substract(5)}");
        Console.WriteLine("(" + f1 + " + " +  f2 + ")/(" + f3 + ") - 5 = " + f1.Summ(f2).Div(f3).Substract(5));
        Fraction f = new Fraction(1, -2);
    }
    
}