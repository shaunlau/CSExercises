using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            double minimum=9999999, maximum=0, average=0;
            int minMonth = 0, maxMonth = 0;
            double [] sales = new double[12];

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month {0}: ", i);
                sales[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 12; i++)
            {
                if (sales[i] < minimum)
                {
                    minimum = sales[i];
                    minMonth = i;
                }
                if (sales[i] > maximum)
                {
                    maximum = sales[i];
                    maxMonth = i;
                }

                average += (sales[i]);
            }

            Console.WriteLine("Maximum Sales: {0}", maxMonth);
            Console.WriteLine("Minimum Sales: {0}", minMonth);
            Console.WriteLine("Average Sales: {0}", average/12.0);
        }
    }
}
