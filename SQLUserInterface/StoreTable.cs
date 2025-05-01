using System.Data;
using PotionShopDatabase;
using PotionShopDatabase.Models;

namespace SQLUserInterface
{
    public partial class StoreTable : Form
    {
        private DataTable dataTable = new DataTable();
        public StoreTable()
        {
            InitializeComponent();
            ReadStores();
        }

        /// <summary>
        /// Reads the Stores from the SQL Table Database
        /// </summary>
        private void ReadStores()
        {
            //Creates table with the necessary rows
            dataTable = new DataTable();

            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("StateCode");
            dataTable.Columns.Add("ZipCode");

            //Goes to the repository which is where we will call the methods from
<<<<<<< HEAD
            var repo = new SqlStoreRepository(@"Server=(localdb)\MSSQLLocalDb;Database=zalatta;Integrated Security=SSPI;"); 
=======
            var repo = new SqlStoreRepository(@"Server=(localdb)\MSSQLLocalDb;Database=danielcortez;Integrated Security=SSPI;"); 
>>>>>>> 086b8a7fcfd00d9bdf132f4132bfd72a919c55cd
            //Calls the get all stores method and stores it in the stores variable
            var stores = repo.GetAllStores();
            //For each of the stores in stores, we add it to the dataTable
            foreach (var store in stores)
            {
                
                var row = dataTable.NewRow();

                row["StoreID"] = store.StoreID;
                row["Address"] = store.Address;
                row["StateCode"] = store.StateCode;
                row["ZipCode"] = store.ZipCode;

                dataTable.Rows.Add(row);
            }

            this.ux_StoreTable.DataSource = dataTable;

        }

        private void ux_backButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
