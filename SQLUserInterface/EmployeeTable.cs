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
        private DataTable dataTable = new DataTable();
        public EmployeeTable()
        {
            InitializeComponent();
            ReadEmployees();
        }

        private void ReadEmployees()
        {
            //Creates table with the necessary rows
            dataTable = new DataTable();

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
            int lastRowIndex = ux_EmployeeTable.AllowUserToAddRows ? ux_EmployeeTable.Rows.Count - 2 : ux_EmployeeTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_EmployeeTable.Rows[lastRowIndex].Cells["EmployeeID"].Value;
            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee whose hours you want to edit:",
            "Edit Employee Hours",
            "");
            foreach (char c in employeeIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("EmployeeID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(employeeIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"EmployeeID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int lastRowIndex = ux_EmployeeTable.AllowUserToAddRows ? ux_EmployeeTable.Rows.Count - 2 : ux_EmployeeTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_EmployeeTable.Rows[lastRowIndex].Cells["EmployeeID"].Value;

            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee whose gold stars you want to edit:",
            "Edit Employee Gold Stars",
            "");
            foreach (char c in employeeIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("EmployeeID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(employeeIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"EmployeeID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gets the new hours from the user
            string newGoldStarsInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new gold stars for the employee:",
            "Edit Employee Gold Stars",
            "");
            if (string.IsNullOrWhiteSpace(newGoldStarsInput))
            {
                MessageBox.Show("Gold Stars cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in newGoldStarsInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Gold Stars must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

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
            int lastRowIndex = ux_EmployeeTable.AllowUserToAddRows ? ux_EmployeeTable.Rows.Count - 2 : ux_EmployeeTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_EmployeeTable.Rows[lastRowIndex].Cells["EmployeeID"].Value;
            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee whose Position you want to edit:",
            "Edit Employee Position",
            "");
            foreach (char c in employeeIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("EmployeeID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(employeeIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"EmployeeID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gets the new Position from the user
            string newPositionInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Position for the employee:",
            "Edit Employee Position",
            "");
            if (string.IsNullOrWhiteSpace(newPositionInput))
            {
                MessageBox.Show("Position cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string employeeID = employeeIDInput;
            string updatedPosition = newPositionInput;


            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");

            bool success = repo.EditEmployeePosition(Int32.Parse(employeeID), updatedPosition);
            if (success)
            {
                ReadEmployees();
            }
        }

        private void ux_EditEmployeeSalary_Click(object sender, EventArgs e)
        {
            int lastRowIndex = ux_EmployeeTable.AllowUserToAddRows ? ux_EmployeeTable.Rows.Count - 2 : ux_EmployeeTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_EmployeeTable.Rows[lastRowIndex].Cells["EmployeeID"].Value;
            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee whose salary you want to edit:",
            "Edit Employee Salary",
            "");
            foreach (char c in employeeIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("EmployeeID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(employeeIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"EmployeeID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gets the new Salary from the user
            string newSalaryInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Salary for the employee:",
            "Edit Employee Salary",
            "");
            if (string.IsNullOrWhiteSpace(newSalaryInput))
            {
                MessageBox.Show("Salary cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in newSalaryInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("New Salary must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string employeeID = employeeIDInput;
            string updatedSalary = newSalaryInput;


            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");

            bool success = repo.EditEmployeeSalary(Int32.Parse(employeeID), Int32.Parse(updatedSalary));
            if (success)
            {
                ReadEmployees();
            }
        }

        private void ux_DeleteEmployee_Click(object sender, EventArgs e)
        {
            int lastRowIndex = ux_EmployeeTable.AllowUserToAddRows ? ux_EmployeeTable.Rows.Count - 2 : ux_EmployeeTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_EmployeeTable.Rows[lastRowIndex].Cells["EmployeeID"].Value;
            //Gets the employeeID from the user
            string employeeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the EmployeeID of the employee you want to delete:",
            "Delete Employee",
            "");
            foreach (char c in employeeIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("EmployeeID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(employeeIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(employeeIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"EmployeeID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string employeeID = employeeIDInput;
            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");

            bool success = repo.DeleteEmployee(Int32.Parse(employeeID));

            if (success)
            {
                ReadEmployees();
            }
        }

        private void ux_AddEmployee_Click(object sender, EventArgs e)
        {
            //Gets the employeeID from the user
            string storeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the StoreID of the store where the employee works:",
            "Create Employee",
            "");
            foreach (char c in storeIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("StoreID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(storeIDInput))
            {
                MessageBox.Show("StoreID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(storeIDInput) > 25)
            {
                MessageBox.Show("StoreID cannot be greater than 25.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string firstNameInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the First Name of the new employee",
            "Create Employee",
            "");
            if (string.IsNullOrWhiteSpace(firstNameInput))
            {
                MessageBox.Show("First Name cannot be empty cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lastNameInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the Last Name of the new employee:",
            "Create Employee",
            "");
            if (string.IsNullOrWhiteSpace(lastNameInput))
            {
                MessageBox.Show("Last Name cannot be empty cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newHoursInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the Hours for the new employee (Format HH:MM-HH:MM):",
            "Create Employee",
            "");
            if (string.IsNullOrWhiteSpace(firstNameInput))
            {
                MessageBox.Show("Employee Hours cannot be empty cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(newHoursInput, @"^\d{2}:\d{2}-\d{2}:\d{2}$"))
            {
                MessageBox.Show("Invalid hours format. Please use the format ##:##-##:##.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newSalaryInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the Salary for the new employee:",
            "Create Employee",
            "");
            if (string.IsNullOrWhiteSpace(newSalaryInput))
            {
                MessageBox.Show("Salary cannot be empty cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in newSalaryInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Salary must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string positionInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the position for the new employee:",
            "Edit Employee Salary",
            "");
            if (string.IsNullOrWhiteSpace(firstNameInput))
            {
                MessageBox.Show("Position cannot be empty cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            string storeID = storeIDInput;
            string firstName = firstNameInput;
            string lastName = lastNameInput;
            string employeeHours = newHoursInput;
            string salary = newSalaryInput;
            string position = positionInput;


            var repo = new SqlEmployeeRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");

            repo.CreateEmployee(Int32.Parse(storeID), firstName, lastName, employeeHours, Int32.Parse(salary), position, 0);


            ReadEmployees();

        }

    }
}


