using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionShopDatabase.Models;

namespace PotionShopDatabase
{
    public interface IEmployeeRepository
    {
        Employee CreateEmployee(int storeID, string firstName, string lastName, string employeeHours, int salary, string position, int goldStars);
        IReadOnlyList<Employee> GetAllEmployees();

        bool EditEmployeeHours(int employeeID, string newHours);
    }
}
