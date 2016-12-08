using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Display:Product
    {
        public string model;
        public int widh;
        public int heigh;
        
        
        public string Resolution
        {
            get
            {
                return widh + "x" + heigh;
            }
        }

        public Display(string nModel,int nWigh,int nHeigt,float nPrice):base(49687445,nPrice)
        {
            model = nModel;
            widh=nWigh;
            heigh = nHeigt;
        }
    }
}
