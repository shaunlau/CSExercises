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
                    if (number % (2) == 0)
                    {
                        primeNumber = false;
                    }

                    else if (number % (3) == 0)
                    {
                        primeNumber = false;                        
                    }

                    else if (number % (5) == 0)
                    {
                        primeNumber = false;                        
                    }

                    else if (number % (7) == 0)
                    {
                        primeNumber = false;                       
                    }
                
            }

            if (primeNumber)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
            
        }
    }
}
