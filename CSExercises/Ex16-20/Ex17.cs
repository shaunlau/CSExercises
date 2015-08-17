using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Please provide your name: ");
            string UserName = Console.ReadLine();
            Console.Write("Please provide your gender: ");
            string gender = Console.ReadLine();
            Console.Write("Please provide your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(gender == "M")
            {
                if (age < 40)
                {
                    Console.WriteLine("Good morning Mr. " + UserName);    
                }
                else  if (age >= 40)
                {
                    Console.WriteLine("Good morning Uncle " + UserName);
                }
            }
            else if (gender == "F")
            {
                if (age < 40)
                {
                    Console.WriteLine("Good morning Ms. " + UserName);
                }
                else if (age >= 40)
                {
                    Console.WriteLine("Good morning Aunty " + UserName);
                }
            }
        }
    }
}