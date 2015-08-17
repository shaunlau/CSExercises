using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0,-9}{1}","X","Y");
            for (int i = 0; i <= 46; i++)
            {
                Console.Write("-");                
            }
            Console.WriteLine();

            for (int z = -5; z <= 5; z++)
            {
                Console.Write("{0,-9:0.0}{1:0.0}", z, 2*Math.Pow(z,2)-4*z+3);
                Console.WriteLine();
            }
        
        }

        
    }
}
