using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase
{
    public interface IStoreItemRepository
    {
        /// <summary>
        /// creates a new storeitem in the repository
        /// </summary>
        /// <param name="itemID">item id</param>
        /// <param name="storeID">id of the store</param>
        /// <param name="quantity">quantity of the item</param>
        /// <param name="ulp">listed price of the uten</param>
        /// <returns>the new instance of store item</returns>
        StoreItem CreateStoreItem(int itemID, int storeID, int quantity, decimal ulp);

        /// <summary>
        /// Edits the quantity of a store Item
        /// </summary>
        /// <param name="storeitemID">ID of the Store Item</param>
        /// <param name="newQuantity">new quantityt</param>
        /// <returns>whether the Item was edited</returns>
        public bool EditStoreItemQuantity(int storeitemID, int newQuantity);

        /// <summary>
        /// Edits the Unit List Price of a Store Item
        /// </summary>
        /// <param name="storeItemID">Id of the Store Item</param>
        /// <param name="newULP">new Unit List Price</param>
        /// <returns>whether the Item was edited</returns>
        public bool EditStoreItemUnitListPrice(int storeItemID, decimal newULP);


        IReadOnlyList<StoreItem> GetAllStoreItems();

    }
}
