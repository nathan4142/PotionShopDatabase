using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class EditStoreItemQuantityDataDelegate : NonQueryDataDelegate<bool>
    {
        private readonly int StoreItemID;
        private readonly int newQuantity;

        public EditStoreItemQuantityDataDelegate(int StoreItemID, int newQuantity) : base("PotionShop.EditStoreItemQuantity")
        {
            this.StoreItemID = StoreItemID;
            this.newQuantity = newQuantity;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@StoreItemID", StoreItemID);
            command.Parameters.AddWithValue("@NewQuantity", newQuantity);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }

}
