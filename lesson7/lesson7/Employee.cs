using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Employee:PersonN
    {
        float Salary { get; set; }

        public Employee(string nName,int nAge,float nSalary):base(nName,nAge)
        {
            Salary = nSalary;
        }

        public override string ToString()
        {
            return base.ToString() +"; " + Salary+"$";
        }
    }
}
