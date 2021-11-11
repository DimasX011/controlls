using System;

namespace fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complex = new ComplexNumber(5, 6);
            ComplexNumber complex1 = new ComplexNumber(-5, 16);

            ComplexNumber complex2 = complex + complex1;

            Fraction fraction = new Fraction(-4, 9);
            Fraction fraction1 = new Fraction(2, -7);
            Fraction fraction2 = fraction - fraction1;
            Fraction fraction3 = fraction + fraction1;
            Fraction fraction4 = fraction * fraction1;
            Fraction fraction5 = fraction / fraction1;

            Console.ReadLine();


        }
    }
}
