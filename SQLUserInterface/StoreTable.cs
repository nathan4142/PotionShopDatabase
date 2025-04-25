using System.Data;
using PotionShopDatabase;
using PotionShopDatabase.Models;

namespace SQLUserInterface
{
    public partial class StoreTable : Form
    {
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
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("StateCode");
            dataTable.Columns.Add("ZipCode");

            //Goes to the repository which is where we will call the methods from
            var repo = new SqlStoreRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
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

        private void ux_findCoolestStores_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("StoreID");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("StateCode");
            dataTable.Columns.Add("ZipCode");
            dataTable.Columns.Add("TotalGoldStars");

            var repo = new SqlStoreRepository(@"Server=(localdb)\MSSQLLocalDb;Database=nathanproctor;Integrated Security=SSPI;");
            int goldStars = (int)ux_numGoldStars.Value;
            var coolestStores = repo.GetCoolestStores(goldStars);

            foreach (var store in coolestStores)
            {
                var row = dataTable.NewRow();

                row["StoreID"] = store.StoreID;
                row["Address"] = store.Address;
                row["StateCode"] = store.StateCode;
                row["ZipCode"] = store.ZipCode;
                row["TotalGoldStars"] = store.TotalGoldStars;
                dataTable.Rows.Add(row);
            }

            ux_StoreTable.DataSource = dataTable;


        }
    }
}
