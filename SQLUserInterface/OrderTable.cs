using System.Data;
using PotionShopDatabase;
using PotionShopDatabase.Models;

namespace SQLUserInterface
{
    public partial class OrderTable : Form
    {
        private DataTable dataTable = new DataTable();
        public OrderTable()
        {
            InitializeComponent();
            ReadOrders();
        }

        private void ReadOrders()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("OrderID");
            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("OrderedOn");
            var repo = new SqlOrderRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
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

        private void ux_AddOrder_Click(object sender, EventArgs e)
        {
            string storeIDInput = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the StoreID of the new employee:",
            "Add Employee",
            "");
            if (int.TryParse(storeIDInput, out int storeID))
            {
                if(storeID >= 25)
                {
                    MessageBox.Show("StoreID must be less than 25.");
                    return;
                }
                else
                {
                    DateTime orderedOn = DateTime.Now;
                    var repo = new SqlOrderRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
                    repo.CreateOrder(storeID, orderedOn);
                    ReadOrders();
                }
                    
            }
            else
            {
                MessageBox.Show("Invalid StoreID. Please enter a valid number.");
            }
        }
    }
}
