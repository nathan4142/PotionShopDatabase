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
            var repo = new SqlOrderRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez;Integrated Security=SSPI;");
            var orders = repo.GetAllOrders();



        }

        private void OrderTable_Load(object sender, EventArgs e)
        {

        }
    }
}
