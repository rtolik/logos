using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Square:IDrowable,IGeometrical
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected float Heigh { get; set; }

        public Square(int x,int y, float heigh)
        {
            X = x;
            Y= y;
            Heigh = heigh;
        }

        public void  Draw()
        {
            Console.WriteLine("Square with left upper dot in ({0},{1}) and heigh {2}", X, Y, Heigh);
        }

        public float GetArea()
        {
            return Heigh * Heigh;
        }
        public float GetPerimeter()
        {
            return 2 * Heigh;
        }
    }
}
