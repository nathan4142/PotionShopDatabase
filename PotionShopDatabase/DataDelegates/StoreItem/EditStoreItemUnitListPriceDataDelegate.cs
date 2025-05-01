using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class EditStoreItemUnitListPriceDataDelegate : NonQueryDataDelegate<bool>
    {
        private readonly int StoreItemID;
        private readonly decimal newULP;

        public EditStoreItemUnitListPriceDataDelegate(int StoreItemID, decimal newULP) : base("PotionShop.EditStoreItemUnitListPrice")
        {
            this.StoreItemID = StoreItemID;
            this.newULP = newULP;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@StoreItemID", StoreItemID);
            command.Parameters.AddWithValue("@NewUnitListPrice", newULP);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
