using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class LivingPlace
    {
        protected float price;

        public LivingPlace(float nArea=0,int nNumOfRooms=0,string nLocation="Unknown",float nPrice=0)
        {
            Area = nArea;
            NumOfRooms = nNumOfRooms;
            Location = nLocation;
            Price = nPrice;
        }

        public override string ToString()
        {
            return "Area: " + Area + "\nNumber of rooms: " + NumOfRooms + "\nLocation: " + Location + "\nPrice: " + Price;
        }

        protected float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value % 1000 == 0)
                {
                    price = value;
                    return;
                }
                if (value % 1000 >= 500)
                    price = value + (1000 - value % 1000);
                else
                    price = value - (value % 1000);
                   
            }
        }

        protected string Location {get;set;}

        protected float Area { get; set;}

        protected int NumOfRooms {get;set;}

    }
}
