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
    internal class GetAllOrdersDataDelegate()
        : DataReaderDelegate<IReadOnlyList<Order>>("PotionShop.GetAllOrders")
    {
        public override IReadOnlyList<Order> Translate(Command command, IDataRowReader reader)
        {
            var orders = new List<Order>();
            while (reader.Read())
            {
                orders.Add(new Order(
                    reader.GetInt32("OrderID"),
                    reader.GetInt32("StoreID"),
                    reader.GetDateTime("OrderedOn", DateTimeKind.Unspecified)));
            }
            return orders;
        }
    }
}
