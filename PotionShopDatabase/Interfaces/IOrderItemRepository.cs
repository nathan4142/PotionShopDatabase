using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase
{
    internal interface IOrderItemRepository
    {
        OrderItem CreateOrderItem(int orderID, int storeItemID, int itemQuantity);
    }
}
