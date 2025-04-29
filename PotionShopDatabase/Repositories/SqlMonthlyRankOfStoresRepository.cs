using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using PotionShopDatabase.Models;
using PotionShopDatabase.DataDelegates;

namespace PotionShopDatabase.Repositories
{
    public class SqlMonthlyRankOfStoresRepository(string connectionString) : IMonthlyRankOfStoresRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public IReadOnlyList<(int, int, Store, decimal, int)> GetMonthlyRankOfStores(DateTime firstDate, DateTime secondDate)
        {
            return executor.ExecuteReader(new GetMonthlyRankOfStoresDataDelegate(firstDate, secondDate));
        }
    }
}
