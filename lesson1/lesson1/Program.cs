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
                Console.WriteLine("This triangle doesn`t exist! \a");
            }
        }
    }
}
