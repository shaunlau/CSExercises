using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] score = new int[,]{{56,84,68,29},{94,73,31,89},{41,63,36,90},{99,9,18,17},
                                    {62,3,65,75},{40,96,53,23},{81,15,27,30},{21,70,100,22},
                                    {88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};
            //total score for each student
            int[] total = new int[12];
            //average marks per subject
            double[] averageSub = new double[4];
            //standard deviation 
            double[] standard = new double[4];
            //average whole class
            double averagewhole = 0;

            int row = score.GetLength(0);
            int column = score.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int z = 0; z < column; z++)
                {
                    total[i] += score[i,z];                                    
                }
                Console.WriteLine("Total score for student {0}: {1}", i, total[i]);
            }

            for (int i = 0; i < column; i++)
            {
                for (int z = 0; z < row; z++)
                { 
                    averageSub[i] += score[z,i];
                }
                averageSub[i] = averageSub[i] / (double)row;
                Console.WriteLine("Average score for subject {0}: {1}", i, averageSub[i]);
            }

            for (int i = 0; i < column; i++)
            {
                for (int z = 0; z < row; z++)
                {
                    standard[i] += Math.Pow(score[z, i]- averageSub[i], 2);   
                }
                standard[i] = Math.Sqrt(standard[i] / 12);
                Console.WriteLine("Standard deviation for subject {0}: {1}", i, standard[i]);
            }

            for (int i = 0; i < row; i++)
            {
                averagewhole += total[i];
            }
            Console.WriteLine("Overall average marks: {0}", averagewhole / (row * column));
        }
    }
}
