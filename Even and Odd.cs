﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograme
{
    internal class Even_and_Odd
    {
        public static void solution()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.ReadLine();
            }
            }

        }
    }
