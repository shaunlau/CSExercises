using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;


namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int total = 1;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    total += i;
            }

            if (total == number)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect Number");
        }
    }
}
