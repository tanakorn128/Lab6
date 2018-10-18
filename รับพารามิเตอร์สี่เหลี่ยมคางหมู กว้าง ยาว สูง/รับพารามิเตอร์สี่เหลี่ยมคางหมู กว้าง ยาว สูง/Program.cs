using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace รับพารามิเตอร์สี่เหลี่ยมคางหมู_กว้าง_ยาว_สูง
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = pik(0.5,7,5);
            Console.WriteLine(k);
        }
        static double pik(params double[] i)
        {
            double sum = 1;
            foreach (double j in i)
                sum *= j;
            return sum;

        }
    }
}
