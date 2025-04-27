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
    internal class CreateItemDataDelegate(string name, decimal price, PotionType potionTypeID): NonQueryDataDelegate<Item>("Item.CreateItem")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Price", price);
            command.Parameters.AddWithValue("PotionTypeID", potionTypeID);

            var p = command.Parameters.Add("ItemID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
            
        }

        public override Item Translate(Command command)
        {
            return new Item(command.GetParameterValue<int>("ItemID"), name, price, potionTypeID);
        }
    }
}
