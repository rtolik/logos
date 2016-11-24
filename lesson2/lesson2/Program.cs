using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int [] students=new int [6];
            for (int i=0;i<students.Length;i++)
            {
                students[i]=int.Parse(Console.ReadLine());
            }
            for (int i=0;i<students.Length;i++)
            {
                Console.WriteLine("Student #{0} has {1} points.", i + 1, students[i]);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////// 
            int[] num = { 1, 2, -1, 7, -10, 17, -86, 14 };
            int plusNums = 0;
            for (int i=0;i<num.Length;i++)
            {
                if (num[i] >= 0)
                {
                    Console.WriteLine(num[i]);
                    plusNums += 1;
                }
            }
            Console.WriteLine("All number more than 0 are {0}", plusNums);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            int[] nums = new int[10];
            Console.WriteLine("Please enter 10 numbers");
            int maks = int.MinValue;
            for (int i=0;i<nums.Length;i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (maks < nums[i]) maks = nums[i];
            }
            Console.WriteLine("Maximum number in this set is {0}", maks);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //int[] nums = { 1, 3, 5, 0, 2, 7, 9, 0, 1, 1 };
             * 
            int[] nums = new int[10];
            Console.WriteLine("Please enter 10 numbers");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter category of numbers to show (Between zero/Till zero)");
            string choise = Console.ReadLine();
            choise = choise.ToLower();
            bool mode;
            if (choise == "between zero") mode = true;
            else mode = false;
            if (mode) Console.WriteLine("Numbers between  zero:");
            else Console.WriteLine("Numbers till zero");
            int zero=0;
            for (int i=0;i<nums.Length;i++)
            {
                if (nums[i] == 0)
                {
                    zero += 1;
                   // i++;
                    continue;
                }
                if(mode)
                {
                    if (zero % 2 != 0) Console.Write(nums[i]+" ");
                }
                else
                {
                    if (zero%2 == 0) Console.Write(nums[i]+" ");
                }
            }
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////// 
            int[] nums = { 1, 3, 5, 0, 2, 7, 9, 0, 1, 1 };
            foreach(int el in nums)
            {
                Console.WriteLine(el);
            }
            //////////////////////////////////////////////////////////////////////////////////
            //int [,]mas=new int[4,5];                mas2
            // int [][] nazv=new int [4][];           shidchastiy masiv
            int [,] mas2 =new int [4,3];
            for (int i=0;i<4;i++)
            {
                for (int y=0;y<3;y++)
                {
                    mas2[i,y] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(mas2[i, y] + "\t");
                }
                Console.WriteLine();
              }
             ////////////////////////////////////////////////////////
            
            int [][] ar2=new int[3][];
            for (int i=0;i<3;i++)
            {
                ar2[i]=new int[i+1];
            }
            for (int i=0;i<3;i++)
            {
                for (int y=0; y<ar2[i].Length;y++)
                {
                    ar2[i][y] =int.Parse(Console.ReadLine());
                }
            }
            int max=int.MinValue;
            for (int i=0;i<3;i++)
            {
                for (int y=0; y<ar2[i].Length;y++)
                {
                    Console.Write(ar2[i][y]+"\t");
                    if (ar2[i][y]>max) max=ar2[i][y];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Maximum is {0}",max);
            /////////////////////////////////////////////////////////////////////////////////////////////////
            int[,] mas = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    mas[i, y] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Your table");
            int sum = 0;
            for (int i=0;i<4;i++)
            {
                if (i % 2 == 0)
                    for (int y = 0; y < 3; y++)
                    {
                        sum += mas[i,y];
                    }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(mas[i, y] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of unpair lines is:{0}", sum);
            */
            int[,] square = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    square[i, y] = i+y;
                }
            }
            Console.WriteLine("Table:");
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(square[i, y] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (i > y) sum += square[i, y];
                }
            }
            Console.WriteLine("Sum of elements under main diagonal is: " + sum);
       }
   }
}

