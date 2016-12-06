using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Employer
    {
        private string name;
        private int id;
        private double salary;

        public string Name 
        {
            get 
            {
                return name;
            }
                   
            set 
            {
                name = value;
            }
        }
        
        public int Id
        {
            get
            {
                return id;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (salary - value > 500)
                {
                    salary -= 500;
                    return;
                }

                if (value - salary > 500)
                {
                    salary += 500;
                    return;
                }
                salary = value;
            }
        }

        public Employer(string newName="",int newId=0,double newSalary=0)
        {
            name = newName;
            id = newId;
            salary = newSalary;
        }

        public void PrintInfo()
        {
            Console.WriteLine(" Employer: {0} \n ID: {1} \n Salary: {2}", name, id, salary);
        }
    }
}
