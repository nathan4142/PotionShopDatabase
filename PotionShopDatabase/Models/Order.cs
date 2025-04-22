using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.Models
{
    public class Order
    {
        public int OrderID { get; }
        public int StoreID { get; }
        public DateTime OrderedOn { get; }

        internal Order(int orderID, int storeID, DateTime orderedOn)
        {
            this.OrderID = orderID;
            this.StoreID = storeID;
            this.OrderedOn = orderedOn;
        }

    }
}
