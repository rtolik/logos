using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    abstract class Product
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public string Country { get; set; }

        public Product(int nId,float nprice,string nCountry)
        {
            Id = nId;
            Price = nprice;
            Country = nCountry;
        }
    }
}
