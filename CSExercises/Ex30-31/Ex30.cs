using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            
            for (int i = 5; i <= 10000; i++)
            {


                if (isPrime(i))
                {
                    
                    Console.WriteLine(i);
                    
                }  

                
            }
        }
        private static bool isPrime(int number)
        {
            bool primeNumber = true;

            if (number == 2 || number == 3 || number == 5 || number == 7)
                primeNumber = true;

            else
            {
                for (int i = 2 ; i <number; i++)
                {
                    if (number % i == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                
                }
            
            }
            return primeNumber;
        }
            
     }
}

