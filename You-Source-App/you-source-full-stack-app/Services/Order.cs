using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Order
    {
        private int _orderID;
        private int _productID;
        private int _customerID;
        private string _senderMail;
        private string _recipientMail;

        public Order(int orderID, int productID, int customerID, string senderMail, string recipientMail)
        {
            _orderID = orderID;
            _productID = productID;
            _customerID = customerID;
            _senderMail = senderMail;
            _recipientMail = recipientMail;
        }
    }
}
