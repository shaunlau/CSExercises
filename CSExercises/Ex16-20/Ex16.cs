using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Please provide your name: ");
            string UserName = Console.ReadLine();
            Console.Write("Please enter your gender: ");
            string gender = Console.ReadLine();         

            if (gender == "M")             
                Console.WriteLine("Good Morning Mr. " + UserName);
            else if (gender == "F")              
                Console.WriteLine("Good Morning Ms. " + UserName);
            else
                Console.WriteLine("Good Morning");
            

        }
    }
}