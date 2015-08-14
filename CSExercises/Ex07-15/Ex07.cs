using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter salary: ");
            double salary = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("{0:c}",salary + 0.10*salary + 0.03*salary);
        }
    }
}
