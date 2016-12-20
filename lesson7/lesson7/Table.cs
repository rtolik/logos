using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Table:Furniture
    {
        public Table(int nId,float nprice,string nCountry,string nMaterial,string nStyle):base(nId, nprice, nCountry, nMaterial, nStyle)
        { }

    }
}
