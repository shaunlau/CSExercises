using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int randomNum = r.Next(0, 10), guess, numGuess = 0;
            Console.Write("Please guess an integer between 0-9: ");
            do
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNum)
                {
                    break;
                }
                else
                {
                    Console.Write("Try again ");
                    numGuess++;
                }

                
                
            } while(guess != randomNum);

            if (numGuess <= 2)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if (numGuess > 2 && numGuess <= 5)
            {
                Console.WriteLine("You are a good guess");
            }
            else
            {
                Console.WriteLine("You are lousy!");
            }


        }
    }
}
