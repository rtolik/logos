using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Computer:IPrintable
    {
        string model;
        int price;
        int ram;

        public Computer(string nModel,int nPr,int nRam)
        {
            model = nModel;
            price = nPr;
            ram = nRam;
        }

        public void Print()
        {
            Console.WriteLine("Computer model: {0}\nPrice: {1}\nRAM: {2}", model, price, ram);
        }
    }
}
