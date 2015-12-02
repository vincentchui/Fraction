using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class FractionTester
    {
        static void Main(string[] args)
        {
            Fraction f1, f2, f3;

            f1 = new Fraction(1, 2);

            f2 = new Fraction(3, 4);

            f3 = new Fraction(1, 3);

            f3 = f1 + f2;

            f3.ToString(f3);

            f3 = f1 - f2;

            f3.ToString(f3);

            f3 = f1 * f2;

            f3.ToString(f3);

            f3 = f1 / f2;

            f3.ToString(f3);
        }
    }
}
/*OUTPUT
5/4
1/4
1/2
2/3
Press any key to continue . . .
*/