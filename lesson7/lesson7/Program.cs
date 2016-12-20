using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Printer b = new Printer("Canon", 8000);
            b.GetParts();
            Notepad n1 = new Notepad(112, 45.5f, "China", 12);
            Table tab = new Table(1114, 450f, "Chicago", "DSP", "Romase");
            Chiar ch = new Chiar(1117, 450f, "Chicago", "DSP", "Romase");
            tab.GetStyle();*/
            /*Person p1 = new Person("GHJKG HJH");
            p1.Print();
            Citysen p2 = new Citysen("ksfdhbkl", "lviv");
            p2.Print();
            Person p3 = new Citysen("hudh", "isd");
            p3.Print();
            Person p4 = (Citysen)p2;
            Person p5 = p2 as Person;*/           //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            PersonN[] p1=new PersonN [0];
            Console.WriteLine("If you don`t want to write informatoin enter 0\nIf you want to write new employee enter 1 \nIf you want to write new employer, enter2");
            int action = int.Parse(Console.ReadLine());
            int i = 0;
            while(action!=0)
            {
                if(action==1)
                {
                    Console.WriteLine("Please enter full name");
                    string name=Console.ReadLine();
                    Console.WriteLine("Please enter age");
                    int age=int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter salary");
                    float salary=float.Parse(Console.ReadLine());
                    Array.Resize<PersonN>(ref p1, p1.Length + 1);
                    p1[i] = new Employee(name, age, salary);
                    i++;
                }
                if (action == 2)
                {
                    Console.WriteLine("Please enter full name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter age");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter company");
                    string company = Console.ReadLine();
                    Array.Resize<PersonN>(ref p1, p1.Length + 1);
                    p1[i] = new Employer(name, age, company);
                    i++;
                }
                Console.WriteLine("If you don`t want to add informatoin enter 0\nIf you want to add new employee enter 1 \nIf you want to add new employer, enter2");
                action = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int y=0;y<p1.Length;y++)
            {
                Console.WriteLine(p1[y]);
            }
        }
    }
}
