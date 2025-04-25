using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetCoolestStoresDataDelegate(int goldStars)
        : DataReaderDelegate<IReadOnlyList<Store>>("PotionShop.GetCoolestStores")
    {

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GoldStars", goldStars);
        }
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
