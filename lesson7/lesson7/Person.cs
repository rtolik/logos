using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Person
    {
        public string FullName { get; set; }

        public Person(string name)
        {
            FullName = name;
        }
        public virtual void Print()
        {
            Console.WriteLine("name: " + FullName);
        }
    }
}
