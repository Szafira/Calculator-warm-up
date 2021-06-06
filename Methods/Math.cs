using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebCalculator.Methods
{
        public class BasicCalculations
        {
            public int squareArea(int value1)
            {
                int finalValue = value1 * value1;
                if (value1 < 0)
                {
                    throw new ArithmeticException("Bok kwadratu musi być nieujemny");
                }
                if (value1 == 0)
                {
                    throw new ArithmeticException("Bok kwadratu nie może być zerowy");
                }

            return finalValue;
        }
    }
}
