using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        public int id;
        public string name;
        public decimal price;
        public double discountPercentage;

        public decimal CalculateCostAfterDiscount()
        {
            decimal discountAmount = price * (decimal)(discountPercentage / 100);
            return price - discountAmount;
        }
    }


}