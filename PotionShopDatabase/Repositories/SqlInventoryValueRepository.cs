using DataAccess;
using PotionShopDatabase.DataDelegates;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.Repositories
{
    public class SqlInventoryValueRepository(string connectionString) : IInventoryValueRepository
    {

        private readonly SqlCommandExecutor executor = new(connectionString);

        public IReadOnlyList<(Store, decimal)> GetStoreInventoryValueByStore(int storeID)
        {
            return executor.ExecuteReader(new GetStoreInventoryValueByStoreDataDelegate(storeID));
        }

    }
}
