using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Student
    {
        private string name;
        private double grade1;
        private double grade2;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Split().Length < 2)
                {
                    throw new ArgumentException("The name must have a surname");
                }
                name = value;
            }
        }

        public double Grade1
        {
            get { return grade1; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("The grade must be between 0 and 10.");
                }
                grade1 = value;
            }
        }

        public double Grade2
        {
            get { return grade2; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("The grade must be between 0 and 10.");
                }
                grade2 = value;
            }
        }

        public double Average
        {
            get { return (grade1 + grade2) / 2; }
        }
    }
}
