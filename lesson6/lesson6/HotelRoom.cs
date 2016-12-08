using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class HotelRoom:LivingPlace 
    {
        private int numOfPlaces;
        private float pricePerPlace;
        private new float price;

        protected int NumOfPlaces
        {
            get 
            {
                return numOfPlaces;
            }
            set
            {
                numOfPlaces = value;
                Price = NumOfPlaces * PricePerPlase;
            }
        }

        protected float PricePerPlase 
        {
            get
            {
                return pricePerPlace;
            }
            set 
            {
                pricePerPlace = value;
                Price = NumOfPlaces * PricePerPlase;
            }
        }

        protected  float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public HotelRoom(int nNumOfPlaces,float nPricePerPlace, float nArea,int nNumOfRooms,string nLocation,float nPrice):base(nArea, nNumOfRooms, nLocation, nPrice)
        {
            NumOfPlaces=nNumOfPlaces;
            PricePerPlase = nPricePerPlace;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of places" + NumOfPlaces + "\nPrice per place" + "\nPrice for whole room" + Price;
        }
    }
}
