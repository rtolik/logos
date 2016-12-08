using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Product
    {
        public readonly int id;
        private float price;

        protected float Price
        {
            get
            {
                return price;
            }

            set
            {
                price=(int)value+1-0.01f;
            }
        }
        
        public Product(int nId,float nPrice=10.99f)
        {
            id = nId;
            Price = nPrice;
        }

        public void PrintGeneralInfo ()
        {
            Console.WriteLine("Id: #{0}\nPrice: ${1}", id, Price);
        }
    }
}
