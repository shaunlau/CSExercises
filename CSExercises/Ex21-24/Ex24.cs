using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Please provide a number for which you want the square root: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Random r = new Random();
            double guess = (r.NextDouble() * (number-1)) +1;

            do
            {
                guess = (guess + number / guess) / 2;
            }
            while ((guess * guess) - number > 0.00001 || (guess * guess) - number < -0.00001);

            Console.WriteLine(guess);
            
        }
    }
}
