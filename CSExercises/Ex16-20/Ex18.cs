using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            string grade = "";

            if (marks >= 0 && marks <= 100)
            {
                if (marks >= 80)
                {
                    grade = "A";
                }
                else if (marks >= 60 && marks < 80)
                {
                    grade = "B";
                }
                else if (marks >= 40 && marks < 60)
                {
                    grade = "C";
                }
                else if (marks < 40)
                {
                    grade = "F";
                }

                Console.WriteLine("You scored {0} marks which is {1} grade.", marks, grade);
            }

            else
            {
                Console.WriteLine("**Error**");
            }
        }
    }
}