using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_Kontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of square array");
            int num = int.Parse(Console.ReadLine());
            int[,] arr = CreateArr(num);
            Console.WriteLine("This Matrix is: ");
            PrintArr(arr, num);
            
        }
        static void PrintArr(int[,] arr,int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int y = 0; y < size; y++)
                {
                    Console.Write(arr[i, y] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int[,] CreateArr( int size)
        {
            int[,] array = new int[size, size];
            int atr = size;
            for (int i = 0; i < size; i++)
            {
                for (int y = 0; y < size; y++)
                {
                    array[i, y] = atr;
                    atr *= 2;
                }
                atr /= 4;
            }
            return array;
        }
    }
}
