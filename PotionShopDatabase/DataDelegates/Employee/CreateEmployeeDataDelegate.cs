using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using PotionShopDatabase.Models;
using System.Data;


namespace PotionShopDatabase.DataDelegates
{
    internal class CreateEmployeeDataDelegate(int storeID, string firstName, string lastName, string employeeHours, int salary, string position, int goldStars)
        : NonQueryDataDelegate<Employee>("PotionShop.CreateEmployee")

    {//In his project he has some that are private readonly but some arent and they are just plugged in elsewhere. Ill plug in elsewhere for now
        /*
        private readonly string firstName = firstName;      
        private readonly string lastName = lastName;
        */
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StoreID", storeID);
            command.Parameters.AddWithValue("FirstName", firstName);
            command.Parameters.AddWithValue("LastName", lastName);
            command.Parameters.AddWithValue("EmployeeHours", employeeHours);
            command.Parameters.AddWithValue("Salary", salary);
            command.Parameters.AddWithValue("Position", position);
            command.Parameters.AddWithValue("GoldStars", goldStars);

            var p = command.Parameters.Add("EmployeeID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }

        public override Employee Translate(Command command)
        {
            return new Employee(command.GetParameterValue<int>("EmployeeID"), storeID, firstName, lastName, employeeHours, salary, position, goldStars);
        }

    }
}
