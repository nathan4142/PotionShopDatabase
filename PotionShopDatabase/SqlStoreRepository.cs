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
    public class SqlStoreRepository(string connectionString) : IStoreRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public Store CreateStore(string address, string stateCode, string zipCode)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(address);
            ArgumentException.ThrowIfNullOrWhiteSpace(stateCode);
            ArgumentException.ThrowIfNullOrWhiteSpace(zipCode);

            var d = new CreateStoreDataDelegate(address, stateCode, zipCode);
            return executor.ExecuteNonQuery(d);

        }

        public IReadOnlyList<Store> GetAllStores()
        {
            return executor.ExecuteReader(new GetAllStoresDataDelegate());
        }

        public IReadOnlyList<Store> GetCoolestStores(int goldStars)
        {
            return executor.ExecuteReader(new GetCoolestStoresDataDelegate(goldStars));
        }

    }
}
