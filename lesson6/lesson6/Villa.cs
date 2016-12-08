using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Villa:LivingPlace
    {
        protected int NumOfBathrooms {get;set;}

        protected bool HasFontain { get; set; }

        public Villa(int nNumOfBathrooms,bool nHasFontain,float nArea,int nNumOfRooms,string nLocation,float nPrice):base(nArea,nNumOfRooms,nLocation,nPrice)
        {
            NumOfBathrooms = nNumOfBathrooms;
            HasFontain = nHasFontain;
        }

        public override string ToString()
        {

            return base.ToString() + "\nNumber of bathrooms" + NumOfBathrooms + (HasFontain ? "\nHas fontain" : "\nHasn`t fontain");
        }
            

    }
}
