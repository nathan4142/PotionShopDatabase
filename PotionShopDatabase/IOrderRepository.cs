using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionShopDatabase.Models;

namespace PotionShopDatabase
{
    public interface IOrderRepository
    {
        Order CreateOrder(int storeID, DateTime orderedOn);
    }
}
