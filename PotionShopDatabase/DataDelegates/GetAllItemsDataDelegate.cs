using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetAllItemsDataDelegate()
        : DataReaderDelegate<IReadOnlyList<Item>>("PotionShop.GetAllItems")
    {

        public override IReadOnlyList<Item> Translate(Command command, IDataRowReader reader)
        {
            var items = new List<Item>();

            while (reader.Read())
            {
                items.Add(new Item(
                    reader.GetInt32("ItemID"),
                    reader.GetString("Name"),
                    reader.GetValue<decimal>("Price"),
                    (PotionType)reader.GetByte("PotionTypeID")));
            }

            return items;
        }
    }
}
