using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CSExercises
{
    public class Ex44
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Substitute("hello",'o','i'));
        }
        public static string Substitute(string s, char c1, char c2)
        {
            int length = s.Length;
            string newS = "";

            for (int i = 0; i < length; i++)
            {                
                if (s.Substring(i, 1) ==  Convert.ToString(c1))
                {
                    newS += c2;
                }
                else
                {
                    newS += s.Substring(i,1);
                }

            }
            return newS;
        }
    }
}
