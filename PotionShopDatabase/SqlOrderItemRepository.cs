using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using PotionShopDatabase.Models;
using PotionShopDatabase.DataDelegates;

namespace PotionShopDatabase
{
    public class SqlOrderItemRepository(string connectionString) : IOrderItemRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public OrderItem CreateOrderItem(int orderID, int storeItemID, int itemQuantity)
        {
            
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(orderID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(storeItemID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(itemQuantity));

            var d = new CreateOrderItemDataDelegate(orderID, storeItemID, itemQuantity);
            return executor.ExecuteNonQuery(d);
        }
    }
}
