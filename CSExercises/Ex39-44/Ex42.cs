namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            s1 = s1.ToLower().Trim();
            s2 = s2.ToLower().Trim();
            int lengthS2 = s2.Length, lengthS1 = s1.Length;
            int positionString = -1;

            for (int i = 0; i <= lengthS1 - lengthS2; i++)
            {
                if (s1.Substring(i, lengthS2) == s2)
                {
                    positionString = i;
                    break;
                }
            }


            return positionString;
        }
    }
}
