﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[12];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                array[i] = rnd.Next(163, 190);
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }
        }
    }
}
