using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionShopDatabase.Models;
using System.Data;

namespace PotionShopDatabase.DataDelegates
{
    internal class CreateStoreDataDelegate(string address, string stateCode, string zipCode) : NonQueryDataDelegate<Store>("Store.CreateStore")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Address", address);
            command.Parameters.AddWithValue("StateCode", stateCode);
            command.Parameters.AddWithValue("ZipCode", zipCode);

            var p = command.Parameters.Add("StoreID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }

        public override Store Translate(Command command)
        {
            return new Store(command.GetParameterValue<int>("StoreID"), address, stateCode, zipCode);
        }

    }
}
