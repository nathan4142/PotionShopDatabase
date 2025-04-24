using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.Models
{
    /// <summary>
    /// creates a new storeitem
    /// </summary>
    public class StoreItem
    {
        public int StoreItemID { get; }
        public int ItemID { get; }
        public int StoreID { get; }
        public int Quantity { get; }
        public decimal UnitListPrice { get; }

        public StoreItem(int si, int i, int s, int q, decimal ulp)
        {
            StoreItemID = si;
            ItemID = i;
            StoreID = s;
            Quantity = q;
            UnitListPrice = ulp;
        }
    }
}
