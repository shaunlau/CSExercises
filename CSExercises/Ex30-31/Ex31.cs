using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            
            
            for (int z = 3; z <=1000 ; z++)
            {
                int total = 1;
                for (int i = 2; i < z; i++)
                {
                    if (z % i == 0)
                    {
                        total += i;
                    }
                }
                if (total == z)
                {
                    Console.WriteLine(total);
                }
            }
        }
    }
}
