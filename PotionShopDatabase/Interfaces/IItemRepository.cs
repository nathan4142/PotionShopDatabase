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
        Item CreateItem(string name, string itemDescription, List<string> ingredients, decimal price, PotionType potionTypeID);

        IReadOnlyList<Store> GetAllItems();
    }
}
