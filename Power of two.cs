﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograme
{
    internal class Power_of_two
    {
        public static void solution()
        {
            double result;
            Console.WriteLine("Enter The Power");
            int Power = int.Parse(Console.ReadLine());
            int a = 2;
            for (int i = 0; i <= Power; i++)
            {
                result = Math.Pow(a, i);
                Console.WriteLine(a + " power of " + i + " is " + result);
                Console.ReadLine();
            }
            }
    }
}
