using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please input temperature in Centigrade: ");
            double temperature = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine(1.8*temperature + 32);
        }
    }
}
