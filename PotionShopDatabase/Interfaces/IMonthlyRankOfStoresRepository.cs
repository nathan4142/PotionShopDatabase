using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionShopDatabase.Models;


namespace PotionShopDatabase
{
    internal interface IMonthlyRankOfStoresRepository
    {
        IReadOnlyList<(int, int, Store, decimal, int)> GetMonthlyRankOfStores(DateTime firstDate, DateTime secondDate);
    }
}
