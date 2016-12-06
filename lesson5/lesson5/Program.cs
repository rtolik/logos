using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Mouse m1 = new Mouse("Logitech", 5, 3200);
            m1.PrintInfo();
            m1.SetDPI(2005);
            m1.PrintInfo();
            */
            /*Employer man1 = new Employer("Balian", 1, 3000);
            man1.PrintInfo();
            man1.Salary=3200;
            man1.PrintInfo();
            Console.WriteLine("Salary from GetSalary: " + man1.Salary);
            man1.Salary=2700;
            man1.PrintInfo();
            Console.WriteLine(man1.Name);*/
            CustomFloat a = new CustomFloat(17, 0.32f);
            a.Print();
        }
    }
}
