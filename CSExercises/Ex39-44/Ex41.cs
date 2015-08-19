using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            s1 = s1.ToLower().Trim();
            s2 = s2.ToLower().Trim();
            int lengthS2 = s2.Length, lengthS1 = s1.Length;
            bool inString = false;

            for (int i = 0; i <= lengthS1 - lengthS2; i++)
            {
                if (s1.Substring(i,lengthS2) == s2)
                {
                    inString = true;
                }
            }

            return inString;
        }
    }
}
