using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using PotionShopDatabase.Models;
using System.Data;

namespace PotionShopDatabase.DataDelegates
{
    internal class CreateOrderDataDelegate(int storeID, DateTime orderedOn)
        : NonQueryDataDelegate<Order>("Order.CreateOrder")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StoreID", storeID);
            command.Parameters.AddWithValue("OrderedOn", orderedOn);

            var p = command.Parameters.Add("OrderID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }

        public override Order Translate(Command command)
        {
            return new Order(command.GetParameterValue<int>("OrderID"), storeID, orderedOn);
        }

    }
}
