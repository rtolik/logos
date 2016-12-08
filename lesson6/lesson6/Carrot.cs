using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Carrot:Product
    {
        public float length;

        public Carrot(int nId,float nPrice,float nLength):base(nId,nPrice)
        {
            length = nLength;
        }

        public new void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine("Length: {0}cm\nType: {1}",length,GetType());
        }
    }
}
