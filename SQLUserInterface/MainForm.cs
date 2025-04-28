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
            ux_tableComboBox.Items.Add("Order");
            ux_tableComboBox.Items.Add("OrderItem");
            ux_tableComboBox.Items.Add("StoreItem");
            ux_tableComboBox.Items.Add("Item");
            ux_tableComboBox.Items.Add("Aggregates");

            ux_tableComboBox.SelectedIndex = 0;
            var chat = new ChatIsThisReal();
            chat.Show();

            //MessageBox.Show("You have (1) new message!");


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
            else if (selectedTable == "Order")
            {
                var orderTable = new OrderTable();
                orderTable.Show();
            }
            else if (selectedTable == "StoreItem")
            {
                var storeItemTable = new StoreItemTable();
                storeItemTable.Show();
            }
            else if (selectedTable == "Item")
            {
                var itemTable = new ItemTable();
                itemTable.Show();
            }
            else if (selectedTable == "Aggregates")
            {
                var aggregateTable = new AggregateTables();
                aggregateTable.Show();
            }
            else
            {
                MessageBox.Show("Please select a valid table.");
            }
        }
    }
}
