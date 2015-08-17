using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double fare = 0, minimumFare = 2.40, fareUptoNine = 2.40 + 85*0.04; 
            
            Console.Write("Please enter distance in km: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            //Rounding up the value to 1 decimal place
            distance = Math.Ceiling(distance * 10) / 10;

            //fare for first 0.5km
            if (distance <= 0.5)
            {
                fare = minimumFare;
            }
            else if (distance > 0.5 && distance <= 9)
            {
                fare = minimumFare + (distance - 0.5) * 0.4;
            }
            else if (distance > 9)
            {
                fare = fareUptoNine + (distance - 9) * 0.5;
            }

            Console.WriteLine("{0}", fare);
            
        }
    }
}