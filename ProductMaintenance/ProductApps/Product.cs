using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        // Variable for adding Delivery Charge
        private decimal totalChange;

        // Variable for adding Wrap Charge
        private decimal totalWrapCharge;

        // Variable for adding GST Charge
        private decimal totalGSTCharge;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        public decimal TotalCharge
        {
            get { return totalChange; }
            set { totalChange = value; }
        }

        public decimal TotalWrapCharge
        {
            get { return totalWrapCharge; }
            set { totalWrapCharge = value; }
        }

        public decimal TotalGSTCharge
        {
            get { return totalGSTCharge; }
            set { totalGSTCharge = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        public void calTotalCharge()
        {
            TotalCharge = TotalPayment + 25;
        }

        public void calTotalWrapCharge()
        {
            TotalWrapCharge = TotalCharge + 5;
        }

        public void calTotalGSTCharge()
        {
            // type cast to double for mathematic process
            TotalGSTCharge = (decimal)((double)TotalWrapCharge + ((double) TotalWrapCharge * 0.1));
        }
    }
}
