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
    
    public partial class ItemTable : Form
    {
        private DataTable dataTable = new DataTable();
        public ItemTable()
        {
            InitializeComponent();
            ReadItems();
        }

        public void ReadItems()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("ItemID");
            dataTable.Columns.Add("PotionTypeID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Price");

            //Goes to the repository which is where we will call the methods from
            var repo = new SqlItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
            //Calls the get all items method and items it in the items variable
            var items = repo.GetAllItems();
            //For each of the items in items, we add it to the dataTable
            foreach (var item in items)
            {
                var row = dataTable.NewRow();

                row["ItemID"] = item.ItemID;
                row["Name"] = item.Name;
                row["PotionTypeID"] = item.PotionTypeID;
                row["Price"] = item.Price;

                dataTable.Rows.Add(row);
            }

            this.ux_ItemTable.DataSource = dataTable;
        }

        private void ux_EditItemPrice_Click(object sender, EventArgs e)
        {
			//Gets the employeeID from the user
			string ItemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
			"Enter the ItemID of the item whose price you want to edit:",
			"Edit Item Price",
			"");
			if (string.IsNullOrWhiteSpace(ItemIDInput))
			{
				MessageBox.Show("ItemID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (Int32.Parse(ItemIDInput) > 500)
			{
				MessageBox.Show("ItemID cannot be greater than 500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//Gets the new Salary from the user
			string newSalaryInput = Microsoft.VisualBasic.Interaction.InputBox(
			"Enter the new Price for the Item:",
			"Edit Item Price",
			"");

			string itemID = ItemIDInput;
			string updatedPrice = newSalaryInput;

			var repo = new SqlItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
			bool success = repo.EditItemPrice(Int32.Parse(itemID), Decimal.Parse(updatedPrice));
			if (success)
			{
				ReadItems();
			}
		}
    }
}
