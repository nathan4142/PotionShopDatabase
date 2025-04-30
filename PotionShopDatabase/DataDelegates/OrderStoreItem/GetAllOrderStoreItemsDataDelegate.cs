using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using PotionShopDatabase.Models;


namespace PotionShopDatabase.DataDelegates
{
    internal class GetAllOrderStoreItemsDataDelegate()
        : DataReaderDelegate<IReadOnlyList<OrderStoreItem>>("PotionShop.GetAllOrderStoreItems")
    {
        public override IReadOnlyList<OrderStoreItem> Translate(Command command, IDataRowReader reader)
        {
            var orderStoreItems = new List<OrderStoreItem>();
            while (reader.Read())
            {
                orderStoreItems.Add(new OrderStoreItem(
                    reader.GetInt32("OrderID"),
                    reader.GetInt32("StoreItemID"),
                    reader.GetInt32("ItemQuantity")));
            }
            return orderStoreItems;
        }
    }
}
