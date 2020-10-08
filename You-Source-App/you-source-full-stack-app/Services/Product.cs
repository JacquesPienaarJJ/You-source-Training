using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Product
    { 
        private int _productID;
        private int _merchantID;
        private string _productName;
        private int _quantity;

        public Product(int productID, int merchantID, string productName, int quantity)
        {
            _productID = productID;
            _merchantID = merchantID;
            _productName = productName;
            _quantity = quantity;
        }
    }
}
