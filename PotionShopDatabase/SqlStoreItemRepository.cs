using DataAccess;
using PotionShopDatabase.DataDelegates;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase
{
    public class SqlStoreItemRepository(string connectionString) : IStoreItemRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public StoreItem CreateStoreItem(int itemID, int storeID, int quantity, decimal ulp)
        {
            
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(itemID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(storeID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(quantity));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(ulp));

            var d = new CreateStoreItemDataDelegate(itemID, storeID, quantity, ulp);
            return executor.ExecuteNonQuery(d);
        }
    }
    
}
