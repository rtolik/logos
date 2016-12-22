using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Circle:IDrowable,IGeometrical
    {
        protected  int X { get; set; }
        protected int Y { get; set; }
        protected float Radius { get; set; }

        public Circle(int x,int y, float r)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        public void Draw()
        {
            Console.WriteLine("Circle with center in ({0};{1}) and radius {2}", X, Y, Radius);
        }

        public float GetArea()
        {
            return 3.14f* Radius*Radius;
        }
        public float GetPerimeter()
        {
            return 2 * 3.14f * Radius;
        }
    }
}
