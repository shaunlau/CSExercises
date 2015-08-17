using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" {0,-15}{1,-15}{2,-17}{3,-7} ", "NO", "INVERSE", "SQUARE ROOT","SQUARE");
            for (int i = 0; i <=54; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            for (int t = 1; t <= 10; t++)
            {
                Console.Write("{0,-16:0.0}{1,-15:0.0##}{2,-17:0.0##}{3,-6:0.0}",t, 1.0/t, Math.Sqrt(t),Math.Pow(t,2));
                Console.WriteLine();
            }
            
        
        }
    }
}
