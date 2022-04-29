using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_11
{
    class Employee
    {
        // Instance Varialbles
        public string FName { get; set; }
        public string LName { get; set; }

        private decimal mSal;

        // Constructor
        public Employee(string f, string l, decimal sal)
        {
            FName = f;
            LName = l;
            mSal = sal;
        }

        // Properties

        public decimal MSal {


            get
            {
                return mSal;
            }
            set
            {
                // Check either salary is non negative
                if (value >= 0)
                {
                    mSal = value;
                }
            }
        }
    }
}
