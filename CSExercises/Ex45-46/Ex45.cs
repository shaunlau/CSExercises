using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int amountInput, coin = 100, counter =0;
            
            Console.Write("Enter the amount: ");
            amountInput = (int)(Convert.ToDouble(Console.ReadLine())*100);
            int[] denominator = new int[]{100,50,20,10,5};
             

            while(amountInput >= 0 && coin > 5)
            {
                coin = denominator[counter];
                amountInput = amountInput - countCoins(coin , amountInput);
                counter++;
                
            }


        }

        public static int countCoins(int coin, int amount)
        { 
                int count = amount / coin;
                for (int i = 0; i < count; i++)
			{
			    print_coins(coin);
			}

                return count*coin;

        }

        public static void print_coins(double coin)
        { 
                Console.WriteLine("{0}c", coin);
        
        }
    }
    

}
