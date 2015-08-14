using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter an int: ");
            int number = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(Math.Round(Math.Sqrt(number),3));
        }
    }
}
