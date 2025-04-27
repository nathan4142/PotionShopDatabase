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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            ReadItems();
        }

        public void ReadItems()
        {
            DataTable dataTable = new DataTable();

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
    }
}
