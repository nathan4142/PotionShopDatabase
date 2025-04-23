using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionShopDatabase.DataDelegates;
using PotionShopDatabase.Models;
using System.Data;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetAllStoresDataDelegate()
        : DataReaderDelegate<IReadOnlyList<Store>>("PotionShop.GetAllStores")
    {
        public override IReadOnlyList<Store> Translate(Command command, IDataRowReader reader)
        {
            var stores = new List<Store>();

            while (reader.Read())
            {
                stores.Add(new Store(
                    reader.GetInt32("StoreID"),
                    reader.GetString("Address"),
                    reader.GetString("StateCode"),
                    reader.GetString("ZipCode")));
            }

            return stores;
        }

    }
}
