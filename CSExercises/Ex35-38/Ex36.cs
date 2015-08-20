using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            //Question 36a
            /*
            bool isPalindrome = true;
            string word;
            int length;
            Console.Write("Please enter a word: ");
            word = Console.ReadLine().ToLower();

            length = word.Length;

            for (int i = 0; i < length; i++)
            {
                if (!word.Substring(i, 1).Contains(word.Substring((length - 1 - i),1)))
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }          
            */

            // Question 36b
            bool isPalindrome = true;
            string word, newWord = "";            
            int length;
            Console.Write("Please enter a word: ");
            word = Console.ReadLine().ToLower();
            
            
            foreach (char c in word)
            {
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                    newWord = newWord + c;
            }

            Console.WriteLine(newWord);
            length = newWord.Length;

            

            for (int i = 0; i < length; i++)
            {
                if (!newWord.Substring(i, 1).Contains(newWord.Substring((length - 1 - i), 1)))
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }          
        }
    }
}
