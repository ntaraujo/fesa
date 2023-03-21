using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Workers
    {
        private int id;
        private string name;
        private string rg;
        private double salary;

        public int Id
        {
            get { return id; }
            set {
                if (id <= 0)
                {
                    throw new Exception("The id can't be less or equal zero");
                }
                else                
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(name))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Fill a name");
                }
            }
        }
        public string Rg
        {
            get { return rg; }
            set 
            {
                if (!string.IsNullOrEmpty(rg))
                {
                    rg = value;
                }
                else
                {
                    throw new Exception("Fill a name");
                }
            }
        }
        public double Salary
        {
            get { return salary; }
            set 
            {
                if (salary >= 0)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("Salary must be positive or 0");
                }
            }
        }


        public double Inss
        {
            get { return salary * 0.11; }
        }
        public double calculateSalary
        {
            get{ return (salary - Inss); }
        }
    }
}
