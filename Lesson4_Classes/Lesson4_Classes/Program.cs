using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Samsung rv 508",10500,2.3,3,false);
            myComputer.PrintInfo();


        }
    }
}
