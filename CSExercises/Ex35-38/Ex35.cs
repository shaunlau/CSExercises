using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //Question 35a
            
            string phrase;
            int length, count = 0;

            Console.WriteLine("Please enter a phrase: ");
            phrase = Console.ReadLine();
            length = phrase.Length;

            for (int i = 0; i < length; i++)
            {
                string letter = phrase.Substring(i, 1);

                if ("AEIOUaeiou".Contains(letter))
                    count++;
            }
            Console.WriteLine("Total number of vowels: {0}", count);
            


            //Question 35b
            /*
            string phrase;
            int length, countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;

            Console.WriteLine("Please enter a phrase: ");
            phrase = Console.ReadLine();
            length = phrase.Length;

            for (int i = 0; i < length; i++)
            {
                string letter = phrase.Substring(i, 1);

                if ("Aa".Contains(letter))
                    countA++;
                else if ("Ee".Contains(letter))
                    countE++;
                else if ("Ii".Contains(letter))
                    countI++;
                else if ("Oo".Contains(letter))
                    countO++ ;
                else if ("Uu".Contains(letter))
                    countU++;
            }
            Console.WriteLine("Number of a: {0}", countA);
            Console.WriteLine("Number of e: {0}", countE);
            Console.WriteLine("Number of i: {0}", countI);
            Console.WriteLine("Number of o: {0}", countO);
            Console.WriteLine("Number of u: {0}", countU);
             */
        }
    }
}
