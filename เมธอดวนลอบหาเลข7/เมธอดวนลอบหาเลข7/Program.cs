using System;
using System.Collections.Generic;
using System.Linq;

namespace เมธอดวนลอบหาเลข7
{
    class Program
    {
        static void Main(string[] args)
        {
            searching(1,2,3,4,5,7,14,21);
        }
        static void searching (params int[] list)
        {
            for (int num = 0; num <= list.Length; num++)
            {
                if (num % 7 == 0)
                {
                    Console.WriteLine(list[num] + "");
                }
            }
            
        }
    }
}
