using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.Models
{
    public class OrderStoreItem
    {
        public int OrderID { get; }
        public int StoreItemID { get; }
        public int ItemQuantity { get; }

        internal OrderStoreItem(int orderID, int storeItemID, int itemQuantity)
        {
            OrderID = orderID;
            StoreItemID = storeItemID;
            ItemQuantity = itemQuantity;
        }



    }
}
