using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Citysen:Person
    {
        public string City { get; set; }

        public Citysen(string name, string ct):base(name)
        {
            City = ct;
        }

        public override void Print()
        {
            Console.WriteLine("Fullname: {0} lives in {1}",FullName, City);
        }
    }
}
