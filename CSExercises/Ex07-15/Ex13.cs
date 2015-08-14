using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter the distance: ");
            double distance = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("{0:0.00}", Math.Ceiling((2.40 + distance * 0.40)*10)/10);
        }
    }
}