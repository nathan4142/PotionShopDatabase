using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class DeleteStoreItemDataDelegate : NonQueryDataDelegate<bool>
    {
            
        private readonly int storeItemID;

        public DeleteStoreItemDataDelegate(int storeItemID)
            : base("PotionShop.DeleteStoreItem")
        {
            this.storeItemID = storeItemID;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@StoreItemID", storeItemID);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
