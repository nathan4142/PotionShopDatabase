using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using PotionShopDatabase.Models;
using System.Data;

namespace PotionShopDatabase.DataDelegates
{
    internal class CreateOrderStoreItemDataDelegate(int orderID, int storeItemID, int itemQuantity)
        : NonQueryDataDelegate<OrderStoreItem>("OrderStoreItem.CreateOrderStoreItem")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("OrderID", orderID);
            command.Parameters.AddWithValue("StoreItemID", storeItemID);
            command.Parameters.AddWithValue("ItemQuantity", itemQuantity);
        }

        public override OrderStoreItem Translate(Command command)
        {
            // Since OrderItem has a composite key and no identity output,
            // we just return a new instance with the provided values.
            return new OrderStoreItem(orderID, storeItemID, itemQuantity);
        }
    }
}
