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
    public class SqlNumberOfPotionsByTypeRepository(string connectionString) : INumberOfPotionsByTypeRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public IReadOnlyList<(Store, int)> GetNumberOfPotionsByType(int potionType)
        {
            return executor.ExecuteReader(new GetNumberOfPotionsByTypeDataDelegate(potionType));
        }
    }
}
