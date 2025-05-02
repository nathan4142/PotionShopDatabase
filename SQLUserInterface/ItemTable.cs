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
            int lastRowIndex = ux_ItemTable.AllowUserToAddRows ? ux_ItemTable.Rows.Count - 2 : ux_ItemTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_ItemTable.Rows[lastRowIndex].Cells["ItemID"].Value;
            //Gets the ItemID from the user
            string ItemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the ItemID of the Item whose price you want to edit:",
            "Edit Item Price",
            "");

            if (string.IsNullOrWhiteSpace(ItemIDInput))
            {
                MessageBox.Show("ItemID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Int32.TryParse(ItemIDInput, out int i))
            {
                MessageBox.Show("ItemID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(ItemIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"ItemID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //Gets the new Salary from the user
            string newPriceInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Price for the Item:",
            "Edit Item Price",
            "");
            if (string.IsNullOrWhiteSpace(newPriceInput))
            {
                MessageBox.Show("Price cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Decimal.TryParse(newPriceInput, out decimal value))
            {
                MessageBox.Show("Price must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string itemID = ItemIDInput;
            string updatedPrice = newPriceInput;


            var repo = new SqlItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");

            bool success = repo.EditItemPrice(Int32.Parse(itemID), Decimal.Parse(updatedPrice));
            if (success)
            { 
                ReadItems();
            }
        }

        private void ux_AddItem_Click(object sender, EventArgs e)
        {
            //Gets the potion name
            string potionNameInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the name of the new Potion:",
            "Add Item",
            "");
            if (string.IsNullOrWhiteSpace(potionNameInput))
            {
                MessageBox.Show("Potion Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Gets the potion price
            string potionPriceInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the price of the new item:",
            "Add Item",
            "");
            if (!Decimal.TryParse(potionPriceInput, out decimal Price) || Price >= 1000.00m)
            {
                MessageBox.Show("PotionPrice has to be a number less than 1000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string potionTypeInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the potionType of the new item (select number):\nAttack = 1,\nDefence = 2,\nHealth = 3,\nEvil = 4,\nExplosion = 5,\nCharm = 6",
            "Add Item",
            "");
            if (int.TryParse(potionTypeInput, out int potionType))
            {
                if (potionType < 1 || potionType > 6)
                {
                    MessageBox.Show("potionType must be between 1 - 6");
                    return;
                }
                else
                {

                    var repo = new SqlItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
                    repo.CreateItem(potionNameInput, Convert.ToDecimal(potionPriceInput), Convert.ToInt32(potionType));
                    ReadItems();
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void ux_DeleteItem_Click(object sender, EventArgs e)
        {
            int lastRowIndex = ux_ItemTable.AllowUserToAddRows ? ux_ItemTable.Rows.Count - 2 : ux_ItemTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_ItemTable.Rows[lastRowIndex].Cells["ItemID"].Value;
            //Gets the ItemID from the user
            string ItemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the ItemID of the Item you want to delete:",
            "Delete Item",
            "");

            if (string.IsNullOrWhiteSpace(ItemIDInput))
            {
                MessageBox.Show("ItemID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Int32.TryParse(ItemIDInput, out int i))
            {
                MessageBox.Show("ItemID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Int32.Parse(ItemIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"ItemID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string itemID = ItemIDInput;

            var itemRepo = new SqlItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
            bool success = itemRepo.DeleteItem(Int32.Parse(itemID));
            if (success)
            {
               ReadItems();
            }

            }
        }
}
