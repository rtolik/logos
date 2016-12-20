using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Notepad:Product
    {
        int NumOfPages{get;set;}
        
        public Notepad(int id,float pr,string country,int pages):base(id,pr,country)
        {
            NumOfPages = pages;
        }
    }
}
