using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Dot:IDrowable
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        public Dot (int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Draw()
        {
            Console.WriteLine("Dot, placed in ({0};{1})",X,Y);
        }
    }
}
