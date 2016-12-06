using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class CustomFloat
    {
        private int part1;
        private float part2;
        


        public CustomFloat (int beforeDot,float afterDot)
        {
            part1 = beforeDot;
            if (Math.Abs(afterDot) < 1)
                part2 = afterDot;
            else part2 = afterDot - (float)Math.Truncate((double)afterDot);
        }

        public CustomFloat(float numb)
        {
            int beforeDot = (int)Math.Truncate(numb);
            float afterDot = numb-beforeDot;
            part1 = beforeDot;
            part2 = afterDot;
            
        }  

        public void Print()
        {
            Console.WriteLine("Number is {0}.{1}", part1, part2);
        }
    }
}
