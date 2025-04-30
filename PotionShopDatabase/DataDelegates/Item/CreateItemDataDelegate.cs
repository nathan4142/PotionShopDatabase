using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class CreateItemDataDelegate : NonQueryDataDelegate<Item>
    {

        private readonly string name;
        private readonly decimal price;
        private readonly PotionType potionType;

        public CreateItemDataDelegate(string name, decimal price, PotionType potionType)
            : base("PotionShop.CreateItem")
        {
            this.name = name;
            this.price = price;
            this.potionType = potionType;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Price", price);
            command.Parameters.AddWithValue("PotionTypeID", (int)potionType);

            var p = command.Parameters.Add("ItemID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
            
        }

        public override Item Translate(Command command)
        {
            return new Item(
                command.GetParameterValue<int>("ItemID"),
                name,
                price, 
                potionType);
        }
    }
}
