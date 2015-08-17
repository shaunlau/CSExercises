using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            double A, B, C, HCF, LCM;
            Console.Write("Enter A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter B: ");
            B = Convert.ToDouble(Console.ReadLine());
            C = A * B;
            do
            {
                if (A < B)
                {
                    B = B - A;
                }
                else if (B < A)
                {
                    A = A - B;
                }
            } while(A != B);

            HCF = A;

            LCM = C / HCF;

            Console.WriteLine("HCF: {0}", HCF);
            Console.WriteLine("LCM: {0}", LCM);
        }
    }
}
