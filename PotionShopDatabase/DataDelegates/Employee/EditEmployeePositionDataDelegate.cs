using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class EditEmployeePositionDataDelegate : NonQueryDataDelegate<bool>
    {
        private readonly int employeeID;
        private readonly string newPosition;

        public EditEmployeePositionDataDelegate(int employeeID, string newPosition) : base("PotionShop.EditEmployeePosition")
        {
            this.employeeID = employeeID;
            this.newPosition = newPosition;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@EmployeeID", employeeID);
            command.Parameters.AddWithValue("@NewPosition", newPosition);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
