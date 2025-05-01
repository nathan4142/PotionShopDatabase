using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetStoreInventoryValueByStoreDataDelegate(int storeID)
        : DataReaderDelegate<IReadOnlyList<(Store, decimal)>>("PotionShop.GetStoreInventoryValueByStore")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StoreID", storeID);
        }

        public override IReadOnlyList<(Store, decimal)> Translate(Command command, IDataRowReader reader)
        {
            var results = new List<(Store, decimal)> ();
            while (reader.Read ())
            {
                var store = new Store(
                    reader.GetInt32("StoreID"),
                    reader.GetString("Address"),
                    reader.GetString("StateCode"),
                    reader.GetString("ZipCode"));
                var inventory = reader.GetValue<decimal>("InventoryValue");
                results.Add((store, inventory));
            }
            return results;


        }

    }
}
