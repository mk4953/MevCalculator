using System;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Powered(2,5);
        }

        public static long Powered(long number, long exponent )
        {
            var temp = number;
            for (int i = 0; i < exponent-1; i++)
            {
                number = number * temp;
            }
            
            return number;
        }
    }
}
