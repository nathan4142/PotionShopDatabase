using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class DeleteItemDataDelegate
            : NonQueryDataDelegate<bool>
    {
        private readonly int itemID;

        public DeleteItemDataDelegate(int itemID)
            : base("PotionShop.DeleteItem")
        {
            this.itemID = itemID;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@ItemID", itemID);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
