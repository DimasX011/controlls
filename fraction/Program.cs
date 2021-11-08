using System;

namespace fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(18,21);

            int value = fraction.Denumerator(93, 27);

            int numer = fraction.Numerator(2, 2, 1, 1,"+");

           

            Console.WriteLine(numer);
        }
    }
}
