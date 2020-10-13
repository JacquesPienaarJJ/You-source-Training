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

        public int ProductID { get => _productID; set => _productID = value; }
        public int MerchantID { get => _merchantID; set => _merchantID = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public Product()
        {

        }
        public Product(int productID, int merchantID, string productName, int quantity)
        {
            ProductID = productID;
            MerchantID = merchantID;
            ProductName = productName;
            Quantity = quantity;
        }

        public List<Product> GetProducts()
        {
            
        }

    }
}
