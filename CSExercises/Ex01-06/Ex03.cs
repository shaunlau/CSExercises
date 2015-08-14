using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a double: ");
            double number = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine(Math.Pow(number, 2));
        }
    }
}
