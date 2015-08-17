using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double discount5000 = 0.10, discount10000 = 0.15, total = 0, discount = 0;
            int tv, dvd, mp3;

            Console.Write("Enter quantity for TV: ");
            tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            mp3 = Convert.ToInt32(Console.ReadLine());

            total = tv * 900 + dvd * 500 + mp3 * 700;

            if (total > 5000 && total <= 10000)
            {
                discount = (tv * 900 + dvd * 500) * discount5000;
            }

            else if (total > 10000)
            {
                discount = (tv * 900 + dvd * 500) * discount10000;
                Console.WriteLine(discount);
            }

            Console.WriteLine("Total price for this order is {0:c}", total - discount);
        }
    }
}