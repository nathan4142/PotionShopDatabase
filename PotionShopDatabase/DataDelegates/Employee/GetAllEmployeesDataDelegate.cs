using DataAccess;
using PotionShopDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.DataDelegates
{
    internal class GetAllEmployeesDataDelegate()
        : DataReaderDelegate<IReadOnlyList<Employee>>("PotionShop.GetAllEmployees")
    {
        public override IReadOnlyList<Employee> Translate(Command command, IDataRowReader reader)
        {
            var employees = new List<Employee>();

            while (reader.Read())
            {
                employees.Add(new Employee(
                    reader.GetInt32("EmployeeID"),
                    reader.GetInt32("StoreID"),
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetString("EmployeeHours"),
                    reader.GetInt32("Salary"),
                    reader.GetString("Position"),
                    reader.GetInt32("GoldStars")));
            }

            return employees;
        }
    }
}
