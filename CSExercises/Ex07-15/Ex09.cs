using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter a value: ");
            double number = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine(Math.Pow(number,2)*2 - 4*number + 3);
        }
    }
}
