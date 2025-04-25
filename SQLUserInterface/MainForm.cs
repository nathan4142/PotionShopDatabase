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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ux_tableComboBox.Items.Add("Store");
            ux_tableComboBox.Items.Add("Employee");

            ux_tableComboBox.SelectedIndex = 0;


        }

        private void ux_openTableButton_Click(object sender, EventArgs e)
        {
            string selectedTable = ux_tableComboBox.SelectedItem.ToString();

            if (selectedTable == "Store")
            {
                var storeTable = new StoreTable();
                storeTable.Show();
            }
            else if (selectedTable == "Employee")
            {
                var employeeTable = new EmployeeTable();
                employeeTable.Show();
            }
            else
            {
                MessageBox.Show("Please select a valid table.");
            }
        }
    }
}
