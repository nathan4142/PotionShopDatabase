using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase
{
    internal interface IInventoryValueRepository
    {
        IReadOnlyList<(Store, decimal)> GetStoreInventoryValueByStore(int storeID);
    }
}
