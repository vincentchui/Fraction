using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        private long numerator, denominator;

        public long Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
            }
        }

        public Fraction(long numerator, long denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public void ToString(Fraction f)
        {
            Console.WriteLine(f.Numerator + "/" + f.Denominator);
        }

        public static Fraction simplify(Fraction f)
        {
            int temp = 0;

            temp = gcd(f);

            f.Numerator /= temp;

            f.Denominator /= temp;

            return f;

        }

        public static int gcd(Fraction f)
        {
            int gcd = 1;

            for (int i = 2; i <= f.Numerator && i <= f.Denominator; i++)
                if (f.Numerator % i == 0 && f.Denominator % i == 0)
                    gcd = i;

            return gcd;
        }

        static public Fraction operator+(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(1, 2);
            
            if(f1.Denominator == f2.Denominator)
            {
                f3.Numerator = f1.Numerator + f2.Numerator;

                f3.Denominator = f1.Denominator;
            }
            else
            {
                f3.Numerator = f2.Numerator * f1.Denominator + f1.Numerator * f2.Denominator;

                f3.Denominator = f1.Denominator * f2.Denominator;

                f3 = simplify(f3);
            }       

            return f3;
        }

        static public Fraction operator-(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(1, 2);

            if (f1.Denominator == f2.Denominator)
            {
                f3.Numerator = f1.Numerator - f2.Numerator;

                f3.Denominator = f1.Denominator;
            }
            else
            {
                f3.Numerator = f2.Numerator * f1.Denominator - f1.Numerator * f2.Denominator;

                f3.Denominator = f1.Denominator * f2.Denominator;

                f3 = simplify(f3);
            }

            return f3;
        }

        static public Fraction operator*(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(1, 2);

            f3.Numerator = f1.Numerator * f2.Denominator;

            f3.Denominator = f1.Denominator * f2.Denominator;

            f3 = simplify(f3);

            return f3;
        }

        static public Fraction operator/(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(1, 2);

            f3.Numerator = f1.Numerator * f2.Denominator;

            try
            {
                f3.Denominator = f1.Denominator * f2.Numerator;
            }
            catch (DivideByZeroException e)
            {
                throw new Exception("\nCan not divide denominator by 0.", e);
            }

            f3 = simplify(f3);

            return f3;
        }
    }
}
