using DataAccess;
using PotionShopDatabase.DataDelegates;
using PotionShopDatabase.Models;

namespace PotionShopDatabase
{
    public class SqlStoreItemRepository(string connectionString) : IStoreItemRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public StoreItem CreateStoreItem(int storeItemID, int storeID, int quantity, decimal ulp)
        {
            
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(storeItemID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(storeID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(quantity));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(ulp));

            var d = new CreateStoreItemDataDelegate(storeItemID, storeID, quantity, ulp);
            return executor.ExecuteNonQuery(d);
        }

        public bool EditStoreItemQuantity(int itemID, int newQuantity)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(itemID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(newQuantity));

            var d = new EditStoreItemQuantityDataDelegate(itemID, newQuantity);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<StoreItem> GetAllStoreItems()
        {
            return executor.ExecuteReader(new GetAllStoreItemsDataDelegate());
        }

        public bool EditStoreItemUnitListPrice(int storeItemID, decimal newULP)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(storeItemID));
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(newULP));

            var d = new EditStoreItemUnitListPriceDataDelegate(storeItemID, newULP);
            return executor.ExecuteNonQuery(d);
        }

    }
}

    

