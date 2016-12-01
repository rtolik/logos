using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Classes
{
    class Computer
    {
        public string model;
        public int price;
        public double cpu;
        public int ram;
        public bool isOn;

        const string  stModel = "Unknow";
        const int stPrice = 0;
        const double stCPU = 1.0;
        const int stRAM = 1;
        const bool stIsOn = false;

        public Computer (string newModel=stModel,int newPrice=stPrice,double newCPU=stCPU,int newRAM=stRAM, bool newIsOn=stIsOn)
        {
            newModel = model;
            newPrice = price;
            newCPU = cpu;
            newRAM = stRAM;
            newIsOn = isOn;
        }

        public Computer(string nModel,double nCPU,int nRAM):this(nModel,stPrice,nCPU,nRAM,stIsOn) {}

        public void PrintInfo()
        {
            Console.WriteLine(" Model: {0} \n Price: {1} \n CPU: {2}\n RAM: {3}\n Status: " , model,price,cpu,ram,isOn==true?"Is ON":"Is OFF" );
        }
        public void TurnOn()
        {
            isOn = true;
        }
        public void TurnOFF()
        {
            isOn = false;
        }
    }
}
