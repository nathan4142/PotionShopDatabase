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

        public Item CreateItem(string name, string itemDescription, List<string> ingredients, decimal price, PotionType potionTypeID)
        {
            throw new NotImplementedException();
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

        /*
        public Item CreateItem(string name, string itemDescription, List<string> ingredients, decimal price, PotionType potionTypeID)
        {
        //converts ingredients to a string of ingredients that can be tested
        StringBuilder sb = new();
        foreach(string s in ingredients)
        {
            sb.Append(s);
            sb.Append(", ");
        }
        string ingredientstring = sb.ToString();

        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(itemDescription);
        ArgumentException.ThrowIfNullOrWhiteSpace(ingredientstring);
        ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(price));
        ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(potionTypeID));

        var d = new CreateItemDataDelegate(name, itemDescription, ingredients, price, potionTypeID);
        return executor.ExecuteNonQuery(d);
        }

        */


    }

}
