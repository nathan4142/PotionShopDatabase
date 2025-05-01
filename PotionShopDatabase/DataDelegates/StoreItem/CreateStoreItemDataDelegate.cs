using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class CreateStoreItemDataDelegate(int itemID, int storeID, int quantity, decimal ulp)
        : NonQueryDataDelegate<StoreItem>("PotionShop.CreateStoreItem")

    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ItemID", itemID);
            command.Parameters.AddWithValue("StoreID", storeID);
            command.Parameters.AddWithValue("Quantity", quantity);
            command.Parameters.AddWithValue("UnitListPrice", ulp);

            var p = command.Parameters.Add("StoreItemID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }

        public override StoreItem Translate(Command command)
        {
            return new StoreItem(command.GetParameterValue<int>("StoreItemID"), itemID, storeID, quantity, ulp);
        }
    }
}
