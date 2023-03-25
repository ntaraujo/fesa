using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    internal class Workers
    {
        private int id;
        private string name;
        private string rg;
        private double salary;

        public int getId() => id;
        public string GetName() => name;
        public string getRg() => rg;
        public double getSalary() => salary;

        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("The id can't be less or equal zero");
            }
            else
            {
                this.id = id;
            }

        }
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name)) 
            {
                this.name = name;
            }
            else 
            {
                throw new Exception("Fill a name");
            }
        }
        public void setRg(string rg)
        {
            if (!string.IsNullOrEmpty(rg))
            {
                this.rg = rg;
            }
            else
            {
                throw new Exception("Fill a name");
            }
        }
        public void setSalary(double salary)
        {
            if (salary >= 0)
            {
                this.salary = salary;
            }
            else
            {
                throw new Exception("Salary must be positive or 0");
            }
        }

        public double getInss(double salary)
        {
            return salary * 0.11;
        }
        public double calculateSalary(double salary)
        {
            return (salary - getInss(salary));
        }

    }
}
