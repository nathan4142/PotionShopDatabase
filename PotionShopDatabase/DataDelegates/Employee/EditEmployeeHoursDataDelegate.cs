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
    internal class EditEmployeeHoursDataDelegate
            : NonQueryDataDelegate<bool>
    {
        private readonly int employeeID;
        private readonly string newHours;

        public EditEmployeeHoursDataDelegate(int employeeID, string newHours)
            : base("PotionShop.EditEmployeeHours")
        {
            this.employeeID = employeeID;
            this.newHours = newHours;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@EmployeeID", employeeID);
            command.Parameters.AddWithValue("@NewHours", newHours);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
