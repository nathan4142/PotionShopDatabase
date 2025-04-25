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
        : DataReaderDelegate<IReadOnlyList<(Store Store, int TotalGoldStars)>>("PotionShop.GetCoolestStores")
    {

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GoldStars", goldStars);
        }
        public override IReadOnlyList<(Store Store, int TotalGoldStars)> Translate(Command command, IDataRowReader reader)
        {
            var stores = new List<(Store, int)>();

            while (reader.Read())
            {
                var store = new Store(
                    reader.GetInt32("StoreID"),
                    reader.GetString("Address"),
                    reader.GetString("StateCode"),
                    reader.GetString("ZipCode"));

                int totalGoldStars = reader.GetInt32("TotalGoldStars");

                stores.Add((store, totalGoldStars));
            }

            return stores;
        }
    }
}
