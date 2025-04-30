using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class EditEmployeeSalaryDataDelegate
        : NonQueryDataDelegate<bool>
    {
        private readonly int employeeID;
        private readonly int newSalary;

        public EditEmployeeSalaryDataDelegate(int employeeID, int newSalary)
            : base("PotionShop.EditEmployeeSalary")
        {
            this.employeeID = employeeID;
            this.newSalary = newSalary;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("@EmployeeID", employeeID);
            command.Parameters.AddWithValue("@NewSalary", newSalary);
        }

        public override bool Translate(Command command)
        {
            return true;
        }
    }
}
