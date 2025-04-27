using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionShopDatabase.Models;
using PotionShopDatabase.DataDelegates;

namespace PotionShopDatabase
{
    public class SqlOrderRepository(string connectionString) : IOrderRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public Order CreateOrder(int storeID, DateTime orderedOn)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(storeID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(orderedOn));

            var d = new CreateOrderDataDelegate(storeID, orderedOn);
            return executor.ExecuteNonQuery(d);

        }

        public IReadOnlyList<Order> GetAllOrders()
        {
            return executor.ExecuteReader(new GetAllOrdersDataDelegate());
        }

    }
}
