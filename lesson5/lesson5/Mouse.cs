using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Mouse
    {
        private int numberOfKeys;
        private int dpi;
        private string model;

        public Mouse(string newModel="",int newNumOfKeys=2,int newDPI=800)
        {
            model = newModel;
            SetDPI(newDPI);
            numberOfKeys = newNumOfKeys;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Mouse {0}, {1}, {2}", model, numberOfKeys, dpi);
        }

        public int GetDPI()
        {
            return dpi;
        }

        public void SetDPI(int newDPI)
        {
            dpi = newDPI - (newDPI % 400);
        }
    }
}
