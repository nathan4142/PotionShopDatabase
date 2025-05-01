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

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
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

            var repo = new SqlStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
            bool success = repo.EditStoreItemUnitListPrice(Int32.Parse(StoreItemID), Decimal.Parse(updatedULP));
            if (success)
            {
                ReadStoreItems();
            }
        }
    }
}
