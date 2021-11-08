using System;
using System.Collections.Generic;
using System.Text;

namespace fraction
{
    public class Fraction
    {
        private int numerator;

        private int denomirator;

        public Fraction(int num, int denom) { numerator = num; denomirator = denom; Final(); }

        public int Numer
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denumer
        {
            get { return denomirator; }
            set { denomirator = value; }
        }

        public static Fraction operator --(Fraction fraction)
        {
            fraction.Numer++;
            fraction.Denumer++;
            return fraction;
        }

        public static Fraction operator ++(Fraction fraction)
        {
            fraction.Numer--;
            fraction.Denumer--;
            return fraction;
        }

        public static Fraction operator +(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.Numerator(fraction.Denumer, fraction1.Denumer, fraction.Numer, fraction1.Numer, "+"), fraction.Denumerator(fraction.Denumer, fraction1.Denumer));
        }

        public static Fraction operator -(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.Numerator(fraction.Denumer, fraction1.Denumer, fraction.Numer, fraction1.Numer, "-"), fraction.Denumerator(fraction.Denumer, fraction1.Denumer));
        }
        public static Fraction operator %(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.Numer % fraction1.Numer, fraction.Denumer % fraction1.Denumer);
        }

        public static Fraction operator *(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.multiplication(fraction.Numer,fraction1.Numer,fraction.Denumer, fraction1.Denumer,"*"),fraction1.Denumerator(fraction.Denumer, fraction1.Denumer));
        }

        public static Fraction operator /(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(fraction.multiplication(fraction.Numer, fraction1.Numer, fraction.Denumer, fraction1.Denumer, "/"), fraction1.Denumerator(fraction.Denumer, fraction1.Denumer));
        }

        public static bool operator ==(Fraction fraction, Fraction fraction1)
        {
            return (fraction.Numer == fraction1.Numer || fraction.Denumer == fraction1.Denumer);
        }
        public static bool operator !=(Fraction fraction, Fraction fraction1)
        {
            return (fraction.Numer != fraction1.Numer && fraction.Denumer != fraction1.Denumer);
        }
        public static bool operator >(Fraction fraction, Fraction fraction1)
        {
            return (fraction.Numer > fraction1.Numer && fraction.Denumer > fraction1.Denumer);
        }

        public static bool operator <(Fraction fraction, Fraction fraction1)
        {
            return (fraction.Numer < fraction1.Numer && fraction.Denumer < fraction1.Denumer);
        }

        public static bool operator >=(Fraction fraction, Fraction fraction1)
        {
            return (fraction.Numer >= fraction1.Numer && fraction.Denumer >= fraction1.Denumer);
        }

        public static bool operator <=(Fraction fraction, Fraction fraction1)
        {
            return (fraction.Numer <= fraction1.Numer && fraction.Denumer <= fraction1.Denumer);
        }

        public string convert(int value, string s)
        {
            if (s == "s")
            {
                string Answer = value.ToString();
                return Answer;
            }
            return null;
        }

        public int convert(double value)
        {
            int Answer = Convert.ToInt32(value);
            return Answer;
        }

        public double convert(int value)
        {
            double Answer = Convert.ToDouble(value);
            return Answer;
        }

        public int Denumerator(int den1, int den2)
        {
            int Answer = 0;

            if (den1 % den2 == 0)
            {
                Answer = den1;
            }
            else if (den2 % den1 == 0)
            {
                Answer = den2;
            }
            else
            {
                int bolsh = 0;
                int menish = den1;
                if (den1 < den2)
                {
                    bolsh = den2;
                    menish = den1;
                }
                else
                {
                    bolsh = den1;
                    menish = den2;
                }
                bool operate = true;
                for (int i = bolsh; operate == true; i++)
                {
                    if (i % bolsh == 0 && i % menish == 0)
                    {
                        Answer = i;
                        return Answer;
                    }
                }
            }

            return Answer;
        }

        public int Numerator(int den1, int den2, int num1, int num2, string oper)
        {
            int Answer = 0;
            int denumer = Denumerator(den1, den2);

            num1 = denumer / den1;
            num2 = denumer / den2;
            if (oper == "+")
            {
                Answer = num1 + num2;
            }
            else if (oper == "-")
            {
                Answer = num1 - num2;
            }
            else if (oper == "*")
            {
                Answer = num1 * num2;
            }
            else if (oper == "/")
            {
                den2 = num2;
                num2 = den2;

                Answer = num1 * num2;

            }
            return Answer;

        }

        public int multiplication(int num1,int num2,int den1,int den2, string oper)
        {
            int resdem = 0;
            if (oper == "*")
            {
                 resdem = den1 * den2;
            }
            else
            {
                num2 = den2;
                den2 = num2;
                resdem = den1 * den2;
            }
            return resdem;
        }

        public int Nod(int n, int d)
        {
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            return 0;
        }

        private void reduction(int num, int den)
        {
            int nod = Nod(num, den);
            num = num / nod;
            den = den / nod;
            Numer = num;
            Denumer = den;
        }
        private void Final()
        {
            reduction(Numer, Denumer);
        }
    }
    }
    


