using PotionShopDatabase;
using PotionShopDatabase.Models;
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
    public partial class StoreItemTable : Form
    {
        private DataTable table = new DataTable();
        public StoreItemTable()
        {
            InitializeComponent();
            ReadStoreItems();
        }

        private void ReadStoreItems()
        {
            table = new DataTable();
            table.Columns.Add("StoreItemID");
            table.Columns.Add("ItemID");
            table.Columns.Add("StoreID");
            table.Columns.Add("Quantity");
            table.Columns.Add("UnitListPrice");


            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");


            var storeItems = repo.GetAllStoreItems();

            foreach (var item in storeItems)
            {
                var row = table.NewRow();
                row["StoreItemID"] = item.StoreItemID;
                row["ItemID"] = item.ItemID;
                row["StoreID"] = item.StoreID;
                row["Quantity"] = item.Quantity;
                row["UnitListPrice"] = item.UnitListPrice;

                table.Rows.Add(row);
            }

            this.ux_StoreItemsTable.DataSource = table;

        }


        private void ux_EditStoreItemQuantity_Click(object sender, EventArgs e)
        {
            int lastRowIndex = ux_StoreItemsTable.AllowUserToAddRows ? ux_StoreItemsTable.Rows.Count - 2 : ux_StoreItemsTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_StoreItemsTable.Rows[lastRowIndex].Cells["StoreItemID"].Value;
            //Gets the employeeID from the user
            string StoreItemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the StoreItemID of the Store Item whose Quantity you want to edit:",
            "Edit Store Item Quantity",
            "");
            if (string.IsNullOrWhiteSpace(StoreItemIDInput))
            {
                MessageBox.Show("StoreItemID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.TryParse(StoreItemIDInput, out int value))
            {
                MessageBox.Show("StoreItemID has to be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(StoreItemIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"StoreItemID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gets the new Quantity from the user
            string newQuantityInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Quantity for the StoreItem:",
            "Edit Store Item Quantity",
            "");
            if (string.IsNullOrWhiteSpace(newQuantityInput))
            {
                MessageBox.Show("Quantity cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.TryParse(newQuantityInput, out int value))
            {
                MessageBox.Show("The new Quantity has to be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string StoreItemID = StoreItemIDInput;
            string updatedQuantity = newQuantityInput;


            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");

            bool success = repo.EditStoreItemQuantity(Int32.Parse(StoreItemID), Int32.Parse(updatedQuantity));
            if (success)
            {
                ReadStoreItems();
            }
        }

        private void ux_EditStoreItemUnitListPrice_Click(object sender, EventArgs e)
        {
            int lastRowIndex = ux_StoreItemsTable.AllowUserToAddRows ? ux_StoreItemsTable.Rows.Count - 2 : ux_StoreItemsTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_StoreItemsTable.Rows[lastRowIndex].Cells["StoreItemID"].Value;
            //Gets the employeeID from the user
            string StoreItemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the StoreItemID of the Store Item whose Unit List Price you want to edit:",
            "Edit Store Item Unit List Price",
            "");
            if (string.IsNullOrWhiteSpace(StoreItemIDInput))
            {
                MessageBox.Show("StoreItemID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.TryParse(StoreItemIDInput, out int value))
            {
                MessageBox.Show("StoreItemID has to be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(StoreItemIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show("StoreItemID cannot be greater than the number of rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gets the new ULP from the user
            string newULPInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Unit List Price for the StoreItem:",
            "Edit Store Item Unit List Price",
            "");

            if (string.IsNullOrWhiteSpace(newULPInput))
            {
                MessageBox.Show("Unit List Price cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Decimal.TryParse(newULPInput, out decimal value) || value >= 1000.00m)
            {
                MessageBox.Show("Unit List Price has to be a number less than 1000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string StoreItemID = StoreItemIDInput;
            string updatedULP = newULPInput;


            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");

            bool success = repo.EditStoreItemUnitListPrice(Int32.Parse(StoreItemID), Decimal.Parse(updatedULP));
            if (success)
            {
                ReadStoreItems();
            }
        }

        private void ux_DeleteStoreItem_Click(object sender, EventArgs e)
        {
            int lastRowIndex = ux_StoreItemsTable.AllowUserToAddRows ? ux_StoreItemsTable.Rows.Count - 2 : ux_StoreItemsTable.Rows.Count - 1;

            // Get the value from the "ID" column
            var idValue = ux_StoreItemsTable.Rows[lastRowIndex].Cells["StoreItemID"].Value;
            //Gets the employeeID from the user
            string StoreItemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the StoreItemID of the Store Item you want to delete:",
            "Delete Store Item",
            "");

            if (string.IsNullOrWhiteSpace(StoreItemIDInput))
            {
                MessageBox.Show("EmployeeID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.TryParse(StoreItemIDInput, out int i))
            {

            }
            else if (Int32.Parse(StoreItemIDInput) > Int32.Parse((string)idValue))
            {
                MessageBox.Show($"EmployeeID cannot be greater than {idValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string StoreItemID = StoreItemIDInput;

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
            bool success = repo.DeleteStoreItem(Int32.Parse(StoreItemID));

            if (success)
            {
                ReadStoreItems();
            }
        }

        private void ux_CreateStoreItem_Click(object sender, EventArgs e)
        {


            
            //Gets the ItemID from the user
            string itemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the ItemID of the Item:",
            "Create Store Item",
            "");

            if (string.IsNullOrWhiteSpace(itemIDInput))
            {
                MessageBox.Show("ItemID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Int32.TryParse(itemIDInput, out int i))
            {
                MessageBox.Show("ItemID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string storeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the StoreID of the store that holds the item:",
            "Create Store Item",
            "");
            if (string.IsNullOrWhiteSpace(storeIDInput))
            {
                MessageBox.Show("StoreID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Int32.TryParse(storeIDInput, out int i))
            {
                MessageBox.Show("StoreID has to be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(storeIDInput) > 25)
            {
                MessageBox.Show("StoreID cannot be greater than 25.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gets the new ULP from the user
            string newQuantityInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the Quantity of the StoreItem:",
            "Create Store Item",
            "");
            if (string.IsNullOrWhiteSpace(newQuantityInput))
            {
                MessageBox.Show("Quantity cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Int32.TryParse(newQuantityInput, out int value))
            {
                MessageBox.Show("The Quantity has to be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gets the new ULP from the user
            string newULPInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the Unit List Price of the Item:",
            "Create Store Item",
            "");

            if (string.IsNullOrWhiteSpace(newULPInput))
            {
                MessageBox.Show("Unit List Price cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Decimal.TryParse(newULPInput, out decimal value) || value >= 1000.00m)
            {
                MessageBox.Show("Unit List Price has to be a number less than 1000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string itemID = itemIDInput;
            string storeID = storeIDInput;
            string quantity = newQuantityInput;
            string ulp = newULPInput;

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
            repo.CreateStoreItem(Int32.Parse(itemID), Int32.Parse(storeID), Int32.Parse(quantity), Decimal.Parse(ulp));


                ReadStoreItems();

        }
    }
}
