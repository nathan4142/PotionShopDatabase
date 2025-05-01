using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase
{
    public interface IItemRepository
    {
        Item CreateItem(string name, decimal price, int potionTypeID);
        public bool EditItemPrice(int ItemID, decimal newPrice);

        IReadOnlyList<Item> GetAllItems();
    }
}
