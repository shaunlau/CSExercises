﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a double: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(number));
        }
    }
}
