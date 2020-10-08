using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Customer
    {

        private int _customerID;
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _email;
        private string _phoneNumber;

        public Customer(int customerID, string firstName, string lastName, int age, string email, string phoneNumber)
        {
            _customerID = customerID;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _email = email;
            _phoneNumber = phoneNumber;
        }
    }
}
