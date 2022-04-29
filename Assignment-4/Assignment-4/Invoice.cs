using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Invoice
    {
        // Instance variables
        public string PartNumber { get; set; } // automated set the properties
        public string PartDesc { get; set; }
        private int qty;
        private double pItem; // price Item
        // Constructor
        public Invoice(string pt, string desc, int qt, double price)
        {
            PartNumber = pt;
            PartDesc = desc;
            qty = qt;
            pItem = price;
        }
        // Set and Get properties
        public int Qty
        {
            get
            {
            return qty;
            }

            set
            {
                if (value >= 0)
                {
                    qty = value;
                }
                
            }
        }
        // Set the properties for Price Item
        public double PItem
        {
            get
            {
                return pItem;
            }
            set
            {
                if (value >= 0)
                {
                    pItem = value;
                }
            }
        }

        public decimal GetIAmt()
        {
            return qty * (int)pItem;
        }
    }
}
