using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    abstract class PersonN
    {
        string FullName { get; set; }
        int Age { get; set; }
        public PersonN(String nName,int nAge)
        {
            FullName = nName;
            Age = nAge;
        }
        public override string ToString()
        {
            return FullName+"-"+Age;
        }
    }
}
