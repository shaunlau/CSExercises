using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please provide a value for a: ");
            double a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Please provide a value for b: ");
            double b = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Please provide a value for c: ");
            double c = Convert.ToDouble(System.Console.ReadLine());

            double s = (a + b + c) / 2;

            System.Console.WriteLine(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
        }
    }
}