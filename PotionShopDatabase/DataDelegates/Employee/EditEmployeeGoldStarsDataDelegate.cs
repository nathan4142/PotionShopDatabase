using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionShopDatabase.Models;
using System.Data;

namespace PotionShopDatabase.DataDelegates
{
    internal class EditEmployeeGoldStarsDataDelegate
        : NonQueryDataDelegate<bool>
    {
        private readonly int employeeID;
        private readonly int newGoldStars;

        public EditEmployeeGoldStarsDataDelegate(int employeeID, int newGoldStars)
            : base("PotionShop.EditEmployeeGoldStars")
        {
            this.employeeID = employeeID;
            this.newGoldStars = newGoldStars;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@EmployeeID", employeeID);
            command.Parameters.AddWithValue("@NewGoldStars", newGoldStars);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
