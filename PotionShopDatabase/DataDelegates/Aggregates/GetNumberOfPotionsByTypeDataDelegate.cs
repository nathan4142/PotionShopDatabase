using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetNumberOfPotionsByTypeDataDelegate(int potionType)
        : DataReaderDelegate<IReadOnlyList<(Store, int)>>("PotionShop.GetNumberOfPotionsByType")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PotionTypeID", potionType);
        }

        public override IReadOnlyList<(Store, int)> Translate(Command command, IDataRowReader reader)
        {
            var results = new List<(Store, int)> ();
            while (reader.Read ())
            {
                var store = new Store(
                    reader.GetInt32("StoreID"),
                    reader.GetString("Address"),
                    reader.GetString("StateCode"),
                    reader.GetString("ZipCode"));
                var count = reader.GetInt32("PotionCount");

                results.Add((store, count));
            }
            return results;
        }

    }
}
