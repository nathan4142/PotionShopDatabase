using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.Models
{
    public class Employee
    {
        public int EmployeeID { get; }
        public int StoreID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string EmployeeHours { get; }
        public int Salary { get; }
        public string Position { get; }
        public int GoldStars { get; }

        internal Employee(int employeeID, int storeID, string firstName, string lastName, string employeeHours,
            int salary, string position, int goldStars)
        {
            EmployeeID = employeeID;
            StoreID = storeID;
            FirstName = firstName;
            LastName = lastName;
            EmployeeHours = employeeHours;
            Salary = salary;
            Position = position;
            GoldStars = goldStars;
        }
    }
}
