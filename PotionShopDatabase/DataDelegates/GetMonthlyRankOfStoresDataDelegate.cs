using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetMonthlyRankOfStoresDataDelegate(DateTime firstDate, DateTime secondDate)
        : DataReaderDelegate<IReadOnlyList<(int, int, Store, decimal, int)>>("PotionShop.GetMonthlyRankOfStoresByProfit")
    {

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("FirstDate", firstDate);
            command.Parameters.AddWithValue("SecondDate", secondDate);
        }

        public override IReadOnlyList<(int, int, Store, decimal, int)> Translate(Command command, IDataRowReader reader)
        {
            var results = new List<(int, int, Store, decimal, int)>();
            while (reader.Read())
            {
                var year = reader.GetInt32("Year");
                var month = reader.GetInt32("Month");
                var store = new Store(
                    reader.GetInt32("StoreID"),
                    reader.GetString("Address"),
                    reader.GetString("StateCode"),
                    reader.GetString("ZipCode"));
                var sales = reader.GetValue<decimal>("Sales");
                var rank = (int)reader.GetValue<long>("Rank");

                results.Add((year, month, store, sales, rank));
            }
            return results;

        }
    }
}
