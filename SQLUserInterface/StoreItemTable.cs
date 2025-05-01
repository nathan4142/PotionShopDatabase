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

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez;Integrated Security=SSPI;");

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

        private void ux_AddStoreItem_Click(object sender, EventArgs e)
        {
            string itemIDInput = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the ItemID of the new store item:",
                "Create StoreItem",
                "");
            if (string.IsNullOrWhiteSpace(itemIDInput))
            {
                MessageBox.Show("ItemID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Int32.Parse(itemIDInput) > 50)
            {
                MessageBox.Show("ItemID cannot be greater than 50.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in itemIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("ItemID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string storeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the StoreID of the store where the store item is:",
            "Create StoreItem",
            "");
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
            foreach (char c in storeIDInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("StoreID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string quantityInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the quantity of the store item:",
            "Create StoreItem",
            "");
            if (string.IsNullOrWhiteSpace(quantityInput))
            {
                MessageBox.Show("Quantity cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in quantityInput)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("StoreID must contain only integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string unitListPriceInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the UnitListPrice of the new store item:",
            "Create StoreItem",
            "");
            if (!Decimal.TryParse(unitListPriceInput, out decimal UnitListPrice))
            {
                MessageBox.Show("UnitListPrice has to be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemID = Int32.Parse(itemIDInput);
            int storeID = Int32.Parse(storeIDInput);
            int quantity = Int32.Parse(quantityInput);
            decimal ulp = Decimal.Parse(unitListPriceInput);

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez;Integrated Security=SSPI;");
            repo.CreateStoreItem(itemID, storeID, quantity, ulp);


        }

        private void ux_EditStoreItemQuantity_Click(object sender, EventArgs e)
        {
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
            else if (Int32.Parse(StoreItemIDInput) > table.Rows.Count)
            {
                MessageBox.Show("StoreItemID cannot be greater than the number of rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gets the new Salary from the user
            string newQuantityInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Quantity for the StoreItem:",
            "Edit Store Item Quantity",
            "");

            string StoreItemID = StoreItemIDInput;
            string updatedQuantity = newQuantityInput;

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez;Integrated Security=SSPI;");
            bool success = repo.EditStoreItemQuantity(Int32.Parse(StoreItemID), Int32.Parse(updatedQuantity));
            if (success)
            {
                ReadStoreItems();
            }
        }

        private void ux_EditStoreItemUnitListPrice_Click(object sender, EventArgs e)
        {
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
            else if (Int32.Parse(StoreItemIDInput) > table.Rows.Count)
            {
                MessageBox.Show("StoreItemID cannot be greater than the number of rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gets the new Salary from the user
            string newULPInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the new Unit List Price for the StoreItem:",
            "Edit Store Item Unit List Price",
            "");

            string StoreItemID = StoreItemIDInput;
            string updatedULP = newULPInput;

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez;Integrated Security=SSPI;");
            bool success = repo.EditStoreItemUnitListPrice(Int32.Parse(StoreItemID), Decimal.Parse(updatedULP));
            if (success)
            {
                ReadStoreItems();
            }
        }
    }
}
