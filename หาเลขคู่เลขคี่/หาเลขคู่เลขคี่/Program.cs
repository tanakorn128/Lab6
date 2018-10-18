using System;
using System.Net;
using System.IO;


namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Out(input());
            Console.ReadKey();

        }
        static int input()
        {
            int num;
            Console.WriteLine("ENTER NUMBER");
            int.TryParse(Console.ReadLine(), out num);
            return num;
        }
        static void Out(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
