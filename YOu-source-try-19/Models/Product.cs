using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YOu_source_try_19.Models
{
    public class Product
    {
        public int ProductID{ get; set; }
        public int MerchantID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


    }
}
