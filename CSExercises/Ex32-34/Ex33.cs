using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] arrayList = new int[] {86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79};

            for (int i = 0; i < arrayList.Length-1; i++)
            {
                for (int z = i+1; z < arrayList.Length; z++)
                {
                    if (arrayList[z] > arrayList[i])
                    {
                        int temp = 0;
                        temp = arrayList[z];
                        arrayList[z] = arrayList[i];
                        arrayList[i] = temp;

                    }
                }
                    
            }
            foreach (int number in arrayList)
            {
                Console.Write(number + " ");
            }
            
        }
    }
}
