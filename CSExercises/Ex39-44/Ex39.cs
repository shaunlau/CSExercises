using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            int number = 6;

            Console.WriteLine(Factorial(number));

        }
        public static long Factorial(long n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
