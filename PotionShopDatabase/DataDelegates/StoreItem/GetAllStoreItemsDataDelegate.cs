using System.Data.SqlClient;
using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetAllStoreItemsDataDelegate()
        : DataReaderDelegate<IReadOnlyList<StoreItem>>("PotionShop.GetAllStoreItems")
    {
        public override IReadOnlyList<StoreItem> Translate(Command command, IDataRowReader reader)
        {
            var storeItems = new List<StoreItem>();
            while (reader.Read())
            {
                storeItems.Add(new StoreItem(
                    reader.GetInt32("StoreItemID"),
                    reader.GetInt32("ItemID"),
                    reader.GetInt32("StoreID"),
                    reader.GetInt32("Quantity"),
                    reader.GetValue<decimal>("UnitListPrice")
                    ));
            }
            return storeItems;
        }
    }
}
