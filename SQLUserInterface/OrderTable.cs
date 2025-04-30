using System.Data;
using PotionShopDatabase;
using PotionShopDatabase.Models;

namespace SQLUserInterface
{
    public partial class OrderTable : Form
    {
        public OrderTable()
        {
            InitializeComponent();
            ReadOrders();
        }

        private void ReadOrders()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("OrderID");
            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("OrderedOn");
            var repo = new SqlOrderRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;");
            var orders = repo.GetAllOrders();

            foreach (var order in orders)
            {
                var row = dataTable.NewRow();
                row["OrderID"] = order.OrderID;
                row["StoreID"] = order.StoreID;
                row["OrderedOn"] = order.OrderedOn;

                dataTable.Rows.Add(row);
            }

            this.ux_OrderTable.DataSource = dataTable;

        }

        
        
    }
}
