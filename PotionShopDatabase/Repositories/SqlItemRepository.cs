using DataAccess;
using PotionShopDatabase.DataDelegates;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase
{
    public class SqlItemRepository(string connectionString) : IItemRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public Item CreateItem(string name, decimal price, int potionTypeID)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(name));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(price));

            var d = new CreateItemDataDelegate(name, price, potionTypeID);
            return executor.ExecuteNonQuery(d);
        }
        public IReadOnlyList<Item> GetAllItems()
        {
            return executor.ExecuteReader(new GetAllItemsDataDelegate());
        }

        public bool EditItemPrice(int ItemID, decimal newPrice)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(ItemID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(newPrice));

            var d = new EditItemPriceDataDelegate(ItemID, newPrice);
            return executor.ExecuteNonQuery(d);
        }

        public bool DeleteItem(int ItemID)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(ItemID));

            var d = new DeleteItemDataDelegate(ItemID);
            return executor.ExecuteNonQuery(d);
        }



    }

}
