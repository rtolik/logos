using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson9
{
    class Program
    {
        class VeryBadError:ApplicationException
        {
            public VeryBadError()
                : base("Very bad message!")
            { }
        }

        class More2Spaces:ApplicationException
        {

            public More2Spaces(string message):base(message)
            {}
        }
        static void Main(string[] args)
        {/*
            FileStream file = new FileStream("D:\\111\\C#\\Romanjuk\\logos_test\\lesson9\\Newfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter w = new StreamWriter(file);
            w.WriteLine("Hello, my new file");
            w.WriteLine("Hi 2");
            w.Close();
            
            StreamReader r = new StreamReader( new FileStream("D:\\111\\C#\\Romanjuk\\logos_test\\lesson9\\Newfile.txt", FileMode.Open, FileAccess.Read));
            Console.WriteLine(r.ReadToEnd());

           
            r.Close();
            /*int res = 0;
            try
            {
                Console.WriteLine("Enter number");
                int num = int.Parse(Console.ReadLine());
                if(num>1999)
                {
                    throw new VeryBadError();
                }
                res = 5 / num;
            }
            catch (VeryBadError e)
            {
                Console.WriteLine("!!!Error Stack overflow\nInfo: {0}", e.Message);
            }
            catch(System.DivideByZeroException e)
            {
                Console.WriteLine("!!!Error: {0}\n Info: {1}","Divide by zero",e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("!Error");
            }
            
            finally
            {
                Console.WriteLine("Finally code!");
            }*/
            Calc();
        }

        static void Calc()
        {
            Console.WriteLine("Please enter query:");
            string query = Console.ReadLine();
            int num1 = 0, num2 = 0;
            int[] spaces = new int[0];
            int spaceind = 0;
            char operation = '0';
            try
            {
                for (int i = 0; i < query.Length; i++)
                {
                    if(query[i]==' ')
                    {
                        Array.Resize(ref spaces, spaces.Length + 1);
                        spaces[spaceind] = i;
                        spaceind++;
                    }
                }
                if (spaces.Length > 2)
                    throw new More2Spaces("Your query has more than 2 spases");
            }
            catch(More2Spaces err)
            {
                Console.WriteLine(err.Message);
                return;
            }
               for (int i=0;i<spaces.Length;i++)
               {
                    if(i==0)
                    {
                        num1 = int.Parse(query.Substring(0, spaces[i]));
                        continue;
                    }
                    if(i>0)
                    {
                        operation = (char)query[spaces[i] - 1];
                        num2 = int.Parse(query.Substring(spaces[i] + 1, (query.Length - spaces[i] - 1)));
                    }
               }
                if (operation == '+')
                    Console.WriteLine("Rezult of {0}={1}", query, num1 + num2);
                if (operation == '-')
                    Console.WriteLine("Rezult of {0}={1}", query, num1 - num2);
                if (operation == '*')
                    Console.WriteLine("Rezult of {0}={1}", query, num1 * num2);
                if (operation == '/')
                    Console.WriteLine("Rezult of {0}={1}", query, num1 / num2);
        }
    }
}
