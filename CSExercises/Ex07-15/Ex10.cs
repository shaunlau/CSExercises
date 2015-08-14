using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter value of x1: ");
            double x1 = Convert.ToDouble(System.Console.ReadLine());
            
            System.Console.Write("Please enter value of y1: ");
            double y1 = Convert.ToDouble(System.Console.ReadLine());
            
            System.Console.Write("Please enter value of x2: ");
            double x2 = Convert.ToDouble(System.Console.ReadLine());
            
            System.Console.Write("Please enter value of y2: ");
            double y2 = Convert.ToDouble(System.Console.ReadLine());
            
            System.Console.WriteLine(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));
        }
    }
}
