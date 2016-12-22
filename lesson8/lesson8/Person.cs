using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Person:IPrintable
    {
        string name;
        int age;

        public Person(string nName,int nAge)
        {
            name = nName;
            age = nAge;
        }

        public void Print()
        {
            Console.WriteLine("Person name: {0}\nAge: {1}",name,age);
        }
    }
}
