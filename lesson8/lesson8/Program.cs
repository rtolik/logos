using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Computer c1 = new Computer("Asus", 12345, 6);
            Person p1 = new Person("Ivan", 32);
            c1.Print();
            p1.Print();*/
            Dot d = new Dot(2, 5);
            Circle c = new Circle(5, 9, 12);
            Square s = new Square(8, 16, 5);
            d.Draw();
            Console.WriteLine();
            c.Draw();
            Console.WriteLine("Area is: " + c.GetArea());
            Console.WriteLine("perimetr is: " + c.GetPerimeter());
            Console.WriteLine();
            s.Draw();
            Console.WriteLine("Area is: " + s.GetArea());
            Console.WriteLine("perimetr is: " + s.GetPerimeter());
            
        }
    }
}
