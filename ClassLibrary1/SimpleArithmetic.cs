using System;

namespace ClassLibrary1
{
    public class SimpleArithmetic
    {
        public decimal Addition(int x, int y)
        {
            return x + y;
        }

        public decimal Subtraction(int x, int y)
        {
            return x - y;
        }

        public decimal Multiplication(int x, int y)
        {
            return x * y;
        }

        public decimal Division(int x, int y, bool stupid = false)
        {
            if (stupid && y == 0)
                return 0;

            return x / y;
        }
    }
}
