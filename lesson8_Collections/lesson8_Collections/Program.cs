using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           /* List<int> tmp = new List<int>()
            {
                6,8,3,4,56,3
            };
            tmp.Add(3);
            tmp.Add(4);
            tmp.AddRange(new int[] { 5, 7, 23, 90, 3 });
            /*foreach(int el in tmp)
            {
                Console.WriteLine(el);
            }*/

            //Stack<char> symb = new Stack<char>();
            /*symb.Push('v');
            symb.Push('b');
            symb.Push('n');
            symb.Push('9');
            while(symb.Count>0)
            {
                Console.WriteLine(symb.Pop());
            }
             */
            CheckLine(Console.ReadLine());
        }
        static void CheckLine(string line)
        {
            Stack<char> symb = new Stack<char>();
            for(int i=0;i<line.Length;++i)
            {
                if(line[i]=='{'||line[i]=='['||line[i]=='(')
                {
                    symb.Push(line[i]);
                }
                else 
                    if(line[i]=='}'||line[i]==']'||line[i]==')')
                    {
                        if (line[i] - symb.Peek() < 3)
                        {
                            if (symb.Count > 0)
                                symb.Pop();
                            else
                            {
                                Console.WriteLine("Error!!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong!!!");
                            return;
                        }
                    }
            }
            if (symb.Count > 0)
            {
                Console.WriteLine("Error!!!");
            }
            else
                Console.WriteLine("It`s good!!!");
        }
    }
}
