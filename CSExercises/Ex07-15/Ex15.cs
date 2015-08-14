using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please provide a 3-digit integer: ");
            int integer = Convert.ToInt32(System.Console.ReadLine());
            int integer1 = integer;
            int firstValue = integer1 % 10;
            integer1 = integer1 / 10;
            int secondValue = integer1 % 10;
            integer1 = integer1 / 10;
            int thirdValue = integer1 % 10;
            double totalValue = Math.Pow((double)firstValue, 3) + Math.Pow((double)secondValue, 3) + Math.Pow((double)secondValue, 3);
            if (totalValue - integer < 0.001)
                System.Console.WriteLine("armstrong number");
            else
                System.Console.WriteLine("not armstrong number");
        }
    }
}