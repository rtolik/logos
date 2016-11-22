using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int action;
            double rez,n1, n2;
            Console.WriteLine("Please enter first number:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please choose action: \n 1) + \n 2) - \n 3) * \n 4) /");
            action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1: rez=n1+n2;
                    break;
                case 2: rez = n1 - n2;
                    break;
                case 3: rez = n1 * n2;
                    break;
                case 4: rez = n1 / n2;
                    break;
                default:
                    {
                        Console.WriteLine("You have entered wrong action. Try again");
                    }
                    break;
            }
            Console.WriteLine("Rezult is: " + rez);
             */
            /*
            Console.WriteLine("Enter the year:");
            double rik = int.Parse(Console.ReadLine());
            if (rik % 4==0 && rik % 400 != 0)
            {
                Console.WriteLine("Year is intercalary");
            }
            else
            {
                Console.WriteLine("Year isn`t intercalary");
            }
            */
            /*
            Console.WriteLine("Please enter all triangle sides:");
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(a+b>c && a+c>b && c+b>a)
            {
                Console.WriteLine("This triangle exists!");
            }
            else
            {
                Console.WriteLine("This triangle doesn`t exist!");
            }
              */
           /*
            int a,sum=0, avg;
            for (int i=0;i<5;i++)
            {
                a = int.Parse(Console.ReadLine());
                sum += a;
            }
            avg = sum / 5;
            Console.WriteLine("Avarage rezult is: {0}" , avg);
            */
            /*
            int sum=0, num, kt=0;
            double avg;
            Console.WriteLine("Plese enter numbers to count avarage. If you want to stop press \"0\"");
            do
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                kt += 1;
            } while (num != 0);
            avg = sum / kt;
            Console.WriteLine("Avarage rezult is: {0}", avg);
            */
            Console.WriteLine("Enter number of lines");
            int k=int.Parse(Console.ReadLine());
            int left=22,right=22;
            for (int i=0;i<k;i++)
            {
                for (int y=0;y<45;y++)
                {
                    if (y >= left && y <= right)
                    {
                        Console.Write("^");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                left -= 1;
                right += 1;
            }

        }
    }
}
