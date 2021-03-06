using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(SQT(i));
            }
        }

        public static double SQT(int y)
        {                      

            Random r = new Random();
            double guess = (r.NextDouble() * (y - 1)) + 1;

            do
            {
                guess = (guess + y / guess) / 2;
            }
            while ((guess * guess) - y > 0.00001 || (guess * guess) - y < -0.00001);

            return guess;
            
        }
    }
}
