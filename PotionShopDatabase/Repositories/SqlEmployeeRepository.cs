using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using PotionShopDatabase.Models;
using PotionShopDatabase.DataDelegates;

namespace PotionShopDatabase
{
    public class SqlEmployeeRepository(string connectionString) : IEmployeeRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public Employee CreateEmployee(int storeID, string firstName, string lastName, string employeeHours, int salary, string position, int goldStars)
        {
            //I cant do this for storeID, salary, or goldStars since they are ints. I'll convert them to strings to check i guess
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(storeID));
            ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
            ArgumentException.ThrowIfNullOrWhiteSpace(employeeHours);
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(salary));
            ArgumentException.ThrowIfNullOrWhiteSpace(position);
            ArgumentException.ThrowIfNullOrWhiteSpace(Convert.ToString(goldStars));

            var d = new CreateEmployeeDataDelegate(storeID, firstName, lastName, employeeHours, salary, position, goldStars);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Employee> GetAllEmployees()
        {
            return executor.ExecuteReader(new GetAllEmployeesDataDelegate());
        }
    }
}
