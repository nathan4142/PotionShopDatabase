using DataAccess;
using PotionShopDatabase.Models;
using System.Transactions;

namespace PotionShopDatabase.Tests
{
    [TestClass]
    public class SqlEmployeeRepositoryTest
    {

        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=danielcortez1011;Integrated Security=SSPI;";

        private static string GetTestString() => Guid.NewGuid().ToString("N");

        private readonly IEmployeeRepository repo;
        private readonly TransactionScope transaction;

        public SqlEmployeeRepositoryTest()      //maybe PotionShopRepository but i doubt it
        {
            repo = new SqlEmployeeRepository(connectionString);
            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            transaction.Dispose();
        }

        [TestMethod]
        public void CreateEmployeeShouldWork()
        {
            var rand = new Random(); // needed for rng for int parameters
            var storeID = rand.Next(1, 100);
            var firstName = GetTestString();
            var lastName = GetTestString();
            var employeeHours = $"From {rand.Next(1, 12)} to {rand.Next(1, 12)}";
            var salary = rand.Next(10000, 100000);
            var position = GetTestString();
            var goldStars = rand.Next(0, 100);

            var actual = repo.CreateEmployee(storeID, firstName, lastName, employeeHours, salary, position, goldStars);

            Assert.IsNotNull(actual);
            Assert.AreEqual(storeID, actual.StoreID);
            Assert.AreEqual(firstName, actual.FirstName);
            Assert.AreEqual(lastName, actual.LastName);
            Assert.AreEqual(employeeHours, actual.EmployeeHours);
            Assert.AreEqual(salary, actual.Salary);
            Assert.AreEqual(position, actual.Position);
            Assert.AreEqual(goldStars, actual.GoldStars);
        }
    }
}