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
            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
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

        private void ux_EditEmployeeHours_Click(object sender, EventArgs e)
        {
            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee whose hours you want to edit:",
            "Edit Employee Hours",
            "");
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Int32.Parse(employeeIDInput) > 500)
            {
                MessageBox.Show("EmployeeID cannot be greater than 500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //Gets the new hours from the user
                string newHoursInput = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the new hours for the employee (Format HH:MM-HH:MM):",
                "Edit Employee Hours",
                "");
            if (!System.Text.RegularExpressions.Regex.IsMatch(newHoursInput, @"^\d{2}:\d{2}-\d{2}:\d{2}$"))
            {
                MessageBox.Show("Invalid hours format. Please use the format ##:##-##:##.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string employeeID = employeeIDInput;
            string updatedHours = newHoursInput;

            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
            bool success = repo.EditEmployeeHours(Int32.Parse(employeeID), updatedHours);
            if (success)
            {
                ReadEmployees();
            }


        }

        private void ux_EditEmployeeGoldStars_Click(object sender, EventArgs e)
        {
            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee whose gold stars you want to edit:",
            "Edit Employee Gold Stars",
            "");
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(employeeIDInput) > 500)
            {
                MessageBox.Show("EmployeeID cannot be greater than 500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gets the new hours from the user
            string newGoldStarsInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new gold stars for the employee:",
            "Edit Employee Gold Stars",
            "");

            string employeeID = employeeIDInput;
            string updatedGoldStars = newGoldStarsInput;

            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
            bool success = repo.EditEmployeeGoldStars(Int32.Parse(employeeID), Int32.Parse(updatedGoldStars));
            if (success)
            {
                ReadEmployees();
            }
        }

        private void ux_EditEmployeePosition_Click(object sender, EventArgs e)
        {

        }

        private void ux_EditEmployeeSalary_Click(object sender, EventArgs e)
        {
            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee whose salary you want to edit:",
            "Edit Employee Salary",
            "");
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(employeeIDInput) > 500)
            {
                MessageBox.Show("EmployeeID cannot be greater than 500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gets the new hours from the user
            string newSalaryInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Salary for the employee:",
            "Edit Employee Salary",
            "");

            string employeeID = employeeIDInput;
            string updatedSalary = newSalaryInput;

            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
            bool success = repo.EditEmployeeSalary(Int32.Parse(employeeID), Int32.Parse(updatedSalary));
            if (success)
            {
                ReadEmployees();
            }
        }
    }
}


