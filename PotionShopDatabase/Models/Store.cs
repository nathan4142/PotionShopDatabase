using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.Models
{
    public class Store
    {
        public int StoreID { get; }
        public string Address { get; }
        public string StateCode { get; }
        public string ZipCode { get; }

        internal Store(int storeID, string address, string stateCode, string zipCode)
        {
            StoreID = storeID;
            Address = address;
            StateCode = stateCode;
            ZipCode = zipCode;
        }

    }
}
