using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int x = 0;
            do
            {
                Console.Write("Please enter an integer: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x != 88);

            Console.WriteLine("\"Lucky you...\"");
        }
    }
}
