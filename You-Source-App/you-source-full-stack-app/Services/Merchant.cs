using System;

namespace Services
{
    public class Merchant
    {
        private int _merchantID;
        private string _merchantName;
        private string _country;

        public int MerchantID { get => _merchantID; set => _merchantID = value; }
        public string MerchantName { get => _merchantName; set => _merchantName = value; }
        public string Country { get => _country; set => _country = value; }

        public Merchant(int merchantID, string merchantName, string country)
        {
            this._merchantID = merchantID;
            this._merchantName = merchantName;
            this._country = country;
        }
    }
}
