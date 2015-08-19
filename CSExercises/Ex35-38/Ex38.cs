using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[,] name = new string[,]
            {
                {"John", "0"},
                {"Venkat", "1"},
                {"Mary", "2"},
                {"Victor", "3"},
                {"Betty", "4"},
            };


            int[,] marks = new int[,]
            {
                {63, 0},
                {29, 1},
                {75, 2},
                {82, 3},
                {55, 4},
            };

            int row = name.GetLength(0);
            int column = name.GetLength(1);

            //Question 38a
            for (int i = 0; i < row -1; i++)
            {
                for (int j = i+1; j < row; j++)
                {
                    if(marks[i,0] < marks[j,0])
                    {
                        int[,] temp = new int[1,2];
                        temp [0,0] = marks[i,0];
                        temp [0,1] = marks[i,1];
                        marks[i,0] = marks[j,0];
                        marks[i, 1] = marks[j, 1];
                        marks[j, 0] = temp[0, 0];
                        marks[j, 1] = temp[0, 1];
                    }

                }
            }

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("{0}: {1}", name[marks[i,1],0],marks[i,0]);
            }
            
            Console.WriteLine();

            //Question 38b
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = i + 1; j < row; j++)
                {
                    if (name[i, 0].CompareTo(name[j, 0])>1)
                    {
                        string[,] temp = new string [1, 2];
                        temp[0, 0] = name[i, 0];
                        temp[0, 1] = name[i, 1];
                        name[i, 0] = name[j, 0];
                        name[i, 1] = name[j, 1];
                        name[j, 0] = temp[0, 0];
                        name[j, 1] = temp[0, 1];
                    }

                }
            }

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("{0}: {1}", name[i, 0], marks[Convert.ToInt32(name[i,1]), 0]);
            }

        }
    }
}
