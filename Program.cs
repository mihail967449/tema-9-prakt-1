using System;
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
            int[] array = new int[] { 74, 0, 50, 46, 34, 46, 0, 13 };
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            int[] arrayy = new int[] { 13, 0, 50, 46, 34, 46, 0, 74 };
            foreach (int element in array)
            {
                Console.WriteLine(element);
                int result = element * element;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
