using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i1, i2;
            Console.WriteLine("Enter first number");
            i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            i2 = int.Parse(Console.ReadLine());
            int sum = i1 + i2;
            Console.WriteLine("Sum=" + sum);
            int rizn = i1 - i2;
            Console.WriteLine("Rizn=" + rizn);
            int dob = i1 * i2;
            Console.WriteLine("Dobutok=" + dob);
            //double chas = i1*1.0f / i2;
            double chas=(double)(i1)/i2;
            Console.WriteLine("Chastka=" + chas);*/
            Console.WriteLine("Enter number from 1 to 7");
            int num = int.Parse(Console.ReadLine());
            int tmp = num;
            int b3 = tmp % 2;
            tmp /= 2;
            int b2 = tmp % 2;
            tmp /= 2;
            int b1 = tmp % 2;
            Console.WriteLine("{0}={1}{2}{3}", num, b1, b2, b3);
        }
    }
}
