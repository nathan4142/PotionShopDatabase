using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class EditItemPriceDataDelegate : NonQueryDataDelegate<bool>
    {
        private readonly int itemID;
        private readonly decimal newPrice;

        public EditItemPriceDataDelegate(int itemID, decimal newPrice) : base("PotionShop.EditItemPrice")
        {
            this.itemID = itemID;
            this.newPrice = newPrice;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@ItemID", itemID);
            command.Parameters.AddWithValue("@NewPrice", newPrice);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
