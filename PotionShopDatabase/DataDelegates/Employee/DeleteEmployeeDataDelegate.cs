using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class DeleteEmployeeDataDelegate
        : NonQueryDataDelegate<bool>
    {
        private readonly int employeeID;

        public DeleteEmployeeDataDelegate(int employeeID)
            : base("PotionShop.DeleteEmployee")
        {
            this.employeeID = employeeID;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@EmployeeID", employeeID);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
