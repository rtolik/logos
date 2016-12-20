using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Employer:PersonN
    {
        string Company { get; set; }
        public Employer(string nName,int nAge,string nCompany):base(nName,nAge)
        {
            Company = nCompany;
        }
        public override string ToString()
        {
            return base.ToString() + "from"+Company;
        }
    }
}
