using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool primeNumber = true;


            if (number == 2 || number == 3 || number == 5 || number == 7)
                primeNumber = true;

            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        primeNumber = false;
                        break;
                    }

                }

            }


            if (primeNumber)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
            
        }
    }
}
