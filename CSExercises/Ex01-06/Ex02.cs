using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int number;
            System.Console.Write("Please enter an integer: ");
            number = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(Math.Pow(number, 2));
        }
    }
}
