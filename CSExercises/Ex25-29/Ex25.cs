using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Please provide a number: ");
            int number = Convert.ToInt32(Console.ReadLine()), total = 1;


            for (int i = 1; i <= number; i++)
            { 
                total = total*i;
            }


            //answer for 25b
            /*
            for (int i = number; i >= 1; i--)
            {
                total = total * i;
            }
            */


            Console.WriteLine(total);

        }
    }
}
