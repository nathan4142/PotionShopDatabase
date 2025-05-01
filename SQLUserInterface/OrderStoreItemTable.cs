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
    public partial class OrderStoreItemTable : Form
    {
        private DataTable dataTable = new DataTable();
        public OrderStoreItemTable()
        {
            InitializeComponent();
            ReadOrderStoreItems();
        }

        public void ReadOrderStoreItems()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("OrderID");
            dataTable.Columns.Add("StoreItemID");
            dataTable.Columns.Add("ItemQuantity");

            //Goes to the repository which is where we will call the methods from
<<<<<<< HEAD
            var repo = new SqlOrderStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
=======
            var repo = new SqlOrderStoreItemRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez;Integrated Security=SSPI;");
>>>>>>> 086b8a7fcfd00d9bdf132f4132bfd72a919c55cd
            //Calls the get all items method and items it in the items variable
            var orderStoreItems = repo.GetAllOrderStoreItems();
            //For each of the items in items, we add it to the dataTable
            foreach (var orderStoreItem in orderStoreItems)
            {
                var row = dataTable.NewRow();

                row["OrderID"] = orderStoreItem.OrderID;
                row["StoreItemID"] = orderStoreItem.StoreItemID;
                row["ItemQuantity"] = orderStoreItem.ItemQuantity;

                dataTable.Rows.Add(row);
            }

            this.ux_OrderStoreItemTable.DataSource = dataTable;
        }
    }
}
