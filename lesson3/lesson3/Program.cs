using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter number to try abs");
            int number = int.Parse(Console.ReadLine());
            int absnum=MyAbs(number);
            Console.WriteLine("Abs of your number is: " + absnum);
            ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter argument for function");
            double num = double.Parse(Console.ReadLine()),rez;
            Console.WriteLine("Rezult is: "+(rez = Funct(num)));
            ///////////////////////////////////////////////////////////////////////
            int size;
            Console.WriteLine("Enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            Console.WriteLine("Please enter elements for this array");
            for(int i=0;i<mas.Length;i++)
            {
                mas[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of all elements is: " + SumMas(mas));
            //////////////////////////////////////////////////////////////////////// 
            
            int size;
            Console.WriteLine("Enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] ar = CreateAr(size);
            for(int i=0;i<size;i++)
            {
                Console.Write(ar[i]+" ");
            }
            ////////////////////////////////////////////////////////////////////////
             */
            //Mods(14,16);
            int[] mas={1,4,8,5,7,3,6,2};
            int min,max;
            MinMax(mas, out min, out max);
            Console.WriteLine("Array: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Minimum in array is: {0} \nMaximum in array is {1}", min, max);
        }

        static double Funct (double x)
        {
            if (5 > x && x > -5) 
            {
                return (Math.Pow(x,2) + 29 * x - 16);
            }
                return (Math.Pow(x, 4) - 79);
        }

        static int MyAbs(int num)
        {
            if (num > 0)
            {
                return (num);
            }
            else
            {
                return (-num);
            }
        }
     
        static int SumMas(int []mas)
        {
            int sum = 0;
            for(int i=0;i<mas.Length;i++)
            {
                sum += mas[i];
            }
            return (sum);
        }

        static int[] CreateAr(int size)
        {
            int[] mas = new int[size];
            for (int i=0;i<size;i++)
            {
                mas[i] = i;
            }
            return mas;
        }

        static void Mods(params int[] arg)
        {
            switch(arg.Length)
            {
                case(1):
                    {
                        Console.WriteLine("Line with length " + arg[0]);
                    }
                    break;
                case(2):
                    {
                        Console.WriteLine("Isoscles rectangle with sides 2x{0} and {1}", arg[0], arg[1]);
                    }
                    break;
                case(3):
                    {
                        Console.WriteLine("Triangle with S1={0} S2={1} S3={2}", arg[0], arg[1], arg[2]);
                    }
                    break;
                case(4):
                    {
                        Console.WriteLine("Rectangle with S1={0} S2={1} S3={2},S4={3}", arg[0], arg[1], arg[2], arg[3]);
                    }
                    break;
                default: Console.WriteLine("More than 4 parameters");
                    break;
            }

        }

        static void MinMax(int[] mas,out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;
            for(int i=0;i<mas.Length;i++)
            {
                if (mas[i] < min) min = mas[i];
                if (mas[i] > max) max = mas[i];

            }
        }
    }
}
