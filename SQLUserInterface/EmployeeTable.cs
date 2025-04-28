using PotionShopDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLUserInterface
{
    public partial class EmployeeTable : Form
    {
        public EmployeeTable()
        {
            InitializeComponent();
            ReadEmployees();
        }

        private void ReadEmployees()
        {
            //Creates table with the necessary rows
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("EmployeeID");
            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");
            dataTable.Columns.Add("EmployeeHours");
            dataTable.Columns.Add("Salary");
            dataTable.Columns.Add("Position");
            dataTable.Columns.Add("GoldStars");

            //Goes to the repository which is where we will call the methods from
            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez1011;Integrated Security=SSPI;");
            //Calls the get all employees method and employees it in the employees variable
            var employees = repo.GetAllEmployees();
            //For each of the employees in employees, we add it to the dataTable
            foreach (var employee in employees)
            {
                var row = dataTable.NewRow();

                row["EmployeeID"] = employee.EmployeeID;
                row["StoreID"] = employee.StoreID;
                row["FirstName"] = employee.FirstName;
                row["LastName"] = employee.LastName;
                row["EmployeeHours"] = employee.EmployeeHours;
                row["Salary"] = employee.Salary;
                row["Position"] = employee.Position;
                row["GoldStars"] = employee.GoldStars;


                dataTable.Rows.Add(row);
            }

            this.ux_EmployeeTable.DataSource = dataTable;
        }
    }
}
