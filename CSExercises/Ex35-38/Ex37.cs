using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string sentence, newSentence = "";
            int length;

            Console.Write("Please provide a sentence: ");
            sentence = Console.ReadLine();
            sentence = sentence.Trim();
            length = sentence.Length;

            for (int i = 0; i < length; i++)
            {

                if (i == 0)
                {
                    newSentence = newSentence + sentence.Substring(i, 1).ToUpper();
                }

                else if (sentence.Substring(i, 1) == " ")
                {
                    newSentence = newSentence + " " + sentence.Substring(i+1, 1).ToUpper();
                    i++;
                }
                else
                    newSentence = newSentence + sentence.Substring(i, 1);
            }

            Console.WriteLine(newSentence);
            
        }
    }
}
