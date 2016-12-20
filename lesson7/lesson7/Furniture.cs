using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    abstract class Furniture:Product
    {
        public string Material { get; set; }
        public string Style { get; set; }

        public Furniture(int nId,float nPrice,string nCountry,string nMaterial,string nStyle):base(nId,nPrice,nCountry)
        {
            Material = nMaterial;
            Style = nStyle;
        }

        public void GetStyle()
        {
            Console.WriteLine("Style of Product is:" + Style);
        }
    }
}
