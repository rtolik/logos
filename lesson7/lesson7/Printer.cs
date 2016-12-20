using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Printer:ElectricMachine
    {
        public Printer(string manuf,int pr)
        {

        }

 

        public override int GetNumberOfParts()
        {
            return 3;
        }


    }
}
