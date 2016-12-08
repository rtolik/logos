using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    sealed class Computer:Product
    {
        public string name;
        public string cpu;
        public bool touchScreen;
        public Display display;

        public Computer(string nName,string nCPU,bool nTouchScreen,float nPrice):base(1321654,nPrice)
        {
            name = nName;
            cpu = nCPU;
            touchScreen = nTouchScreen;
            display = new Display(nName, 0, 0, nPrice * 0.25f);
        }

        public override string ToString()
        {
            return "Name: " + name + "\nCPU: " + cpu + "\nTouchscreen: " + touchScreen + "\nPrice: " + Price;
        }
    }
}
