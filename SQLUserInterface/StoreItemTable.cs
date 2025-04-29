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
        public StoreItemTable()
        {
            InitializeComponent();
            ReadStoreItems();
        }

        private void ReadStoreItems()
        {
            DataTable table = new DataTable();
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

    }
}
