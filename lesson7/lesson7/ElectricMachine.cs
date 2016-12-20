using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    abstract class ElectricMachine
    {
        public int Price{get;set;}
        public string ManuFactory{get;set;}

        public abstract int GetNumberOfParts();
    }
}
